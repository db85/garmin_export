using RestSharp;
using System;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

namespace GarminExport.Auth
{
    public class AuthService
    {
        private static readonly string REFERER = "https://sso.garmin.com/sso/signin?service=https%3A%2F%2Fconnect.garmin.com%2Fmodern%2F&webhost=https%3A%2F%2Fconnect.garmin.com%2Fmodern%2F&source=https%3A%2F%2Fconnect.garmin.com%2Fsignin&redirectAfterAccountLoginUrl=https%3A%2F%2Fconnect.garmin.com%2Fmodern%2F&redirectAfterAccountCreationUrl=https%3A%2F%2Fconnect.garmin.com%2Fmodern%2F&gauthHost=https%3A%2F%2Fsso.garmin.com%2Fsso&locale=de_DE&id=gauth-widget&cssUrl=https%3A%2F%2Fstatic.garmincdn.com%2Fcom.garmin.connect%2Fui%2Fcss%2Fgauth-custom-v1.2-min.css&privacyStatementUrl=https%3A%2F%2Fwww.garmin.com%2Fde-DE%2Fprivacy%2Fconnect%2F&clientId=GarminConnect&rememberMeShown=true&rememberMeChecked=false&createAccountShown=true&openCreateAccount=false&displayNameShown=false&consumeServiceTicket=false&initialFocus=true&embedWidget=false&generateExtraServiceTicket=true&generateTwoExtraServiceTickets=false&generateNoServiceTicket=false&globalOptInShown=true&globalOptInChecked=false&mobile=false&connectLegalTerms=true&showTermsOfUse=false&showPrivacyPolicy=false&showConnectLegalAge=false&locationPromptShown=true&showPassword=true";
        public Session Session { get; private set; }
        private RestClient SSOClient { get; set; }
        private RestClient ConnectClient { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }

        public AuthService(string userName, string password)
        {
            Session = new Session();
            SSOClient = new RestClient("https://sso.garmin.com")
            {
                CookieContainer = Session.Cookies,
                FollowRedirects = true
            };
            ConnectClient = new RestClient("http://connect.garmin.com/")
            {
                CookieContainer = Session.Cookies,
                FollowRedirects = true
            };
            UserName = userName;
            Password = password;
        }

        public bool SignIn()
        {
   
            try
            {
                var signInResponse = PostLogin(null);
                var ticketUrl = ParseServiceTicketUrl(signInResponse);
                return ProcessTicket(ticketUrl);
            }
            catch
            {
                return false;
            }
        }

        private bool ProcessTicket(string ticketUrl)
        {
            var ticketUrlFormatted = ticketUrl.Replace(@"\/", @"/");
            var ticketId = ticketUrlFormatted.Substring(ticketUrlFormatted.LastIndexOf("ticket=") + 7);
            var uri = new Uri("https://connect.garmin.com/modern/?ticket=" + ticketId);
            var client = new RestClient(uri.Scheme + "://" + uri.Host)
            {
                CookieContainer = Session.Cookies,
                FollowRedirects = true
            };
            var loginRequest = new RestRequest(uri.PathAndQuery, Method.GET);
            loginRequest.AddHeader("Referer", REFERER);
            var response = client.Execute(loginRequest);
            return IsDashboardUri(response.ResponseUri);
        }

        private static bool IsDashboardUri(Uri uri)
        {
            return uri.Host == "connect.garmin.com"
                && uri.LocalPath == "/modern/";
        }


        private string PostLogin(string flowExecutionKey)
        {
            var request = BuildAuthRequest(Method.POST);
            NameValueCollection formData = new NameValueCollection
            {
                { "username", UserName },
                { "password", Password },
                { "embed", "true" }
            };

            string formDataStr="";
            foreach (var key in formData.AllKeys)
            {
                formDataStr += key + "=" + formData[key] + "&";
            }
            var formDataBytes = Encoding.UTF8.GetBytes(formDataStr);
            request.AddParameter("application/x-www-form-urlencoded", formDataStr, ParameterType.RequestBody);
            request.AddHeader("Referer", REFERER);
            IRestResponse response = SSOClient.Execute(request);
            return response.Content;
        }

        private RestRequest BuildAuthRequest(Method method)
        {
            var authRequest = new RestRequest(REFERER, method);
            authRequest.AddHeader("Referer", REFERER);
            return authRequest;
        }

        private string ParseServiceTicketUrl(string content)
        {
            // var response_url = "http://connect.garmin.com/post-auth/login?ticket=ST-XXXXXX-XXXXXXXXXXXXXXXXXXXX-cas";
            var regex = new Regex("response_url\\s*=\\s*\"(?<url>[^\"]*)\"");
            var match = regex.Match(content);
            if (!match.Success)
                throw new Exception("Servcie ticket URL not found.");

            return match.Groups["url"].Value;
        }
    }
}

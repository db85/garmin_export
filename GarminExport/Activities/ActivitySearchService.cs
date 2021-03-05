using GarminExport.Auth;
using System;
using System.Collections.Generic;
using GarminExport.Activities.Model;
using Activity = GarminExport.Activities.Model.Activity;
using RestSharp;

namespace GarminExport.Activities
{
    //https://connect.garmin.com/proxy/activity-search-service-1.2/data_ns0.html
    public class ActivitySearchService
    {
        private readonly Session Session;
        private RestClient ConnectClient { get; set; }

        public ActivitySearchService(Session session)
        {
            this.Session = session;
            ConnectClient = new RestClient("https://connect.garmin.com/")
            {
                CookieContainer = Session.Cookies,
                FollowRedirects = true
            };
        }

        public List<Activity> FindActivities()
        {
            return FindActivities(new ActivitySearchFilters());
        }

        public List<Activity> FindActivities(ActivitySearchFilters filters)
        {
            var uri = new Uri("https://connect.garmin.com/modern/proxy/activitylist-service/activities/search/activities?" + filters.ToQueryString());
            var request = new RestRequest(uri, Method.GET);
            request.AddHeader("nk", "NT");
            var response = ConnectClient.Execute(request);
            return Activity.ParseActivityList(response.Content);
        }

        public List<Activity> FindAllActivities()
        {
            return FindAllActivities(new ActivitySearchFilters());
        }

        public List<Activity> FindAllActivities(ActivitySearchFilters filters)
        {
            filters.Start = 0;
            filters.Limit = 250;
            filters.SortBy = "startLocal";
            filters.SortOrder = "asc";


            var activities = new List<Activity>();
            do
            {
                Console.WriteLine("Searching from start {0}", filters.Start);
                var pageResult = FindActivities(filters);
                if (pageResult.Count == 0)
                    break;
                activities.AddRange(pageResult);

                filters.Start += pageResult.Count;
            } while (true);

            return activities;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GarminExport.Activities.Model
{
    [DataContract]
    public class Activity
    {
        [DataMember(Name = "activityId")]
        public string ActivityId { get; set; }

        [DataMember(Name = "activityName")]
        public string ActivityName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "startTimeLocal")]
        public DateTime StartTimeLocal { get; set; }

        [DataMember(Name = "startTimeGMT")]
        public DateTime StartTimeGMT { get; set; }

        [DataMember(Name = "activityType")]
        public ActivityType ActivityType { get; set; }

        [DataMember(Name = "eventType")]
        public EventType EventType { get; set; }

        [DataMember(Name = "parentId")]
        public long? ParentId { get; set; }

        [DataMember(Name = "distance")]
        public double? Distance { get; set; }

        [DataMember(Name = "duration")]
        public double? Duration { get; set; }

        [DataMember(Name = "elapsedDuration")]
        public double? ElapsedDuration { get; set; }

        [DataMember(Name = "movingDuration")]
        public double? MovingDuration { get; set; }

        [DataMember(Name = "elevationGain")]
        public double? ElevationGain { get; set; }

        [DataMember(Name = "elevationLoss")]
        public double? ElevationLoss { get; set; }

        [DataMember(Name = "averageSpeed")]
        public double? AverageSpeed { get; set; }

        [DataMember(Name = "maxSpeed")]
        public double? MaxSpeed { get; set; }

        [DataMember(Name = "startLatitude")]
        public double? StartLatitude { get; set; }

        [DataMember(Name = "startLongitude")]
        public double? StartLongitude { get; set; }

        [DataMember(Name = "hasPolyline")]
        public bool HasPolyline { get; set; }

        [DataMember(Name = "ownerId")]
        public int OwnerId { get; set; }

        [DataMember(Name = "ownerDisplayName")]
        public string OwnerDisplayName { get; set; }

        [DataMember(Name = "ownerFullName")]
        public string OwnerFullName { get; set; }

        [DataMember(Name = "ownerProfileImageUrlSmall")]
        public string OwnerProfileImageUrlSmall { get; set; }

        [DataMember(Name = "ownerProfileImageUrlMedium")]
        public string OwnerProfileImageUrlMedium { get; set; }

        [DataMember(Name = "ownerProfileImageUrlLarge")]
        public string OwnerProfileImageUrlLarge { get; set; }

        [DataMember(Name = "calories")]
        public double? Calories { get; set; }

        [DataMember(Name = "averageHR")]
        public double? AverageHR { get; set; }

        [DataMember(Name = "maxHR")]
        public double? MaxHR { get; set; }

        [DataMember(Name = "averageRunningCadenceInStepsPerMinute")]
        public double? AverageRunningCadenceInStepsPerMinute { get; set; }

        [DataMember(Name = "maxRunningCadenceInStepsPerMinute")]
        public double? MaxRunningCadenceInStepsPerMinute { get; set; }

        [DataMember(Name = "averageBikingCadenceInRevPerMinute")]
        public double? AverageBikingCadenceInRevPerMinute { get; set; }

        [DataMember(Name = "maxBikingCadenceInRevPerMinute")]
        public double? MaxBikingCadenceInRevPerMinute { get; set; }

        [DataMember(Name = "averageSwimCadenceInStrokesPerMinute")]
        public double? AverageSwimCadenceInStrokesPerMinute { get; set; }

        [DataMember(Name = "maxSwimCadenceInStrokesPerMinute")]
        public double? MaxSwimCadenceInStrokesPerMinute { get; set; }

        [DataMember(Name = "averageSwolf")]
        public double? AverageSwolf { get; set; }

        [DataMember(Name = "activeLengths")]
        public double? ActiveLengths { get; set; }

        [DataMember(Name = "steps")]
        public int? Steps { get; set; }

        [DataMember(Name = "numberOfActivityLikes")]
        public int? NumberOfActivityLikes { get; set; }

        [DataMember(Name = "numberOfActivityComments")]
        public int? NumberOfActivityComments { get; set; }

        [DataMember(Name = "likedByUser")]
        public int? LikedByUser { get; set; }

        [DataMember(Name = "commentedByUser")]
        public bool? CommentedByUser { get; set; }

        [DataMember(Name = "userRoles")]
        public string[] UserRoles { get; set; }

        [DataMember(Name = "privacy")]
        public Privacy Privacy { get; set; }

        [DataMember(Name = "userPro")]
        public bool UserPro { get; set; }

        [DataMember(Name = "courseId")]
        public int? CourseId { get; set; }

        [DataMember(Name = "poolLength")]
        public double? PoolLength { get; set; }

        [DataMember(Name = "unitOfPoolLength")]
        public Unit UnitOfPoolLength { get; set; }

        [DataMember(Name = "hasVideo")]
        public bool HasVideo { get; set; }

        [DataMember(Name = "VideoUrl")]
        public string VideoUrl { get; set; }

        [DataMember(Name = "timeZoneId")]
        public int TimeZoneId { get; set; }

        [DataMember(Name = "beginTimestamp")]
        public long BeginTimestamp { get; set; }

        [DataMember(Name = "sportTypeId")]
        public int? SportTypeId { get; set; }

        [DataMember(Name = "avgPower")]
        public double? AvgPower { get; set; }

        [DataMember(Name = "maxPower")]
        public double? MaxPower { get; set; }

        [DataMember(Name = "aerobicTrainingEffect")]
        public double? AerobicTrainingEffect { get; set; }

        [DataMember(Name = "anaerobicTrainingEffect")]
        public double? AnaerobicTrainingEffect { get; set; }

        [DataMember(Name = "strokes")]
        public double? Strokes { get; set; }

        [DataMember(Name = "normPower")]
        public double? NormPower { get; set; }

        [DataMember(Name = "leftBalance")]
        public double? LeftBalance { get; set; }

        [DataMember(Name = "rightBalance")]
        public double? RightBalance { get; set; }

        [DataMember(Name = "avgLeftBalance")]
        public double? AvgLeftBalance { get; set; }

        [DataMember(Name = "max20MinPower")]
        public double? Max20MinPower { get; set; }

        [DataMember(Name = "avgVerticalOscillation")]
        public double? AvgVerticalOscillation { get; set; }

        [DataMember(Name = "avgGroundContactTime")]
        public double? AvgGroundContactTime { get; set; }

        [DataMember(Name = "avgStrideLength")]
        public double? AvgStrideLength { get; set; }

        [DataMember(Name = "avgFractionalCadence")]
        public double? AvgFractionalCadence { get; set; }

        [DataMember(Name = "maxFractionalCadence")]
        public double? MaxFractionalCadence { get; set; }

        [DataMember(Name = "trainingStressScore")]
        public double? TrainingStressScore { get; set; }

        [DataMember(Name = "intensityFactor")]
        public double? IntensityFactor { get; set; }

        [DataMember(Name = "vO2MaxValue")]
        public double? VO2MaxValue { get; set; }

        [DataMember(Name = "avgVerticalRatio")]
        public double? AvgVerticalRatio { get; set; }

        [DataMember(Name = "avgGroundContactBalance")]
        public double? AvgGroundContactBalance { get; set; }

        [DataMember(Name = "lactateThresholdBpm")]
        public double? LactateThresholdBpm { get; set; }

        [DataMember(Name = "lactateThresholdSpeed")]
        public double? LactateThresholdSpeed { get; set; }

        [DataMember(Name = "maxFtp")]
        public double? MaxFtp { get; set; }

        [DataMember(Name = "avgStrokeDistance")]
        public double? AvgStrokeDistance { get; set; }

        [DataMember(Name = "avgStrokeCadence")]
        public double? AvgStrokeCadence { get; set; }

        [DataMember(Name = "maxStrokeCadence")]
        public double? MaxStrokeCadence { get; set; }

        [DataMember(Name = "workoutId")]
        public long? WorkoutId { get; set; }

        [DataMember(Name = "avgStrokes")]
        public double? AvgStrokes { get; set; }

        [DataMember(Name = "minStrokes")]
        public double? MinStrokes { get; set; }

        [DataMember(Name = "deviceId")]
        public long? DeviceId { get; set; }

        [DataMember(Name = "minTemperature")]
        public double? MinTemperature { get; set; }

        [DataMember(Name = "maxTemperature")]
        public double? MaxTemperature { get; set; }

        [DataMember(Name = "minElevation")]
        public double? MinElevation { get; set; }

        [DataMember(Name = "maxElevation")]
        public double? MaxElevation { get; set; }

        [DataMember(Name = "avgDoubleCadence")]
        public double? AvgDoubleCadence { get; set; }

        [DataMember(Name = "maxDoubleCadence")]
        public double? MaxDoubleCadence { get; set; }

        [DataMember(Name = "maxDepth")]
        public double? MaxDepth { get; set; }

        [DataMember(Name = "avgDepth")]
        public double? AvgDepth { get; set; }

        [DataMember(Name = "surfaceInterval")]
        public double? SurfaceInterval { get; set; }

        [DataMember(Name = "startN2")]
        public double? StartN2 { get; set; }

        [DataMember(Name = "endN2")]
        public double? EndN2 { get; set; }

        [DataMember(Name = "startCns")]
        public double? StartCns { get; set; }

        [DataMember(Name = "endCns")]
        public double? EndCns { get; set; }

        [DataMember(Name = "avgVerticalSpeed")]
        public double? AvgVerticalSpeed { get; set; }

        [DataMember(Name = "maxVerticalSpeed")]
        public double? MaxVerticalSpeed { get; set; }

        [DataMember(Name = "floorsClimbed")]
        public double? FloorsClimbed { get; set; }

        [DataMember(Name = "floorsDescended")]
        public double? FloorsDescended { get; set; }

        [DataMember(Name = "manufacturer")]
        public string Manufacturer { get; set; }

        [DataMember(Name = "diveNumber")]
        public double? DiveNumber { get; set; }

        [DataMember(Name = "locationName")]
        public string LocationName { get; set; }

        [DataMember(Name = "bottomTime")]
        public double? BottomTime { get; set; }

        [DataMember(Name = "lapCount")]
        public int? LapCount { get; set; }

        [DataMember(Name = "endLatitude")]
        public double? EndLatitude { get; set; }

        [DataMember(Name = "endLongitude")]
        public double? EndLongitude { get; set; }

        [DataMember(Name = "minAirSpeed")]
        public double? MinAirSpeed { get; set; }

        [DataMember(Name = "maxAirSpeed")]
        public double? MaxAirSpeed { get; set; }

        [DataMember(Name = "avgAirSpeed")]
        public double? AvgAirSpeed { get; set; }

        [DataMember(Name = "avgWindYawAngle")]
        public double? AvgWindYawAngle { get; set; }

        [DataMember(Name = "minCda")]
        public double? MinCda { get; set; }

        [DataMember(Name = "maxCda")]
        public double? MaxCda { get; set; }

        [DataMember(Name = "avgCda")]
        public double? AvgCda { get; set; }

        [DataMember(Name = "avgWattsPerCda")]
        public double? AvgWattsPerCda { get; set; }

        [DataMember(Name = "flow")]
        public double? Flow { get; set; }

        [DataMember(Name = "grit")]
        public double? Grit { get; set; }

        [DataMember(Name = "jumpCount")]
        public double? JumpCount { get; set; }

        [DataMember(Name = "caloriesEstimated")]
        public double? CaloriesEstimated { get; set; }

        [DataMember(Name = "caloriesConsumed")]
        public double? CaloriesConsumed { get; set; }

        [DataMember(Name = "waterEstimated")]
        public double? WaterEstimated { get; set; }

        [DataMember(Name = "waterConsumed")]
        public double? WaterConsumed { get; set; }

        [DataMember(Name = "maxAvgPower_1")]
        public double? MaxAvgPower_1 { get; set; }

        [DataMember(Name = "maxAvgPower_2")]
        public double? MaxAvgPower_2 { get; set; }

        [DataMember(Name = "maxAvgPower_5")]
        public double? MaxAvgPower_5 { get; set; }

        [DataMember(Name = "maxAvgPower_10")]
        public double? MaxAvgPower_10 { get; set; }

        [DataMember(Name = "maxAvgPower_20")]
        public double? MaxAvgPower_20 { get; set; }

        [DataMember(Name = "maxAvgPower_30")]
        public double? MaxAvgPower_30 { get; set; }

        [DataMember(Name = "maxAvgPower_60")]
        public double? MaxAvgPower_60 { get; set; }

        [DataMember(Name = "maxAvgPower_120")]
        public double? MaxAvgPower_120 { get; set; }

        [DataMember(Name = "maxAvgPower_300")]
        public double? MaxAvgPower_300 { get; set; }

        [DataMember(Name = "maxAvgPower_600")]
        public double? MaxAvgPower_600 { get; set; }

        [DataMember(Name = "maxAvgPower_1200")]
        public double? MaxAvgPower_1200 { get; set; }

        [DataMember(Name = "maxAvgPower_1800")]
        public double? MaxAvgPower_1800 { get; set; }

        [DataMember(Name = "maxAvgPower_3600")]
        public double? MaxAvgPower_3600 { get; set; }

        [DataMember(Name = "maxAvgPower_7200")]
        public double? MaxAvgPower_7200 { get; set; }

        [DataMember(Name = "maxAvgPower_18000")]
        public double? MaxAvgPower_18000 { get; set; }

        [DataMember(Name = "excludeFromPowerCurveReports")]
        public bool? ExcludeFromPowerCurveReports { get; set; }

        [DataMember(Name = "favorite")]
        public bool? Favorite { get; set; }

        [DataMember(Name = "decoDive")]
        public bool? DecoDive { get; set; }

        [DataMember(Name = "pr")]
        public bool? Pr { get; set; }

        [DataMember(Name = "autoCalcCalories")]
        public bool? AutoCalcCalories { get; set; }

        [DataMember(Name = "parent")]
        public bool? Parent { get; set; }

        [DataMember(Name = "atpActivity")]
        public bool? AtpActivity { get; set; }

        [DataMember(Name = "purposeful")]
        public bool? Purposeful { get; set; }

        [DataMember(Name = "elevationCorrected")]
        public bool? ElevationCorrected { get; set; }

        public static List<Activity> ParseActivityList(string json)
        {
            return JsonConvert.DeserializeObject<List<Activity>>(json);
        }
    }
}
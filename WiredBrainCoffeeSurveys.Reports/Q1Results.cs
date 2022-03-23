using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffeeSurveys.Reports
{
    public static class Q1Results
    {
        // Aggregate ratings
        public static double ServiceScore { get; set; } = 8.0;

        public static double CoffeeScore { get; set; } = 8.5;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavoriteProduct { get; set; } = "Cappucino";

        public static string LeastFavoriteProduct { get; set; } = "Granola";

        public static string AreaToImprove { get; set; } = "MobileApp";

        // Aggregate counts
        public static double NumberSurveyed { get; set; } = 500;

        public static double NumberResponded { get; set; } = 325;

        public static double NumberRewardsMembers { get; set; } = 130;
    }

    // Individual survey responses
    public static List<SurveyResponse> Responses = new List<SurveyResponses>()
    {
        new SurveyResponse()
        {
            EmailAddress = "test@sample.com",
            CoffeeScore = 8.0,
            FoodScore = 9.0,
            PriceScore = 7.0,
            ServiceScore = 8.5,
            AreaToImprove = "MobileApp",
            FavouriteProduct = "Latte",
            LeastFavouriteProduct = "Fruit",
            WouldRecommend = 8.0,
            Comments = "Coffee and service are great!"
        },
        new SurveyResponse()
        {
            EmailAddress = "test2@sample.com",
            CoffeeScore = 10.0,
            FoodScore = 6.0,
            PriceScore = 7.0,
            ServiceScore = 7.5,
            AreaToImprove = "MobileApp",
            FavouriteProduct = "Cappucino",
            LeastFavouriteProduct = "Fruit",
            WouldRecommend = 8.0,
            Comments = "The mobile app looks bad on Android devices"
        },
        new SurveyResponse()
        {
            EmailAddress = "test3@sample.com",
            CoffeeScore = 8.0,
            FoodScore = 7.0,
            PriceScore = 6.5,
            ServiceScore = 8.5,
            AreaToImprove = "Cleanliness",
            FavouriteProduct = "Americano",
            LeastFavouriteProduct = "Fruit",
            WouldRecommend = 8.0,
            Comments = "Overall I had a great experience, I like the store design."
        }
    }
}

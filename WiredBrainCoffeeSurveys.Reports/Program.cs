using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectedEmails = new List<string>();
            int counter = 0;

            while (selectedEmails.Count < 2 && counter < Q1Results.Responses.Count)
            {
                var currentItem = Q1Results.Responses[counter];

                if (currentItem.FavouriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                counter++;
            }

            GenerateTasksReport();
            GenerateCommentsReport();
        }

        private static void GenerateCommentsReport()
        {
            for (var i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i];

                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                }
            }

            foreach (var response in Q1Results.Responses)
            {
                if (respnse.AreaToImprove == Q1Results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                }
            }
        }

        public static void GenerateTasksReport()
        {
            var tasks = new List<string>();

            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Investigate coffee recipes and ingredents");
            }

            if (overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff.");
            }
            else
            {
                tasks.Add("Work with eployees for improvement ideas.");
            }

            if (responseRate < .33)
            {
                tasks.Add("Research options to improve response rate.");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffee coupon.");
            }
            else
            {
                tasks.Add("Reward participants with discount coffee coupon.");
            }

            switch (Q1Results.AreaToImprove)
            {
                case "RewardsProgram":
                    tasks.Add("Revisit the rewards deals.");
                    break;

                case "Cleanliness":
                    tasks.Add("Contact the cleaning vendor.");
                    break;

                case "MobileApp":
                    tasks.Add("Contact consulting fire about app.");
                    break;

                default:
                    tasks.Add("Investigate individual comments for ideas.");
                    break;
            }
        }
    }
}

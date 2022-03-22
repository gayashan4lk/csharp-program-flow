using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unasweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double averallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage : { responseRate }");
            Console.WriteLine($"Unanswered Surveys : { unasweredCount }");
            Console.WriteLine($"Overall Score : { averallScore }");
        }
    }
}

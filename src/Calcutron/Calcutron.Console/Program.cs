using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcutron.Core.Engine;
using Calcutron.Core.Models;
using Calcutron.Core.Repositories;

namespace Calcutron.Console
{
    class Program
    {
        private static readonly IHotelRoomRateRepository HotelRoomRateRepository = new HotelRoomRateRepository();
        private static readonly ISpecialOfferRepository SpecialOfferRepository = new SpecialOfferRepository();
        private static readonly IStayCalculator StayCalculator = new StayCalculator(HotelRoomRateRepository, SpecialOfferRepository);

        static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        static async Task MainAsync(string[] args)
        {
            System.Console.WriteLine("Welcome to calcutron");
            int adults = PromptInt("How many adults are traveling?");
            DateTime startDate = PromptDate("When are they traveling?"), endDate = PromptDate("When do they end their travel?");
            bool isHoneymoon = PromptBoolean("Are they on honeymoon?");
            var cheapestStay = StayCalculator.GetCheapest(adults, isHoneymoon, startDate, endDate);
            PrintStay(cheapestStay);
        }

        static string Prompt(string prompt)
        {
            System.Console.WriteLine(prompt);
            var response = System.Console.ReadLine();
            return response;
        }

        static DateTime PromptDate(string prompt)
        {
            while (true)
            {
                var response = Prompt(prompt);
                if (DateTime.TryParse(response, out var date)) return date;
                System.Console.WriteLine("Please enter a valid date");
            }
        }

        static int PromptInt(string prompt)
        {
            while (true)
            {
                var response = Prompt(prompt);
                if (int.TryParse(response, out var number)) return number;
                System.Console.WriteLine("Please enter a valid integer");
            }
        }

        static bool PromptBoolean(string prompt)
        {
            while (true)
            {
                var response = Prompt(prompt);
                if (bool.TryParse(response, out var boolean)) return boolean;
                System.Console.WriteLine("Please enter true or false");
            }
        }

        static void PrintStay(Stay stay)
        {
            if (stay == null)
            {
                System.Console.WriteLine("No stay could be found for your trip");
                return;
            }
            System.Console.WriteLine($"Staying for {stay.Nights} nights between {stay.StartDate.ToShortDateString()} to {stay.EndDate.ToShortDateString()}");
            System.Console.WriteLine($"Your stay is at {stay.CheapestRate.Name} and has {stay.ApplicableOffers.Count} offers applied for a total cost of £{stay.Price}");
        }
    }
}

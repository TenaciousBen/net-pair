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
            int adults = 0, children = 0;
            DateTime startDate = DateTime.MinValue, endDate = DateTime.MaxValue;
            var cheapestStay = StayCalculator.GetCheapest(adults, children, startDate, endDate);
            PrintStay(cheapestStay);
        }

        static string Prompt(string prompt)
        {
            System.Console.WriteLine(prompt);
            var response = System.Console.ReadLine();
            return response;
        }

        static void PrintStay(Stay stay)
        {
            System.Console.WriteLine($"Staying for {stay.Nights} nights between {stay.StartDate.ToShortDateString()} to {stay.EndDate.ToShortDateString()}");
            System.Console.WriteLine($"Your stay is at {stay.CheapestRate.Name} and has {stay.ApplicableOffers.Count} offers applied for a total cost of £{stay.Price}");
        }
    }
}

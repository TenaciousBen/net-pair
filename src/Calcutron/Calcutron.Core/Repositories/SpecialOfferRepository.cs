using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcutron.Core.Models;

namespace Calcutron.Core.Repositories
{
    public interface ISpecialOfferRepository
    {
        Task<List<SpecialOffer>> Get();
    }

    public class SpecialOfferRepository : ISpecialOfferRepository
    {
        public Task<List<SpecialOffer>> Get()
        {
            return Task.Factory.StartNew(() =>
            {
                var offers = new List<SpecialOffer>();
                var honeymoonOffer = new SpecialOffer
                {
                    ID = 1,
                    HoneymoonOnly = true,
                    ValidFrom = new DateTime(2018, 01, 01),
                    ValidTo = new DateTime(2018, 12, 31),
                    MinStayInNights = 10,
                    IsAbsolute = false,
                    SpecialOfferDiscountBasis = SpecialOfferDiscountBasis.Stay,
                    Value = 30
                };
                offers.Add(honeymoonOffer);
                var winterSaleFirstHalf = new SpecialOffer()
                {
                    ID = 2,
                    ValidFrom = new DateTime(2018, 01, 01),
                    ValidTo = new DateTime(2018, 3, 31),
                    IsAbsolute = true,
                    SpecialOfferDiscountBasis = SpecialOfferDiscountBasis.PerNight,
                    Value = 10
                };
                offers.Add(winterSaleFirstHalf);
                var winterSaleSecondHalf = new SpecialOffer()
                {
                    ID = 3,
                    ValidFrom = new DateTime(2018, 10, 01),
                    ValidTo = new DateTime(2018, 12, 31),
                    IsAbsolute = true,
                    SpecialOfferDiscountBasis = SpecialOfferDiscountBasis.PerNight,
                    Value = 10
                };
                offers.Add(winterSaleSecondHalf);
                return offers;
            });
        }
    }
}

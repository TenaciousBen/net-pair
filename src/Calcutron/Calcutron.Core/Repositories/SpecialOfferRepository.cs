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
                var rates = new List<SpecialOffer>();
                return rates;
            });
        }
    }
}

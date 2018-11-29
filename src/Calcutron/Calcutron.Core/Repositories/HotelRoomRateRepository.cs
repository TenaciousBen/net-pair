using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcutron.Core.Models;

namespace Calcutron.Core.Repositories
{
    public interface IHotelRoomRateRepository
    {
        Task<List<HotelRoomRate>> Get();
    }

    public class HotelRoomRateRepository : IHotelRoomRateRepository
    {
        public Task<List<HotelRoomRate>> Get()
        {
            return Task.Factory.StartNew(() =>
            {
                var rates = new List<HotelRoomRate>();
                return rates;
            });
        }
    }
}

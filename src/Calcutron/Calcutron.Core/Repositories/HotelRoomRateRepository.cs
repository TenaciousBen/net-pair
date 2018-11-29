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
                var seaViewFirstHalf = new HotelRoomRate
                {
                    ID = 1,
                    Name = "Sea View",
                    CostPerNight = 300,
                    MaxAdults = 3,
                    ValidFrom = new DateTime(2018, 1, 1),
                    ValidTo = new DateTime(2018, 6, 31)
                };
                rates.Add(seaViewFirstHalf);
                var seaViewSecondHalf = new HotelRoomRate
                {
                    ID = 2,
                    Name = "Sea View",
                    CostPerNight = 400,
                    MaxAdults = 3,
                    ValidFrom = new DateTime(2018, 7, 1),
                    ValidTo = new DateTime(2018, 12, 31)
                };
                rates.Add(seaViewSecondHalf);
                var rubbishTipViewFirstHalf = new HotelRoomRate
                {
                    ID = 3,
                    Name = "Rubbish Tip View",
                    CostPerNight = 40,
                    MaxAdults = 2,
                    ValidFrom = new DateTime(2018, 1, 1),
                    ValidTo = new DateTime(2018, 4, 31)
                };
                rates.Add(rubbishTipViewFirstHalf);
                var rubbishTipViewSecondHalf = new HotelRoomRate
                {
                    ID = 4,
                    Name = "Rubbish Tip View",
                    CostPerNight = 40,
                    MaxAdults = 2,
                    ValidFrom = new DateTime(2018, 9, 1),
                    ValidTo = new DateTime(2018, 12, 31)
                };
                rates.Add(rubbishTipViewSecondHalf);
                return rates;
            });
        }
    }
}

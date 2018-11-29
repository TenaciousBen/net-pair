using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcutron.Core.Models;
using Calcutron.Core.Repositories;

namespace Calcutron.Core.Engine
{
    public interface IStayCalculator
    {
        Stay GetCheapest(int adults, int children, DateTime startDate, DateTime endDate);
    }

    public class StayCalculator : IStayCalculator
    {
        private readonly IHotelRoomRateRepository _hotelRoomRateRepository;
        private readonly ISpecialOfferRepository _specialOfferRepository;

        public StayCalculator(IHotelRoomRateRepository hotelRoomRateRepository, ISpecialOfferRepository specialOfferRepository)
        {
            _hotelRoomRateRepository = hotelRoomRateRepository;
            _specialOfferRepository = specialOfferRepository;
        }

        public Stay GetCheapest(int adults, int children, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}

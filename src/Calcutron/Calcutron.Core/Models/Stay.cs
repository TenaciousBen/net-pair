using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcutron.Core.Models
{
    public class Stay
    {
        public HotelRoomRate CheapestRate { get; set; }
        public List<SpecialOffer> ApplicableOffers { get; set; }
        public decimal Price { get; set; }
        public int Nights { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

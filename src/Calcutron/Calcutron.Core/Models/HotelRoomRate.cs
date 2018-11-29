﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcutron.Core.Models
{
    public class HotelRoomRate
    {
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public decimal CostPerNight { get; set; }
        public decimal MaxAdults { get; set; }
        public decimal MaxChildren { get; set; }
    }
}

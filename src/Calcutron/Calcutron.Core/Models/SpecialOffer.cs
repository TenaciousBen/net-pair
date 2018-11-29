using System;
using System.Collections.Generic;

namespace Calcutron.Core.Models
{
    public class SpecialOffer
    {
        public int ID { get; set; }
        public decimal? RequiredAdults { get; set; }
        public decimal? MinStayInNights { get; set; }
        public bool HoneymoonOnly { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public SpecialOfferDiscountBasis SpecialOfferDiscountBasis { get; set; }
        /// <summary>
        /// If true, then the offer's value is an absolute figure, else it's a percentage
        /// </summary>
        public bool IsAbsolute { get; set; }
        public decimal Value { get; set; }
    }

    public enum SpecialOfferDiscountBasis
    {
        PerNight = 1,
        Stay = 2
    }
}
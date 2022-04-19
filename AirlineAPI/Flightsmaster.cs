using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineLibrary.Models
{
    public class Flightsmaster
    {
       [Key]
        public int FlightregistrationId { get; set; }
        public string? Flightname { get; set; }
        public decimal? Economyseats { get; set; }
        public decimal? Businessseats { get; set; }


    }
}

using AirlineLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineApp.App.Pages
{
    public partial class FlightDetail
    {
        [Parameter]
        public string FlightregistrationId { get; set; }
        public Flightsmaster Flightsmaster { get; set; } = new Flightsmaster();

        protected override Task OnInitializedAsync()
        {

            
            InitializeFlights();

            Flightsmaster = Flightsmasters.FirstOrDefault(e => e.FlightregistrationId == int.Parse(FlightregistrationId));


            return base.OnInitializedAsync();
        }

        public IEnumerable<Flightsmaster> Flightsmasters { get; set; }


        private void InitializeEmployees()
        {
            var e1 = new Flightsmaster
            {
                FlightregistrationId = 3,
                Flightname = "QW Airways",
                Economyseats = 10,
                Businessseats = 20,
            };

            var e2 = new Flightsmaster
            {
                FlightregistrationId = 4,
                Flightname = "AS Airways",
                Economyseats = 20,
                Businessseats = 10,
            };
            Flightsmasters = new List<Flightsmaster> { e1, e2 };
        }
    }
}

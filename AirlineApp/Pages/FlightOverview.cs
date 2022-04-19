using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class FlightOverview
    {
        protected override Task OnInitializedAsync()
        {

            InitializeEmployees();

            return base.OnInitializedAsync();
        }

        public IEnumerable<Flightsmaster> Flightsmasters { get; set; }



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

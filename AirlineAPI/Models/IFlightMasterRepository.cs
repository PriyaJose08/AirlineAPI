using AirlineLibrary.Models;

namespace AirlineAPI.Models
{
    public interface IFlightMasterRepository
    {
        IEnumerable<Flightsmaster> GetAllFlights();

        Flightsmaster GetFlightById(int FlightregistrationId);

        Flightsmaster AddFlight(Flightsmaster flightsmaster);

        Flightsmaster UpdateFlight(Flightsmaster flightsmaster);

        void DeleteFlight(int FlightregistrationId);
    }
}

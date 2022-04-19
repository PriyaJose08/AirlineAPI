using AirlineLibrary.Models;

namespace AirlineAPI.Models
{
    public class FlightMasterRepository : IFlightMasterRepository
    {
        private readonly AppDbContext _appDbContext;

        public FlightMasterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Flightsmaster> GetAllFlights()
        {
            return _appDbContext.FlightMasters;
        }

        public Flightsmaster GetFlightById(int FlightregistrationId)
        {
            return _appDbContext.FlightMasters.FirstOrDefault(c => c.FlightregistrationId == FlightregistrationId);
        }

        public Flightsmaster AddFlight(Flightsmaster flightsmaster)
        {
            var addedEntity = _appDbContext.FlightMasters.Add(flightsmaster);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Flightsmaster UpdateFlight(Flightsmaster flightsmaster)
        {
            var foundFlight = _appDbContext.FlightMasters.FirstOrDefault(e => e.FlightregistrationId == flightsmaster.FlightregistrationId);

            if (foundFlight != null)
            {
                foundFlight.FlightregistrationId = flightsmaster.FlightregistrationId;
                foundFlight.Flightname = flightsmaster.Flightname;
                foundFlight.Economyseats = flightsmaster.Economyseats;
                foundFlight.Businessseats = flightsmaster.Businessseats;


                _appDbContext.SaveChanges();

                return foundFlight;
            }

            return null;
        }

        public void DeleteFlight(int FlightregistrationId)
        {
            var foundFlight = _appDbContext.FlightMasters.FirstOrDefault(e => e.FlightregistrationId == FlightregistrationId);
            if (foundFlight == null) return;

            _appDbContext.FlightMasters.Remove(foundFlight);
            _appDbContext.SaveChanges();
        }
    }
}




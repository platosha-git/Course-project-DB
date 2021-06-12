using System;
using System.Collections.Generic;
using System.Linq;
using Tours.Repositories;
using Serilog.Core;

namespace Tours.ImpRepositories
{
    public class BookingRepository : IBookingRepository, IDisposable
    {
        private readonly ToursContext db;
        private readonly Logger logger;

        public BookingRepository(ToursContext createDB, Logger logDB)
        {
            db = createDB;
            logger = logDB;
        }

        public List<Booking> FindAll()
        {
            return db.Bookings.ToList();
        }

        public Booking FindByID(int id)
        {
            return db.Bookings.Find(id);
        }

        public void Add(Booking obj)
        {
        }

        public void Update(Booking obj)
        {
            try
            {
                db.Bookings.Update(obj);
                db.SaveChanges();
                logger.Information("+BookingRep : Booking {Number} was updated at Bookings", obj.Customer);
            }
            catch (Exception err)
            {
                logger.Error(err.Message, "+BookingRep : Error trying to update booking at Bookings");
            }
        }

        public void DeleteAll()
        {
            try
            {
                List<Booking> allBookings = FindAll();
                db.Bookings.RemoveRange(allBookings);
                db.SaveChanges();
                logger.Information("+BookingRep : All bookings were deleted from Bookings");
            }
            catch (Exception err)
            {
                logger.Error(err.Message, "+BookingRep : Error trying to delete all bookings from Bookings");
            }
        }

        public void DeleteByID(int id)
        {
        }

        public int[] GetBookToursByID(int id)
        {
            return FindByID(id).Toursid;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

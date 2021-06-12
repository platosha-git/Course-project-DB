
namespace Tours.Repositories
{
    public interface IBookingRepository : CrudRepository<Booking, int>
    {
        int[] GetBookToursByID(int id);
    }
}

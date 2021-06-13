
namespace Tours.Repositories
{
    public interface IBookingRepository : CrudRepository<Booking, int>
    { 
        Booking GetUserByLP(string login, string password);
        int[] GetBookToursByID(int id);
    }
}

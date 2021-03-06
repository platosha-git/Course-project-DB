using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface IHotelRepository : CrudRepository<Hotel, int>
    {
        List<Hotel> FindHotelsByCity(string city);
        Hotel FindHotelByName(string name);
        List<Hotel> FindHotelByType(string type);
        List<Hotel> FindHotelByClass(int cls);
        List<Hotel> FindHotelBySwimPool(bool sp);
        List<Hotel> FindHotelByLowCost(int cost);
    }
}

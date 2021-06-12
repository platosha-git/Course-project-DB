using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface IPlaneRepository : CrudRepository<Planeticket, int>
    {
        List<Planeticket> FindPlaneByLowCost(int cost);
    }
}

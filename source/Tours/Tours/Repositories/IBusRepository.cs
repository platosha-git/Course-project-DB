using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface IBusRepository : CrudRepository<Busticket, int>
    {
        List<Busticket> FindBusByLowCost(int cost);
    }

}

using System;
using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface IBusRepository : CrudRepository<Busticket, int>
    {
        List<Busticket> FindBusesByCityFrom(string city);
        List<Busticket> FindBusesByCityTo(string city);
        List<Busticket> FindBusesByDate(DateTime date);
        List<Busticket> FindBusByLowCost(int cost);
    }

}

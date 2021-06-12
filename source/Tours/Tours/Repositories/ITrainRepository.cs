using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface ITrainRepository : CrudRepository<Trainticket, int>
    {
        List<Trainticket> FindTrainByLowCost(int cost);
    }
}

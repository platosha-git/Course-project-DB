using System;
using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface ITrainRepository : CrudRepository<Trainticket, int>
    {
        List<Trainticket> FindTrainsByCityFrom(string city);
        List<Trainticket> FindTrainsByCityTo(string city);
        List<Trainticket> FindTrainsByDate(DateTime date);
        List<Trainticket> FindTrainByLowCost(int cost);
    }
}

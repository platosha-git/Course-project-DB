using System.Collections.Generic;
using Tours.ModelsDB;

namespace Tours.Repositories
{
    public interface IFunctionsRepository
    {
        FullUserTour GetFullTour(int TID);
    }
}

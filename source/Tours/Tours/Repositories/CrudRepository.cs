using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface CrudRepository<T, ID>
    {
        List<T> FindAll();
        T FindByID(ID id);
        void Add(T obj);
        void Update(T obj);
        void DeleteAll();
        void DeleteByID(ID id);
    }
}

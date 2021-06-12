﻿using System.Collections.Generic;

namespace Tours.Repositories
{
    public interface IFoodRepository : CrudRepository<Food, int>
    {
        List<Food> FindFoodByCategory(string cat);
        List<Food> FindFoodByVegMenu(bool vm);
        List<Food> FindFoodByChildMenu(bool cm);
        List<Food> FindFoodByBar(bool bar);
    }
}

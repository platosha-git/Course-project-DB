using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Tours
{
    public partial class Form1 : Form
    {
        bool IsVegMenu = false, IsChildMenu = false, IsBar = false;
        string Category = "";

        private void AddColumnsFood()
        {
            TablesGrid.Rows.Clear();
            TablesGrid.Columns.Clear();

            TablesGrid.Columns.Add("FoodID", "ИД питания");
            TablesGrid.Columns.Add("Category", "Тип");
            TablesGrid.Columns.Add("VegMenu", "Вегетарианское меню");
            TablesGrid.Columns.Add("ChildrenMenu", "Детское меню");
            TablesGrid.Columns.Add("Bar", "Бар");
            TablesGrid.Columns.Add("Cost", "Стоимость");
        }

        private void AllFood_Click(object sender, System.EventArgs e)
        {
            AddColumnsFood();

            List<Food> foodCat;
            if (Category != "")
            {
                foodCat = guest.GetFoodByCategory(Category);
            }
            else
            {
                foodCat = guest.GetAllFood();
            }

            if (IsVegMenu)
            {
                List<Food> foodVegMenu = guest.GetFoodByVegMenu(IsVegMenu);
                List<Food> res1 = foodCat.Intersect(foodVegMenu).ToList();
                foodCat = res1;
            }

            if (IsChildMenu)
            {
                List<Food> foodChildMenu = guest.GetFoodByChildMenu(IsChildMenu);
                List<Food> res2 = foodCat.Intersect(foodChildMenu).ToList();
                foodCat = res2;
            }

            if (IsBar)
            {
                List<Food> foodBar = guest.GetFoodByBar(IsChildMenu);
                List<Food> res3 = foodCat.Intersect(foodBar).ToList();
                foodCat = res3;
            }

            List<Food> food = foodCat;
            int numFood = food.Count;

            if (numFood > 0)
            {
                for (int i = 0; i < numFood; i++)
                {
                    Food curFood = food[i];
                    TablesGrid.Rows.Add(curFood.Foodid, curFood.Category, 
                                        curFood.Vegmenu, curFood.Childrenmenu, curFood.Bar, curFood.Cost);
                }
            }
            else
            {
                MessageBox.Show("Питание не найдено");
            }
        }

        private void FcheckVegMenu_CheckedChanged(object sender, EventArgs e)
        {
            IsVegMenu = FcheckVegMenu.Checked;
        }

        private void FcheckChildMenu_CheckedChanged(object sender, EventArgs e)
        {
            IsChildMenu = FcheckChildMenu.Checked;
        }

        private void FcheckBar_CheckedChanged(object sender, EventArgs e)
        {
            IsBar = FcheckBar.Checked;
        }

        private void FcomboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = FcomboBoxCategory.SelectedItem.ToString();
        }
    }
}

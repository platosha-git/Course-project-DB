using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Tours
{
    public partial class Form1 : Form
    {
        int Class = -1;
        bool IsSwimPool = false;
        string HotelCity = "", Type = "";

        private void AddColumnsHotel()
        {
            TablesGrid.Rows.Clear();
            TablesGrid.Columns.Clear();

            TablesGrid.Columns.Add("HotelID", "ИД отеля");
            TablesGrid.Columns.Add("City", "Город");
            TablesGrid.Columns.Add("Name", "Название");
            TablesGrid.Columns.Add("Type", "Тип размещения");
            TablesGrid.Columns.Add("Class", "Колиечство звезд");
            TablesGrid.Columns.Add("SwimPool", "Бассейн");
            TablesGrid.Columns.Add("Cost", "Стоимость");
        }

        private void AllHotels_Click(object sender, EventArgs e)
        {
            AddColumnsHotel();

            List<Hotel> hotelCity;
            if (HotelCity != "")
            {
                hotelCity = guest.GetHotelsByCity(HotelCity);
            }
            else
            {
                hotelCity = guest.GetAllHotels();
            }

            if (Type != "")
            {
                List<Hotel> hotelType = guest.GetHotelsByType(Type);
                List<Hotel> res1 = hotelCity.Intersect(hotelType).ToList();
                hotelCity = res1;
            }

            if (Class > 0)
            {
                List<Hotel> hotelClass = guest.GetHotelsByClass(Class);
                List<Hotel> res2 = hotelCity.Intersect(hotelClass).ToList();
                hotelCity = res2;
            }

            if (IsSwimPool)
            {
                List<Hotel> hotelSwimPool = guest.GetHotelsBySwimPool(IsSwimPool);
                List<Hotel> res3 = hotelCity.Intersect(hotelSwimPool).ToList();
                hotelCity = res3;
            }

            List<Hotel> hotels = hotelCity;
            int numHotels = hotels.Count;

            if (numHotels > 0)
            {
                for (int i = 0; i < numHotels; i++)
                {
                    Hotel curHotel = hotels[i];
                    TablesGrid.Rows.Add(curHotel.Hotelid, curHotel.City, curHotel.Name, curHotel.Type, curHotel.Class, curHotel.Swimpool, curHotel.Cost);
                }
            }
            else
            {
                MessageBox.Show("Отели не найдены");
            }
        }

        private void HcomboBoxType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Type = HcomboBoxType.SelectedItem.ToString();
        }

        private void FnumericUDStars_ValueChanged(object sender, System.EventArgs e)
        {
            Class = (int)FnumericUDStars.Value;
        }

        private void HcheckSwimPool_CheckedChanged(object sender, EventArgs e)
        {
            IsSwimPool = HcheckSwimPool.Checked;
        }

        private void HbuttonClearParams_Click(object sender, System.EventArgs e)
        {
            HcheckSwimPool.Checked = false;
            FnumericUDStars.Value = 5;
            HcomboBoxType.SelectedItem = "";
            Class = -1; IsSwimPool = false; HotelCity = ""; Type = "";
        }
    }
}

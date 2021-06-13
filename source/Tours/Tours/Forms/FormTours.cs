using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace Tours
{
    public partial class Form1 : Form
    {
        string TourCity = "";
        DateTime DateBegin, DateEnd;
        public void AddColumnsTour()
        {
            TablesGrid.Rows.Clear();
            TablesGrid.Columns.Clear();

            TablesGrid.Columns.Add("TourID", "ИД тура");
            TablesGrid.Columns.Add("Name", "Имя отеля");
            TablesGrid.Columns.Add("Type", "Категория отеля");
            TablesGrid.Columns.Add("Category", "Питание");
            TablesGrid.Columns.Add("Transfer", "ИД трансфера");
            TablesGrid.Columns.Add("Cost", "Стоимость");
            TablesGrid.Columns.Add("DateBegin", "Дата начала");
            TablesGrid.Columns.Add("DateEnd", "Дата конца");
        }

        private void AllTours_Click(object sender, System.EventArgs e)
        {
            AddColumnsTour();

            List<Tour> tours = guest.GetToursByDate(DateBegin, DateEnd);
            int numTours = tours.Count;

            if (numTours > 0)
            {
                for (int i = 0; i < numTours; i++)
                {
                    Tour curTour = tours[i];
                    Food curFood = guest.GetFoodByID(curTour.Food);
                    Hotel curHotel = guest.GetHotelByID(curTour.Hotel);

                    TablesGrid.Rows.Add(curTour.Tourid, curHotel.Name, curHotel.Type, curFood.Category, curTour.Transfer, curTour.Cost,
                        curTour.Datebegin.Date.ToString("d"), curTour.Dateend.Date.ToString("d"));
                }
            }
            else
            {
                MessageBox.Show("Туры не найдены");
            }
        }

        private void TimePickerBegin_ValueChanged(object sender, System.EventArgs e)
        {
            DateBegin = TimePickerBegin.Value;
        }

        private void TimePickerEnd_ValueChanged(object sender, System.EventArgs e)
        {
            DateEnd = TimePickerEnd.Value;
        }

        private void TcomboBoxCity_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TourCity = TcomboBoxCity.SelectedItem.ToString();
        }

        /*--------------------------------------------------------------
         *                          Tourist
         * -----------------------------------------------------------*/

        int BookTourID = 0, DelBookTourID = 0;
        private void TbuttonShowBook_Click(object sender, System.EventArgs e)
        {
            AddColumnsTour(); 
            
            List<Tour> tours = tourist.GetAllBookings(UserID);
            int numTours = tours.Count;

            if (numTours > 0)
            {
                for (int i = 0; i < numTours; i++)
                {
                    Tour curTour = tours[i];
                    Food curFood = tourist.GetFoodByID(curTour.Food);
                    Hotel curHotel = tourist.GetHotelByID(curTour.Hotel);

                    TablesGrid.Rows.Add(curTour.Tourid, curHotel.Name, curHotel.Type, curFood.Category, curTour.Transfer, curTour.Cost,
                        curTour.Datebegin.Date.ToString("d"), curTour.Dateend.Date.ToString("d"));
                }
            }
            else
            {
                MessageBox.Show("Туры не найдены");
            }
        }

        private void TbuttonBook_Click(object sender, System.EventArgs e)
        {
            Tour btour = tourist.GetTourByID(BookTourID);
            if (btour != null)
            {
                List<Tour> atours = tourist.GetAllBookings(UserID);
                if (atours.Contains(btour))
                {
                    MessageBox.Show("Тур " + BookTourID + " уже забронирован");
                }
                else
                {
                    tourist.BookTour(BookTourID, UserID);
                    MessageBox.Show("Тур " + BookTourID + " забронирован");
                }
            }
            else
            {
                MessageBox.Show("Тур для брони не найден");
            }
        }

        private void TtextBoxBookTour_TextChanged(object sender, System.EventArgs e)
        {
            int bID = Convert.ToInt32(TtextBoxBookTour.Text);
            if (bID != 0)
            {
                BookTourID = bID;
            }
        }

        private void TbuttonDelBook_Click(object sender, System.EventArgs e)
        {
            Tour dbtour = tourist.GetTourByID(DelBookTourID);
            if (dbtour != null)
            {
                List<Tour> atours = tourist.GetAllBookings(UserID);
                if (atours.Contains(dbtour))
                {
                    tourist.RemoveTour(DelBookTourID, UserID);
                    MessageBox.Show("Бронирование тура " + DelBookTourID + " отменено");
                }
                else
                {
                    MessageBox.Show("Бронь тура " + DelBookTourID + " отсутсвует");
                }
            }
            else
            {
                MessageBox.Show("Забронированный тур не найден");
            }
        }

        private void TtextBoxDelteBook_TextChanged(object sender, System.EventArgs e)
        {
            int dBID = Convert.ToInt32(TtextBoxDeleteBook.Text);
            if (dBID != 0)
            {
                DelBookTourID = dBID;
            }
        }

        /*--------------------------------------------------------------
         *                          Manager
         * -----------------------------------------------------------*/
        private void TbuttonAdd_Click(object sender, System.EventArgs e)
        {
            DateTime dateB = new DateTime(2022, 03, 10);
            DateTime dateE = new DateTime(2022, 05, 01);
            Tour ntour = new Tour { Tourid = 11, Food = 1, Hotel = 2, Transfer = 3, Cost = 4, Datebegin = dateB, Dateend = dateE };

            FormManageTour formManage = new FormManageTour(ntour);
            formManage.ShowDialog();
            ntour = formManage.ReturnTour();
            
            manager.AddTour(ntour);
            MessageBox.Show("Тур был добавлен");
        }
    }
}

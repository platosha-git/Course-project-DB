using System.Windows.Forms;
using Tours.ComponentsBL;
using Tours.Repositories;
using Tours.ImpRepositories;
using Serilog;
using System.Collections.Generic;
using System;

namespace Tours
{
    public partial class Form1 : Form
    {
        private readonly GuestController guest;
        private readonly TouristController tourist;
        private readonly ManagerController manager;
        private readonly TransferManagerController transferManager;

        private readonly ToursContext db;

        //Параметры поиска
        DateTime DateBegin, DateEnd;


        public Form1()
        {
            var log = new LoggerConfiguration()
                .WriteTo.File(ConfigManager.GetLogFile())
                .CreateLogger();

            db = new ToursContext(ConfigManager.GetConnectionString(2));

            ITourRepository tourRep = new TourRepository(db, log);
            IHotelRepository hotelRep = new HotelRepository(db, log);
            IFoodRepository foodRep = new FoodRepository(db, log);

            ITransferRepository transferRep = new TransferRepository(db, log);
            IBusRepository busRep = new BusRepository(db, log);
            IPlaneRepository planeRep = new PlaneRepository(db, log);
            ITrainRepository trainRep = new TrainRepository(db, log);

            IUsersRepository usersRep = new UsersRepository(db, log);
            IBookingRepository bookingRep = new BookingRepository(db, log);

            guest = new GuestController(tourRep, hotelRep, foodRep, transferRep, busRep, planeRep, trainRep);
            tourist = new TouristController(tourRep, hotelRep, foodRep, transferRep, busRep, planeRep, trainRep, bookingRep, usersRep);
            manager = new ManagerController(tourRep, hotelRep, foodRep, transferRep, busRep, planeRep, trainRep, bookingRep, usersRep);
            transferManager = new TransferManagerController(tourRep, hotelRep, foodRep, transferRep, busRep, planeRep, trainRep);

            InitializeComponent();
        }

        private void AddColumnsTour()
        {
            TablesGrid.Rows.Clear();
            TablesGrid.Columns.Clear();

            TablesGrid.Columns.Add("TourID", "ИД команды");
            TablesGrid.Columns.Add("Food", "ИД питания");
            TablesGrid.Columns.Add("Hotel", "ИД отеля");
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
                    TablesGrid.Rows.Add(curTour.Tourid, curTour.Food, curTour.Hotel, curTour.Transfer, curTour.Cost, 
                        curTour.Datebegin.Date.ToString("d"), curTour.Dateend.Date.ToString("d"));
                }
            }
            else
            {
                MessageBox.Show("Туры не найдены");
            }
        }

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

            List<Food> food = guest.GetAllFood();
            int numFood = food.Count;

            if (numFood > 0)
            {
                for (int i = 0; i < numFood; i++)
                {
                    Food curFood = food[i];
                    TablesGrid.Rows.Add(curFood.Foodid, curFood.Category, curFood.Category,
                        curFood.Vegmenu, curFood.Childrenmenu, curFood.Bar, curFood.Cost);
                }
            }
            else
            {
                MessageBox.Show("Питание не найдено");
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
    }
}

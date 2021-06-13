﻿using System.Windows.Forms;
using Tours.ComponentsBL;
using Tours.Repositories;
using Tours.ImpRepositories;
using Serilog;

namespace Tours
{
    public partial class Form1 : Form
    {
        private readonly GuestController guest;
        private readonly TouristController tourist;
        private readonly ManagerController manager;

        private readonly ToursContext db;
        private readonly int UserID = 0;

        public Form1(AccessLevel lvl, int userID = 0)
        {
            InitializeComponent();
            ControlAccess(lvl);

            UserID = userID;

            var log = new LoggerConfiguration()
                .WriteTo.File(ConfigManager.GetLogFile())
                .CreateLogger();

            db = new ToursContext(ConfigManager.GetConnectionString(lvl));

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
        }

        void ControlAccess(AccessLevel lvl)
        {
            if (lvl == AccessLevel.Guest)
            {
                TgroupBoxBook.Visible = false;
                TgroupBoxAdd.Visible = false;
            }

            if (lvl == AccessLevel.Tourist)
            {
                TgroupBoxAdd.Visible = false;
            }
        }
    }
}

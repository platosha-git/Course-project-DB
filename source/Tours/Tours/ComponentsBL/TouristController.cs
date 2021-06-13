﻿using System.Collections.Generic;
using Tours.Repositories;

namespace Tours.ComponentsBL
{
    public class TouristController : UserController
    {
        protected IBookingRepository bookingRepository;
        protected IUsersRepository usersRepository;

        public TouristController(ITourRepository tourRep, IHotelRepository hotelRep, IFoodRepository foodRep,
                                ITransferRepository transferRep, IBusRepository busRep, IPlaneRepository planeRep, ITrainRepository trainRep,
                                IBookingRepository bookingRep, IUsersRepository usersRep) :
            base(tourRep, hotelRep, foodRep, transferRep, busRep, planeRep, trainRep)
        {
            bookingRepository = bookingRep;
            usersRepository = usersRep;
        }

        public Tour GetTourByID(int tourID)
        {
            return tourRepository.FindByID(tourID);
        }

        public List<Tour> GetAllBookings(int userID)
        {
            int[] ToursID = bookingRepository.GetBookToursByID(userID);
            
            List<Tour> tours = new List<Tour>();
            for (int i = 0; i < ToursID.Length; i++)
            {
                int curTourID = ToursID[i];
                Tour curTour = tourRepository.FindByID(curTourID);
                tours.Add(curTour);
            }

            return tours;
        }

        public void BookTour(int TourID, int userID)
        {
            Booking bk = bookingRepository.FindByID(userID);
            int[] ToursID = bk.Toursid;
            int size = ToursID.Length;

            bool isAlreadyExist = false;
            for (int i = 0; i < size && !isAlreadyExist; i++)
            {
                if (ToursID[i] == TourID)
                {
                    isAlreadyExist = true;
                }
            }

            if (!isAlreadyExist)
            {
                int[] NToursID = new int[size + 1];
                for (int i = 0; i < size; i++)
                {
                    NToursID[i] = ToursID[i];
                }
                NToursID[size] = TourID;

                bk.Toursid = NToursID;
                bookingRepository.Update(bk);
            }
        }

        public void RemoveTour(int TourID, int userID)
        {
            Booking bk = bookingRepository.FindByID(userID);
            int[] ToursID = bk.Toursid;
            int size = ToursID.Length;

            int[] NToursID = new int[size - 1];
            int i = 0, j = 0;
            while (i < size)
            {
                int curTourID = ToursID[i];
                if (curTourID == TourID)
                {
                    i++;
                    continue;
                }
                NToursID[j] = ToursID[i];
                i++; j++;
            }

            bk.Toursid = NToursID;
            bookingRepository.Update(bk);
        }

        public User GetAllUserInfo(int userID)
        {
            return usersRepository.FindByID(userID);
        }

        public void UpdateSurname(string surname, int userID)
        {
            User user = usersRepository.FindByID(userID);
            user.Surname = surname;
            usersRepository.Update(user);
        }

        public void UpdateYear(int year, int userID)
        {
            User user = usersRepository.FindByID(userID);
            user.Year = year;
            usersRepository.Update(user);
        }
    }
}

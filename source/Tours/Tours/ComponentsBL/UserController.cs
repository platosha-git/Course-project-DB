using System;
using System.Collections.Generic;
using Tours.Repositories;


namespace Tours.ComponentsBL
{
    public class UserController
    {
        protected ITourRepository tourRepository;
        protected IHotelRepository hotelRepository;
        protected IFoodRepository foodRepository;
        
        protected ITransferRepository transferRepository;
        protected IBusRepository busRepository;
        protected IPlaneRepository planeRepository;
        protected ITrainRepository trainRepository;
     
        public UserController(ITourRepository tourRep, IHotelRepository hotelRep, IFoodRepository foodRep, 
                                ITransferRepository transferRep, IBusRepository busRep, IPlaneRepository planeRep, ITrainRepository trainRep)
        {
            tourRepository = tourRep;
            hotelRepository = hotelRep;
            foodRepository = foodRep;

            transferRepository = transferRep;
            busRepository = busRep;
            planeRepository = planeRep;
            trainRepository = trainRep;
        }

        /*--------------------------------------------------------------
         *                          Tours
         * -----------------------------------------------------------*/
        public List<Tour> GetAllTours()
        {
            return tourRepository.FindAll();
        }

        public List<Tour> GetToursByDate(DateTime beg, DateTime end)
        {
            return tourRepository.FindTourByDate(beg, end);
        }

        public List<Tour> GetToursByCity(string city)
        {
            List<Hotel> hotels = hotelRepository.FindHotelsByCity(city);
            List<Tour> tours = new List<Tour>();
            for (int i = 0; i < hotels.Count; i++)
            {
                Hotel curHotel = hotels[i];
                List<Tour> curTour = tourRepository.FindToursByHotel(curHotel.Hotelid);
                tours.AddRange(curTour);
            }

            return tours;
        }


        /*--------------------------------------------------------------
         *                          Hotels
         * -----------------------------------------------------------*/
        public List<Hotel> GetAllHotels()
        {
            return hotelRepository.FindAll();
        }

        public Hotel GetHotelByID(int hotelID)
        {
            return hotelRepository.FindByID(hotelID);
        }

        public List<Hotel> GetHotelsByCity(string city)
        {
            return hotelRepository.FindHotelsByCity(city);
        }

        public Hotel GetHotelByName(string name)
        {
            return hotelRepository.FindHotelByName(name);
        }

        public List<Hotel> GetHotelsByType(string type)
        {
            return hotelRepository.FindHotelByType(type);
        }

        public List<Hotel> GetHotelsByClass(int cls)
        {
            return hotelRepository.FindHotelByClass(cls);
        }

        public List<Hotel> GetHotelsBySwimPool(bool sp)
        {
            return hotelRepository.FindHotelBySwimPool(sp);
        }

        public List<Hotel> GetHotelsByLowCost(int cost)
        {
            return hotelRepository.FindHotelByLowCost(cost);
        }


        /*--------------------------------------------------------------
         *                          Food
         * -----------------------------------------------------------*/
        public List<Food> GetAllFood()
        {
            return foodRepository.FindAll();
        }

        public Food GetFoodByID(int foodID)
        {
            return foodRepository.FindByID(foodID);
        }

        public List<Food> GetFoodByCategory(string cat)
        {
            return foodRepository.FindFoodByCategory(cat);
        }

        public List<Food> GetFoodByVegMenu(bool vm)
        {
            return foodRepository.FindFoodByVegMenu(vm);
        }

        public List<Food> GetFoodByChildMenu(bool cm)
        {
            return foodRepository.FindFoodByChildMenu(cm);
        }

        public List<Food> GetFoodByBar(bool bar)
        {
            return foodRepository.FindFoodByBar(bar);
        }

        public List<Food> GetFoodByParams(string cat, bool vm, bool cm, bool bar)
        {
            return foodRepository.FindFoodByParams(cat, vm, cm, bar);
        }

        public List<Food> GetFoodByParams(bool vm, bool cm, bool bar)
        {
            return foodRepository.FindFoodByParams(vm, cm, bar);
        }

        /*--------------------------------------------------------------
         *                          BusTicket
         * -----------------------------------------------------------*/
        public List<Busticket> GetAllBuses()
        {
            return busRepository.FindAll();
        }

        public List<Busticket> GetBusByLowCost(int cost)
        {
            return busRepository.FindBusByLowCost(cost);
        }

        /*--------------------------------------------------------------
         *                          PlaneTicket
         * -----------------------------------------------------------*/
        public List<Planeticket> GetAllPlanes()
        {
            return planeRepository.FindAll();
        }

        public List<Planeticket> GetPlanesByLowCost(int cost)
        {
            return planeRepository.FindPlaneByLowCost(cost);
        }


        /*--------------------------------------------------------------
         *                          TrainTicket
         * -----------------------------------------------------------*/
        public List<Trainticket> GetAllTrains()
        {
            return trainRepository.FindAll();
        }

        public List<Trainticket> GetTrainsByLowCost(int cost)
        {
            return trainRepository.FindTrainByLowCost(cost);
        }
    }
}

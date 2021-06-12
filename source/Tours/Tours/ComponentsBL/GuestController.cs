using Tours.Repositories;

namespace Tours.ComponentsBL
{
    public class GuestController : UserController
    {
        public GuestController(ITourRepository tourRep, IHotelRepository hotelRep, IFoodRepository foodRep,
                                ITransferRepository transferRep, IBusRepository busRep, IPlaneRepository planeRep, ITrainRepository trainRep) :
            base(tourRep, hotelRep, foodRep, transferRep, busRep, planeRep, trainRep)
        {
        }
    }
}

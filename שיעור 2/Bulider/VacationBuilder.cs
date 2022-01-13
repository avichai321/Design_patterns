using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{
    public abstract class VacationBuilder
    {
        protected Vacation vacation;
        public VacationBuilder()
        {
            vacation = new Vacation();
        }

        public abstract void BuyFlightBuilder();
        public abstract void GetRoomHotelBuilder();
        public abstract void GetRideBuilder();

        public void CreateVacation()
        {
            BuyFlightBuilder();
            GetRoomHotelBuilder();
            GetRideBuilder();
        }

        public Vacation GetVacation()
        {
            return vacation;
        }
       
    }
    internal class VacationFluentBuilder
    {
        public VacationFluent vacationFluent = new VacationFluent();
        public VacationFluent Build() => vacationFluent;
        public VacationFluentBuilder GetBusinessFlight()
        {
            if (vacationFluent.OtherFlight)
            {
                vacationFluent.OtherFlight = false;
            }
            vacationFluent.BusinessFlight = true;
            return this;
        }
        public VacationFluentBuilder GetOtherFlight()
        {
            if (vacationFluent.BusinessFlight)
            {
                vacationFluent.BusinessFlight = false;
            }
            vacationFluent.OtherFlight = true;
            return this;
        }

        public VacationFluentBuilder GetRoomInHotel()
        {
            if (vacationFluent.RoomInsweata)
            {
                vacationFluent.RoomInsweata = false;
            }
            vacationFluent.RoomInHotel = true;
            return this;
        }
        public VacationFluentBuilder GetRoomInsweata()
        {
            if (vacationFluent.RoomInHotel)
            {
                vacationFluent.RoomInHotel = false;
            }
            vacationFluent.RoomInsweata = true;
            return this;
        }
        public VacationFluentBuilder GetRideOnBike()
        {
            if (vacationFluent.RideOnlimo)
            {
                vacationFluent.RideOnlimo = false;
            }
            vacationFluent.RideOnBike = true;
            return this;
        }
        public VacationFluentBuilder GetRideOnlimo()
        {
            if (vacationFluent.RideOnlimo)
            {
                vacationFluent.RideOnlimo = false;
            }
            vacationFluent.RideOnBike = true;
            return this;
        }




    }
}

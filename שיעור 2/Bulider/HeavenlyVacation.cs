using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{
    internal class HeavenlyVacation : VacationBuilder
    {
        public override void BuyFlightBuilder()
        {
            vacation.SetFlight("do you want to use the massage couch?");
        }

        public override void GetRideBuilder()
        {
            vacation.SetRide("your limo is wating my friend");
        }

        public override void GetRoomHotelBuilder()
        {
            vacation.SetRoomHotel("you get the best sweet we have");
        }
    }
}

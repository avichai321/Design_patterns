using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{
    internal class LowCostVacation : VacationBuilder
    {
        public override void BuyFlightBuilder()
        {
            vacation.SetFlight("we dont promise nothing");
        }

        public override void GetRideBuilder()
        {
            vacation.SetRide("Go in foot you lazy man");
        }

        public override void GetRoomHotelBuilder()
        {
            vacation.SetRoomHotel("sleep with the cat outside");
        }
    }
}

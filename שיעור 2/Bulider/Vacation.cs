using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{
    public class Vacation
    {
        private string Flight { get; set; }
        private string RoomHotel { get; set; }
        private string Ride { get; set;}
    public void SetFlight(string flight)
    {
        this.Flight=flight;
    }
        public void SetRoomHotel(string roomhotel)
        {
            this.RoomHotel = roomhotel;
        }
        public void SetRide(string ride)
        {
            this.Ride = ride;
        }
        public override string ToString()
        {
            return $"Flight : {Flight}\nRoom Hotel: {RoomHotel}\nRide: {Ride}";
        }
    }
    public class VacationFluent
    {
        public bool BusinessFlight { get; set; }
        public bool OtherFlight { get; set; }
        public bool RoomInHotel { get; set; }
        public bool RoomInsweata { get; set; }
        public bool RideOnBike { get; set; }
        public bool RideOnlimo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_EF.ReservationEntity
{
    partial class Reservation
    {
        public Reservation()
        {
            
        }
        public string DisplayRes
        {
            get
            {
                return Id.ToString() + " | " + FirstName + " " + LastName + " | " + PhoneNumber;
            }
        }
        public string DisplayOccupiedLst
        {
            get
            {
                return RoomNumber + " | " +RoomType+ " | "+Id.ToString()+ " | " + FirstName + " " + LastName + " | " + PhoneNumber;
            }
        }
        public string DisplayReservedLst
        {
            get
            {
                return RoomNumber + " | " + RoomType + " | " + Id.ToString() + " | " + FirstName + " " + LastName + " | " + PhoneNumber + " | " +ArrivalTime.ToString()+" | "+LeavingTime.ToString();
            }
        }
    }
}

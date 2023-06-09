using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWF.Models
{
    internal class BookingDTO
    {
        private int passengerId;
        private int seatNumber;

        public BookingDTO(int passengerId, int seatNumber)
        {
            this.passengerId = passengerId;
            this.seatNumber = seatNumber;
        }

        public int PassengerId { get => passengerId; set => passengerId = value; }
        public int SeatNumber { get => seatNumber; set => seatNumber = value; }
    }
}

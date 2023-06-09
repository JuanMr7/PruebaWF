using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWF.Models
{
    internal class Seat
    {
        private int number;
        private bool isReserved;
        private Passanger? passanger;

        public Seat(int number)
        {
            this.number = number;
            this.isReserved = false;
        }

        public int Number { get => number; set => number = value; }
        public bool IsReserved { get => isReserved; set => isReserved = value; }
        public Passanger? Passanger { get => passanger; set => passanger = value; }
    }
}

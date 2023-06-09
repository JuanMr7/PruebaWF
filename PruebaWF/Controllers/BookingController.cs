using PruebaWF.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWF.Controllers
{
    internal class BookingController
    {
        private static BookingController bookingController;
        private static Mutex mutex = new Mutex();
        
        private static List<Passanger> passangers;
        private static List<Seat> seats;
        private static Queue<int>[] seatQueues;
        private static List<Label> seatPanels;

        private BookingController()
        {
            passangers = new List<Passanger>();
            seats = new List<Seat>();
            seatPanels = new List<Label>();
            seatQueues = new Queue<int>[32];

            createInitialSeats();
            createQueues();
        }

        private void createInitialSeats()
        {
            for (int i = 1; i <= 32; i++ )
            {
                seats.Add(new Seat(i));
            }
        }

        private void createQueues()
        {
            for (int i = 0; i < 32; i++)
            {
                seatQueues[i] = new Queue<int>();
            }
        }

        public static BookingController GetInstance()
        {
            if (bookingController == null)
            {
                bookingController = new BookingController();
            }

            return bookingController;
        }

        public void RegisterPassanger(string name)
        {
            int id = passangers.Count + 1;
            Passanger passanger = new Passanger(id, name);
            passangers.Add(passanger);
        }

        public void RegisterSeat(int number)
        {
            Seat seat = new Seat(number);
            seats.Add(seat);
        }

        public List<Passanger> GetPassangers()
        {
            return passangers;
        }

        public List<Seat> GetSeats()
        {
            return seats;
        }

        public void SetSeatPanels(List<Label> panels)
        {
            seatPanels = panels;
        }

        public List<Label> GetSeatPanels()
        {
            return seatPanels;
        }

        public void assignSeatToPassengerAsync(int passengerId, int seatNumber)
        {
            
            Thread thread = new Thread(new ParameterizedThreadStart(assignSeatToPassenger!));

            
            thread.Start(new BookingDTO(passengerId, seatNumber));
        }

        public static void assignSeatToPassenger(object bookingDTO)
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000); // 1 -10 sec
            Thread.Sleep(randomNumber);

            //mutex.WaitOne();

            int seatNumber = (bookingDTO as BookingDTO)!.SeatNumber;
            int passengerId = (bookingDTO as BookingDTO)!.PassengerId;

            Seat? seat = seats.Find(s => s.Number == seatNumber);
            Passanger? passanger = passangers.Find(p => p.Id == passengerId);
            

            if (seat == null)
            {
                MessageBox.Show("El asiento no existe");
                //mutex.ReleaseMutex();
                return;
            }

            if (passanger == null)
            {
                MessageBox.Show("Pasajero " + passengerId + " no existe");
                //mutex.ReleaseMutex();
                return;
            }

            if (seat.IsReserved)
            {
                MessageBox.Show(passanger.Name + ", el asiento " + seatNumber + " ya está reservado");

                seatQueues[seatNumber - 1].Enqueue(passengerId);
                
                //mutex.ReleaseMutex();
                return;
            }

            Label seatPanel = seatPanels.ToArray()[seatNumber - 1];

            Thread.Sleep(5000); // simulating heavy process

            seat.IsReserved = true;
            seat.Passanger = passanger;
            
            seatPanel.Invoke(new Action(() => seatPanel.Text = passanger.Name));
            seatPanel.Invoke(new Action(() => seatPanel.ForeColor = Color.White));
            seatPanel.Invoke(new Action(() => seatPanel.BackColor = Color.Red));


            //mutex.ReleaseMutex();
        }

        public void removeBooking(int seatNumber)
        {
            Seat? seat = seats.Find(s => s.Number == seatNumber);

            if (seat == null)
            {
                MessageBox.Show("El asiento no existe");
                mutex.ReleaseMutex();
                return;
            }

            seat.IsReserved = false;
            seat.Passanger = null;

            if (seatQueues[seatNumber - 1].Count > 0 )
            {
                int passengerId = seatQueues[seatNumber - 1].Dequeue();
                assignSeatToPassengerAsync(passengerId, seatNumber);
            }
        }

        public void changeBooking(int passengerId, int seatNumber)
        {
            Seat? prevSeat = seats.Find(s => s.Passanger?.Id == passengerId);

            if (prevSeat != null)
            {
                removeBooking(prevSeat.Number);
            }


            assignSeatToPassengerAsync(passengerId, seatNumber);
        }
    }
}
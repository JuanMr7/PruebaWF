using PruebaWF.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWF
{
    public partial class MainView : Form
    {
        BookingController controller = BookingController.GetInstance();
        
        public MainView()
        {
            InitializeComponent();
            registerSeatPanels();
        }

        private void registerPassengerButton_Click(object sender, EventArgs e)
        {
            string name = passangerNameTextBox.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Complete el nombre del pasajero");
                return;
            }

            controller.RegisterPassanger(name);

            passangerListDataGrid.Rows.Add(name, controller.GetPassangers().Count);

            passangerNameTextBox.Clear();
        }

        private void registerSeatPanels()
        {
            List<Label> panels = new List<Label>
            {
                seat1,
                seat2,
                seat3,
                seat4,
                seat5,
                seat6,
                seat7,
                seat8,
                seat9,
                seat10,
                seat11,
                seat12,
                seat13,
                seat14,
                seat15,
                seat16,
                seat17,
                seat18,
                seat19,
                seat20,
                seat21,
                seat22,
                seat23,
                seat24,
                seat25,
                seat26,
                seat27,
                seat28,
                seat29,
                seat30,
                seat31,
                seat32
            };

            controller.SetSeatPanels(panels);
        }

        private void assign1Btn_Click(object sender, EventArgs e)
        {
            int passengerId = int.Parse(client1Txt.Text.Trim());
            int seatNumber = int.Parse(seat1Txt.Text.Trim());

            controller.assignSeatToPassengerAsync(passengerId, seatNumber);

        }

        private void assign2Btn_Click(object sender, EventArgs e)
        {
            int passengerId = int.Parse(client2Txt.Text.Trim());
            int seatNumber = int.Parse(seat2Txt.Text.Trim());

            controller.assignSeatToPassengerAsync(passengerId, seatNumber);
        }

        private void assign3Btn_Click(object sender, EventArgs e)
        {
            int passengerId = int.Parse(client3Txt.Text.Trim());
            int seatNumber = int.Parse(seat3Txt.Text.Trim());

            controller.assignSeatToPassengerAsync(passengerId, seatNumber);

        }

        private void remove1Btn_Click(object sender, EventArgs e)
        {
            int seatNumber = int.Parse(seat1Txt.Text.Trim());
            controller.removeBooking(seatNumber);
        }

        private void remove2Btn_Click(object sender, EventArgs e)
        {
            int seatNumber = int.Parse(seat2Txt.Text.Trim());
            controller.removeBooking(seatNumber);
        }

        private void remove3Btn_Click(object sender, EventArgs e)
        {
            int seatNumber = int.Parse(seat3Txt.Text.Trim());
            controller.removeBooking(seatNumber);
        }

        private void change1Btn_Click(object sender, EventArgs e)
        {
            int passengerId = int.Parse(client1Txt.Text.Trim());
            int seatNumber = int.Parse(seat1Txt.Text.Trim());

            controller.changeBooking(passengerId, seatNumber);
        }

        private void change2Btn_Click(object sender, EventArgs e)
        {
            int passengerId = int.Parse(client2Txt.Text.Trim());
            int seatNumber = int.Parse(seat2Txt.Text.Trim());

            controller.changeBooking(passengerId, seatNumber);
        }

        private void change3Btn_Click(object sender, EventArgs e)
        {
            int passengerId = int.Parse(client3Txt.Text.Trim());
            int seatNumber = int.Parse(seat3Txt.Text.Trim());

            controller.changeBooking(passengerId, seatNumber);
        }
    }
}

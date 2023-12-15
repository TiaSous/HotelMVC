using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMVC
{
    public partial class BookARoom : Form
    {
        private Controller _controller;
        public BookARoom()
        {
            InitializeComponent();
        }

        public Controller Controller { get => _controller; set => _controller = value; }

        private void EnregistrerValue_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();

            booking.Remarque = RemarqueValue.Text;
            booking.NuitHotel = NombreDeNuitValue.Text;
            booking.Chambre = ChambreValue.Text;
            booking.DateArivee = DateTimeValue.Text;


    
        }

    }
}

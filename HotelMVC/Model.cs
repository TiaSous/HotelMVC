using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Model
    {
        private Controller _controller;
        public Controller Controller { get => _controller; set => _controller = value; }

        public void SaveBooking(Booking booking)
        {
            string remaque = booking.Remarque;
            string chambre = booking.Chambre;
            DateTime date = booking.DateArivee;
            int nuit = booking.NuitHotel;

            File.WriteAllText("Booking.txt", "Chambre: " + chambre + " Date d'arrivé: " + date + " Nombre de nuit: " + nuit + " Remarque: " + remaque);
            
        }
    }
}

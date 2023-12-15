using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Booking
    {
        private string _remarque;
        private string _chambre;
        private int _nuitHotel;
        private DateTime _dateArivee;

        public string Remarque { get => _remarque; set => _remarque = value; }
        public string Chambre { get => _chambre; set => _chambre = value; }
        public int NuitHotel { get => _nuitHotel; set => _nuitHotel = value; }
        public DateTime DateArivee { get => _dateArivee; set => _dateArivee = value; }
    }
}

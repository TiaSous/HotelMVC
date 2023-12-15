using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Controller
    {
        private Model _model;
        private BookARoom _view;

        public BookARoom View { get => _view; set => _view = value; }
        public Model Model { get => _model; set => _model = value; }

        public void newBooking(Booking booking)
        {
            Console.WriteLine("a");
            Model.SaveBooking(booking);
        }
    }
}

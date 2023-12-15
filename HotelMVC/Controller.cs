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
        private View _view;

        public View View { get => _view; set => _view = value; }
        public Model Model { get => _model; set => _model = value; }
    }
}

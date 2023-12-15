using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMVC
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookARoom());

            Model model = new Model();
            BookARoom view = new BookARoom();
            Controller controller = new Controller();

            controller.Model = model;
            controller.View = view;

            model.Controller = controller;
            view.Controller = controller;
        }
    }
}

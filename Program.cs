using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using task;

namespace Field_Renting_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Dashboard("q"));
              Application.Run(new LoginUser());
            // Application.Run(new Booking("mahin"));
            //Application.Run(new bookingreq());
            //  Application.Run(new SellerReg());
            //Application.Run(new rentrecord("q"));
           //  Application.Run(new AdminDash());
            //Application.Run(new Userbookingreq("q"));
             // Application.Run(new SellerReg());


        }
    }
}

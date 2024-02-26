using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TournamentDashboardForm;
using CreatePrizeForm;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            LibraryTracker.GlobalConfig.InitializeConnections(true, true);

            Application.Run(new createPrizeForm());

           //  Application.Run(new tournamentDashboardForm());
        }
    }
}
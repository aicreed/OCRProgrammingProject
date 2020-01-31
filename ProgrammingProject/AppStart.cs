using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProject
{
    public class AppStart
    {
        public static void SelectionScreen()
        {
            Console.WriteLine("Welcome " + AuthenticationService.CurrentUser.FirstName + " " + AuthenticationService.CurrentUser.LastName + "!");
            Console.WriteLine("");
            SongGuess.Start();
        }
    }
}

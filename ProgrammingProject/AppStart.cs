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
            Console.WriteLine("Please select an option");
            Console.WriteLine("");
            Console.WriteLine("1: Start Song Guessing Game");
            Console.WriteLine("2: View Leaderboards");
            Console.WriteLine("3: View User's Score");
            Console.WriteLine("");
            Console.Write("Input: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                SongGuess.Start();
            }
            else if (input == "2")
            {
                //ToDo: Leaderboards.
                Console.Clear();
                SelectionScreen();
            }
            else if (input == "3")
            {
                Console.Clear();
                Console.WriteLine("Current Score: " + AuthenticationService.GetScore(AuthenticationService.CurrentUser));
                Console.WriteLine("");
                Console.WriteLine("Pess ENTER or RETURN to continue. ");
                var enter = Console.ReadLine();
                if (enter == "")
                {
                    Console.Clear();
                    SelectionScreen();
                }
            }
            else
            {
                Console.Clear();
                SelectionScreen();
            }
        }
    }
}

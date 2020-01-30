using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingProject.Model;

namespace ProgrammingProject
{
    public class SongGuess
    {
        public static void Start()
        {
            Console.WriteLine("");
            var context = new AppDBContext();
            var currentScore = AuthenticationService.GetScore(AuthenticationService.CurrentUser);
            

            //Get Random Song
            var song = context.Songs
                .OrderBy(r => Guid.NewGuid()).Take(5)
                .FirstOrDefault();
            Console.WriteLine("Artist: " + song.Artist);
            Console.WriteLine("Title: " + song.Name.ToCharArray()[0]);
            Console.WriteLine("What is the song's name?");
            Console.WriteLine("");
            Console.Write("Guess: ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == song.Name)
            {
                Console.WriteLine("Correct! Press ENTER or RETURN to try another. ");
                AuthenticationService.AddScore(AuthenticationService.CurrentUser, currentScore);
                var enter = Console.ReadLine();
                if (enter == "")
                {
                    Console.Clear();
                    Start();
                }

            }
            else
            {
                Console.WriteLine("Incorrect. Press ENTER or RETURN to try again. ");
                var enter = Console.ReadLine();
                if (enter == "")
                {
                    Console.Clear();
                    Start();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingProject.Model;

namespace ProgrammingProject.Model
{
    public class AuthenticationService
    {
        public static User CurrentUser { get; set; }
        public static int GetScore(User currentUser)
        {
            var context = new AppDBContext();
            var user = context.Users
              .Where(u => u.Username == currentUser.Username)
              .FirstOrDefault();
            return user.Score;
        }
        public static void AddScore(User currentUser, int currentScore)
        {
            var context = new AppDBContext();
            var user = context.Users
               .Where(u => u.Username == currentUser.Username)
               .FirstOrDefault();
            user.Score = currentScore + 1;
            context.SaveChanges();
        }
        public static void Authenticate(string Username, string Password)
        {
            var context = new AppDBContext();
            var user = context.Users
                .Where(u => u.Username == Username)
                .FirstOrDefault();

            if (user == null)
            {
                Console.WriteLine("User not found");
            }
            if (user.Password == Password)
            {
                SongGuess.Start();
                CurrentUser = user;
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                Console.Read();
            }

        }
    }
}

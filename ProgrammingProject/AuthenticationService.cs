using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingProject.Model;

namespace ProgrammingProject
{
    public class AuthenticationService
    {
        public static User CurrentUser { get; set; }
        public static bool IsUserAuthenticated { get; set; }
        public static int GetScore(User currentUser) //This method gets the current score from the database for the user.
        {
            var context = new AppDBContext();
            var user = context.Users
              .Where(u => u.Username == currentUser.Username)
              .FirstOrDefault();
            return user.Score;
        }
        public static void AddScore(User currentUser, int currentScore) //This method adds the score and saves to database.
        {
            var context = new AppDBContext();
            var user = context.Users
               .Where(u => u.Username == currentUser.Username)
               .FirstOrDefault();
            user.Score = currentScore + 1;
            context.SaveChanges();
        }
        //Login / Authentication System
        public static void Authenticate(string Username, string Password)
        {
            var context = new AppDBContext(); // Creates a new instance of the database context.
            var user = context.Users
                .Where(u => u.Username == Username)
                .FirstOrDefault(); //Queries the database for user matching inputted username.

            if (user == null) //If the query returns null the user does not exist in the database.
            {
                Console.WriteLine("User not found");
            }
            if (user.Password == Password) //If both username and password match, user is logged in.
            {
                CurrentUser = user; //Sets the current user for the app.
                AppStart.SelectionScreen();  //Starts the selection screen.
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                Console.Read();
            }

        }
    }
}

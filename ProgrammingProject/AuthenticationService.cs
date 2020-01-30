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
        public static string CurrentUser { get; set; }
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
                //App Opens Here.
                CurrentUser = user.FirstName + " " + user.LastName;
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                Console.Read();
            }

        }
    }
}

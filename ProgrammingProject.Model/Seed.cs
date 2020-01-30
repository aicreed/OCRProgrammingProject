using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProject.Model
{
    public class Seed
    {
        public static void SampleData()
        {
            var context = new AppDBContext();
            var user = new User { Username = "Admin", Password = "test123", FirstName = "Admin", LastName = "User" }; //Add Users
            var adam = new User { Username = "acreed", FirstName = "Adam", LastName = "Creed", Password = "password" };
            var song1 = new Song { Name = "Test" };
            context.Users.Add(adam);
            context.Users.Add(user);
            context.Songs.Add(song1);
            context.SaveChanges();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProject.Model
{
    public class Seed
    {
        // Sample Data used to seed database
        public static void SampleData()
        {
            var context = new AppDBContext();
            //User Accounts
            var admin = new User { Username = "Admin", Password = "test123", FirstName = "Admin", LastName = "User" };
            var adam = new User { Username = "acreed", FirstName = "Adam", LastName = "Creed", Password = "password" };
            //Songs
            var song1 = new Song { Name = "Money", Artist = "Pink Floyd" };
            var song2 = new Song { Name = "Time", Artist = "Pink Floyd" };
            var song3 = new Song { Name = "Wish You Were Here", Artist = "Pink Floyd" };
            var song4 = new Song { Name = "Nothing Else Matters", Artist = "Metallica" };
            var song5 = new Song { Name = "Enter Sandman", Artist = "Metallica" };
            var song6 = new Song { Name = "Master of Puppets", Artist = "Metallica" };
            var song7 = new Song { Name = "Fade to Black", Artist = "Metallica" };
            var song8 = new Song { Name = "Waterfall", Artist = "The Stone Roses" };
            var song9 = new Song { Name = "Don't Stop", Artist = "The Stone Roses" };
            var song10 = new Song { Name = "No Suprises", Artist = "Radiohead" };
            var song11 = new Song { Name = "Lucky", Artist = "Radiohead" };
            var song12 = new Song { Name = "Fade Out", Artist = "Radiohead" };
            var song13 = new Song { Name = "The Gambler", Artist = "Kenny Rogers" };
            var song14 = new Song { Name = "Coward of the County", Artist = "Kenny Rogers" };
            var song15 = new Song { Name = "Stairway to Heaven", Artist = "Led Zeppelin" };
            var song16 = new Song { Name = "Kashmir", Artist = "Led Zeppelin" };
            //Add entities to database
            context.Users.Add(adam);
            context.Users.Add(admin);
            context.Songs.Add(song1);
            context.Songs.Add(song2);
            context.Songs.Add(song3);
            context.Songs.Add(song4);
            context.Songs.Add(song5);
            context.Songs.Add(song6);
            context.Songs.Add(song7);
            context.Songs.Add(song8);
            context.Songs.Add(song9);
            context.Songs.Add(song10);
            context.Songs.Add(song11);
            context.Songs.Add(song12);
            context.Songs.Add(song13);
            context.Songs.Add(song14);
            context.Songs.Add(song15);
            context.Songs.Add(song16);
            context.SaveChanges();

        }
    }
}

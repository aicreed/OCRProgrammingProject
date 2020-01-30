using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProgrammingProject.Model;

namespace ProgrammingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp();
        }
        public static void StartUp()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            if (!File.Exists("ProgrammingProject.Model.AppDBContext.sdf"))
            {
                Console.WriteLine("Application database not found. Generating....");
                Seed.SampleData();

            }
            Console.Clear();
            Console.WriteLine("OCR Programming Project 2020");
            Console.WriteLine("Created By: Adam Creed");
            Console.WriteLine("Version: 0.10");
            Console.WriteLine("Date: January 2020");
            Console.WriteLine("");
            Console.WriteLine("Please Authenticate");
            Console.WriteLine("");
#if DEBUG
            Console.Clear();
            AuthenticationService.Authenticate("Admin", "test123");
#else
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();
            Console.Clear();
            AuthenticationService.Authenticate(username, password);
#endif






        }
    }
}

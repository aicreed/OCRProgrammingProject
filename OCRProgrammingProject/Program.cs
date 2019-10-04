using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRProgrammingProject
{
    class Program
    {
        //Main startup method of the console app.
        static void Main(string[] args)
        {
            CreateXML().Wait(); //This calls the CreateXML Method. .Wait tells C# to wait for the method to complete before continuing.
        }
        //This is a private async method meaning it is only accessible from within this class. Async methods are awaited which means C# waits for completion before continuing with code execution.
        private static async Task CreateXML()
        {
            //Checks to see if file does not already exist in root app directory and creates it if it does not
            if (!File.Exists("UserList.xml"))
            {
                XMLHelper.GenerateAuthorisedUsers(); //Generates the UserList XML from the XMLHelper Class.
            }
        }
    }
}

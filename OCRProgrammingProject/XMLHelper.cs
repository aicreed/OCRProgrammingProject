using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OCRProgrammingProject
{
    //This file is used to create and read XML files within the app
    public class XMLHelper
    {
        //This method generates the Users for the app
        public static void GenerateAuthorisedUsers()
        {
            var _userList = new List<User>(); // Creates a new list for users.
            _userList.Add(new User { Username = "adam", Password = "test" }); //Adds a new user to the list.

            XmlSerializer serializer = new XmlSerializer(typeof(List<User>)); //Creates a new instance of the XML serializer with the type of List<User>
            using (TextWriter writer = new StreamWriter(@"UserList.xml"))
            {
                serializer.Serialize(writer, _userList);
            }
        }
    }
}

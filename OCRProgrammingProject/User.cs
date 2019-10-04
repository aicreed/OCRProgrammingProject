using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OCRProgrammingProject
{
    //User Class
    [Serializable] //This attribute allows the class to be serialized as an XML file.
    public class User
    {
        //User attributes
        public string Username { get; set; }
        public string Password { get; set; }
       
    }
    public class Users //This class is used for XML Deserialisation.
    {
        [XmlElement("User")]
        public List<User> userList = new List<User>();
    }
}

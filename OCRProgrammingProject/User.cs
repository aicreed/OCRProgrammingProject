using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}

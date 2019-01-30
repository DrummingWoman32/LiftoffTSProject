using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldLiftoff.Models
{
    public class User
    {
        public string username { get; set; }  //protected
        public string password { get; set; }  //private
        public int UserID { get; set; }
        public int areaCode { get; set; }

        

        /*public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int AreaCode
        {
            get { return areaCode; }
            set { areaCode = value; }
        }*/

        //constructor (needed for when user registers)
        /*public User(string username, string password, int areaCode)
        {
            username = username;
            password = password;
            areaCode = areaCode;
            
        }*/
    }
}

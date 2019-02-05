using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace HelloWorldLiftoff.Models
{
    public class Account
    {
        public string username { get; set; }  //protected
        public string password { get; set; }  //private
        public int UserID { get; set; }
        public int areaCode { get; set; }
        public int accountID { get; set; }
        public int sourceCode { get; set; }
        //public List<TrackingSheet> trackingSheets {get; set;}
        public IEnumerable<TrackingSheet> trackingSheets { get; set; }

    }
}

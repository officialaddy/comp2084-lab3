using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneName = "";
            Manufacturer = "";
            DateReleased = new DateTime();
        }

        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public string MSRP { get; set; }
        public int ScreenSize{ get; set; }
        public DateTime DateReleased { get; set; }

    }
}

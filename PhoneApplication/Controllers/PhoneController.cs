using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        public IActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone {PhoneName = "iPHone 11", Manufacturer="Apple",MSRP="abc",ScreenSize=16, DateReleased= new DateTime(20,02,06)},
                new Phone {PhoneName = "Samsung S11", Manufacturer="Samsung",MSRP="abc",ScreenSize=14, DateReleased= new DateTime(20,02,06)},
                new Phone {PhoneName = "Razor", Manufacturer="Razor inc.",MSRP="abc",ScreenSize=17, DateReleased= new DateTime(20,02,05)},
                new Phone {PhoneName = "Google Phone", Manufacturer="Google",MSRP="abc",ScreenSize=16, DateReleased= new DateTime(20,02,06)},
            };
            return View(phoneList);
        }


        }
}
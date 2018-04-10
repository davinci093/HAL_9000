using HAL_9000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HAL_9000.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Its running!";
            //return string.Format(Settings.Url, Settings.Path);
        }
    }
}
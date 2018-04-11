using HAL_9000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Telegram.Bot.Types;

namespace HAL_9000.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Its running!";
            //return string.Format(Settings.Url, Settings.Path);
            //Console await Bot.Get().GetWebhookInfoAsync();

            //string Result;
            //if (info != null)
            //    Result =
            //        $"WebHook: {info.ToString()}\n" +
            //        //$"AllowedUpdates: {info.AllowedUpdates.ToString()}\n" +
            //        //$"Last error date: {info.LastErrorDate.ToString()}\n" +
            //        //$"Last error message: {info.LastErrorMessage.ToString()}\n" +
            //        $"Url: {info.Url.ToString()}";
            //else Result = "info is null";
            //return Result;
        }
    }
}
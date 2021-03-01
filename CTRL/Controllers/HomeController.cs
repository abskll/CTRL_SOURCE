using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTRL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //OEM_CLEAR
            //nkeyb.Send(Keyboard.KEYBDINPUT);
            //nkeyb.VirtualKeyShort
            //nkeyb = null;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void PushButton(string btn)
        {
            //keyw is company
            //shift + 1 is default
            int i = 0;
            Keyboard nkeyb = new Keyboard();
            //while (i < 10)
            //{



            //    //.Send(Keyboard.VirtualKeyShort.DOWN);

            //    i++;
            //}

            

        }

    }
}
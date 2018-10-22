using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
   public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
           ViewBag.SeriesTitle = "The Man of Steel";
           ViewBag.IssueNumber = 700;
           ViewBag.Description = "<p>Final issue! Witness the final hours of Lex Luthors' life and his one, last, great act of revenge! Even if Superman survives... <strong>will Clark Kent?</strong></p>";
           ViewBag.Artists = new string[]
            {
                "Script: Jushun Blackmon",
                "Pencils: Ceaser Drawer",
                "Inks: Manny Ink",
                "Colors: Johnny Rambo",
                "Letters: Lucy Letter"
            };

            return View();
        }
    }
}
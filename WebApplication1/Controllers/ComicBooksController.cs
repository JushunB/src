using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
   public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Man of Steel",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Lex Luthors' life and his one, last, great act of revenge! Even if Superman survives... <strong>will Clark Kent?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Jushun Blackmon", Role = "Script"},
                    new Artist() {Name = "Ceaser Drawer", Role = "Pencils"},
                    new Artist() {Name = "Manny Ink", Role = "Inks"},
                    new Artist() {Name = "Johnny Rambo", Role = "Colors"},
                    new Artist() {Name = "Lucy Letter", Role = "Letters"},
                }
            };

            return View(comicBook);
        }
    }
}
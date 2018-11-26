using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
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
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Man of Steel",
                IssueNumber = 750,
                DescriptionHtml = "<p>Celebrating 80 years of the<strong>Man of Steel</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Jushun Blackmon", Role = "Script"},
                    new Artist() {Name = "Ceaser Drawer", Role = "Pencils"},
                    new Artist() {Name = "Manny Ink", Role = "Inks"},
                    new Artist() {Name = "Johnny Rambo", Role = "Colors"},
                    new Artist() {Name = "Lucy Letter", Role = "Letters"},
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "The Man of Steel",
                IssueNumber = 800,
                DescriptionHtml = "<p><strong>BATTLE OF THE BRATS.</strong> Superman and Superboy vs Batman and Robin, who will win in this battle of duos....</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Jushun Blackmon", Role = "Script"},
                    new Artist() {Name = "Ceaser Drawer", Role = "Pencils"},
                    new Artist() {Name = "Manny Ink", Role = "Inks"},
                    new Artist() {Name = "Johnny Rambo", Role = "Colors"},
                    new Artist() {Name = "Lucy Letter", Role = "Letters"},
                },
                Favorite = false
            }
    };

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }

            return comicBookToReturn;
        }
    }
}
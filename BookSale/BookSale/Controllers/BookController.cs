using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookSale.Models;

namespace BookSale.Controllers
{
    public class BookController : Controller
    {
        public string Index(string s)
        {
            return "Khoa Công nghệ Thông tin, " + s;
        }

        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("Cấu trúc dữ liệu & Giải thuật");
            books.Add("Lập trình Web căn bản HTML5-CSS3");
            books.Add("Lập trình Web Nâng cao - MVC 5");
            books.Add("Nhập môn lập trình");
            books.Add("Tin học đại cương");
            ViewBag.Books = books;
            return View();
        }

        static List<Book> books = new List<Book>();

        public ActionResult GetListBook()
        {
            if (books.Count() == 0)
            {
                books.Add(new Book(1, "Cấu trúc dữ liệu & Giải thuật", "Phạm Minh Dũng", 130, 2021, "/Content/images/CTDL.jpg"));
                books.Add(new Book(2, "Lập trình Web căn bản HTML5-CSS3", "Trần Minh Thái", 140, 2021, "/Content/images/HTML5-CSS3.jpg"));
                books.Add(new Book(3, "Lập trình Web Nâng cao - MVC 5", "Nguyễn Thanh Vũ", 150, 2021, "/Content/images/ASPnetMVC5.jpg"));
                books.Add(new Book(4, "Nhập môn lập trình", "Tôn Quang Toại", 120, 2021, "/Content/images/Laptrinh.png"));
                books.Add(new Book(5, "Tin học đại cương", "Đỗ Đình Thanh", 135, 2021, "/Content/images/Laptrinh.png"));
            }
            return View(books); 
        }

        public ActionResult EditBook(int id)
        {
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int? id, string title, string author, float price, int year, string imgcover)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (id == b.Id)
                {
                    b.Title = title;
                    b.Author = author;
                    b.Price = price;
                    b.Year = year;
                    b.Imgcover = imgcover;
                    break;
                }
            }
            ViewBag.Books = books;
            return View("GetListBook", books);
        }

        public ActionResult DeleteBook(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = new Book();
            foreach (var b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("DeleteBook")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBookId(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            books.Remove(book);
            return View("getListBook", books);
        }

        public ActionResult CreateBook()
        {
            return View();
        }

        [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBook([Bind(Include = "id, Title, Author, Price, Year, ImgCover")] Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Thêm sách mới
                    books.Add(book);
                }
            }
            catch
            {
                ModelState.AddModelError("", "Lỗi ghi dữ liệu");
            }
            return View("getListBook", books);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookSale.Models
{
    public class Book
    {
        int id;             
        string title;       
        string author;      
        float price;        
        int year;           
        string imgcover;

        public Book(int id, string title, string author, float price, int year, string imgcover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
            this.year = year;
            this.imgcover = imgcover;
        }

        public Book()
        {

        }

        [Required(ErrorMessage = "ID không được trống")]
        [Display(Name = "ID")]
        public int Id { get => id; set => id = value; }
 
        [Required(ErrorMessage = "Tiêu đề không được trống")]
        [StringLength(250, ErrorMessage = "Tiêu đề không quá 250 ký tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get => title; set => title = value; }

        [Required(ErrorMessage = "Tên tác giả không được trống")]
        [Display(Name = "Tác giả")]
        public string Author { get => author; set => author = value; }

        [Required(ErrorMessage = "Giá bán phải lớn hơn 0")]
        [Display(Name = "Giá bán")]
        public float Price { get => price; set => price = value; }

        [Required(ErrorMessage = "Năm xuất bản > 0")]
        [Display(Name = "Năm XB")]
        public int Year { get => year; set => year = value; }

        [Display(Name = "Đường dẫn Hình bìa")]
        public string Imgcover { get => imgcover; set => imgcover = value; }


    }
}
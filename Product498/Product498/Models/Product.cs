using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product498.Models
{
    public class Product
    {

        int id;
        String pName;
        String pType;
        double pPrice;
        int categoryID;
        String imgcover;

        public Product(int id, string pName, string pType, double pPrice, int categoryID, String imgcover)
        {
            this.id = id;
            this.pName = pName;
            this.pType = pType;
            this.pPrice = pPrice;
            this.categoryID = categoryID;
            this.imgcover = imgcover;
        }

        public int Id { get => id; set => id = value; }
        public string PName { get => pName; set => pName = value; }
        public string PType { get => pType; set => pType = value; }
        public double PPrice { get => pPrice; set => pPrice = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Imgcover { get => imgcover; set => imgcover = value; }
    }
}
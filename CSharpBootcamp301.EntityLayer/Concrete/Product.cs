using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }


        // Product - Category ilişkisi
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


        // Order - Product ilişkisinde Product tablosunu da haberdar etmemiz gerekir.
        public List<Order> Orders { get; set; }


        //[NotMapped]
        //public string CategoryName { get; set; }
    }
}

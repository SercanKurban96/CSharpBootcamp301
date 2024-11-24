using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }


        // Order - Customer ilişkisinde Customer tablosunu da haberdar etmemiz gerekir.
        public List<Order> Orders { get; set; }


        // Sonradan eklenen bir property
        public bool CustomerStatus { get; set; }
    }
}

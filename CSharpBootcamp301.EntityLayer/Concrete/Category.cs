using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        // Product - Category ilişkisinde Category tablosunu da haberdar etmemiz gerekir.
        public List<Product> Products { get; set; }
        // Burada Products ile çoğul eki olarak ekledik. Her bir ürünün sadece bir tane kategorisi olacak.
    }
}
/*
 Field-Variable-Property
 */

/*
 int x; --> Field
 */

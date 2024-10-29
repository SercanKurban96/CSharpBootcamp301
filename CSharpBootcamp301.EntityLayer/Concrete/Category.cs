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
    }
}
/*
 Field-Variable-Property
 */

//int x; direkt sınıfın içinde tanımlanırsa //Field

//public int y { get; set; } get ve set metotları varsa //Property

//void test()
//{
//    int z; bir metotun içine yazılıyorsa //Variable
//}
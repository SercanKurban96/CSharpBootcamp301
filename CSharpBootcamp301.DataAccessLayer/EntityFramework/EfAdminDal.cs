using CSharpBootcamp301.DataAccessLayer.Abstract;
using CSharpBootcamp301.DataAccessLayer.Repositories;
using CSharpBootcamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
/*
 * Ekle, Sil, Güncelle, Listele ve ID'ye Göre Getir (Entity'e özgü olmayan metot)
 * İçinde a harfi geçmeyen kullanıcıları listele (Entity'e özgü olan metot)
 */

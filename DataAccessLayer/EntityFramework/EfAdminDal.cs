using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    /**
     *GenericRepository’den miras alarak Admin’in CRUD’unu bedavaya getiriyor (kod tekrarını bitiriyor),
     *IAdminDal’ı implement ederek Business katmanını soyuta bağlıyor + Admin’e özel metotlar için alan açıyor
    (mimariyi sağlamlaştırıyor).**/
    public class EfAdminDal:GenericRepository<Admin>, IAdminDal
    {

    }
}

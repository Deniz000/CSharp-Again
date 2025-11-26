using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.DtoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    // Product ile ilgili veritabanı işlemlerini EF kullanarak yapan DAL sınıfı 
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        //Veritabanındaki Product kayıtlarını alıyor, her birini ilgili
        //Category’si ile birlikte projeksiyon yapıyor (yeni bir anonim tip oluşturuyor)
        //ve bunları liste olarak geri döndürüyor.
        //    public List<Object> GetProductsWithCategory()
        //    {
        //        var context = new CampContext(); //Bu satırla yeni bir context oluşturuyorsun ve EF ile veritabanına bağlanmaya hazırsın.
        //        var values = context.Products //SELECT * FROM Products’ın temeli gibi düşünebilirsin, ama daha sorgu yazılmadı.
        //            .Select(x=> new  //x → Her bir Product kaydı.
        //            {                // new { ... } → Anonim bir tip oluşturuyorsun. Yani herhangi bir sınıf tanımlamadan, “bana içinde şu property’ler olan bir yapı ver” diyorsun.
        //                ProductId = x.ProductId,
        //                ProductName = x.ProductName,
        //                ProductDescription = x.ProductDescription,
        //                ProductPrice = x.ProductPrice,
        //                ProductStock = x.ProductStock,
        //                CategoryName = x.Category.CategoryName
        //            }).ToList(); // ToList() dediğin anda sorgu çalışıyor ve sonuçlar belleğe çekiliyor.
        //        return values.Cast<object>().ToList();
        //BUNA DAHA İYİ YAKLAŞIM OLARAK

        public List<ProductWithCategoryDto> GetProductsWithCategory()
        {
            var context = new CampContext();
            return context.Products
                .Select(x => new ProductWithCategoryDto
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductDescription = x.ProductDescription,
                    ProductPrice = x.ProductPrice,
                    ProductStock = x.ProductStock,
                    CategoryId = x.Category.CategoryId,
                    CategoryName = x.Category.CategoryName
                }).ToList();
        }
    }
}

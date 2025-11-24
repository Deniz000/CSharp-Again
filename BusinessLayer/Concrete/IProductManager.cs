using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TInsert(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Varsayım: ProductName, Price, Stock, CategoryId alanların var
            if (string.IsNullOrWhiteSpace(entity.ProductName))
                throw new Exception("Ürün adı boş geçilemez.");

            if (entity.ProductName.Length < 2 || entity.ProductName.Length > 100)
                throw new Exception("Ürün adı 2-100 karakter arasında olmalıdır.");

            if (entity.ProductPrice < 0)
                throw new Exception("Ürün fiyatı negatif olamaz.");

            if (entity.ProductStock < 0)
                throw new Exception("Stok negatif olamaz.");

            if (entity.CategoryId <= 0)
                throw new Exception("Ürün bir kategoriye bağlı olmalıdır.");

            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (string.IsNullOrWhiteSpace(entity.ProductName))
                throw new Exception("Ürün adı boş geçilemez.");

            if (entity.ProductPrice < 0)
                throw new Exception("Ürün fiyatı negatif olamaz.");

            if (entity.ProductStock < 0)
                throw new Exception("Stok negatif olamaz.");

            _productDal.Update(entity);
        }

        public void TDelete(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            if (id <= 0)
                throw new Exception("Id değeri 0'dan büyük olmalıdır.");

            return _productDal.GetById(id);
        }

        public List<Object> GetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }
    }
}

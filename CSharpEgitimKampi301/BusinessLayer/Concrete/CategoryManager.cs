using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TInsert(Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Varsayım: CategoryName alanın var
            if (string.IsNullOrWhiteSpace(entity.CategoryName))
                throw new Exception("Kategori adı boş geçilemez.");

            if (entity.CategoryName.Length < 2 || entity.CategoryName.Length > 50)
                throw new Exception("Kategori adı 2-50 karakter arasında olmalıdır.");

            // (Opsiyonel) Aynı isimde kategori olmasın
            var exists = _categoryDal.GetAll()
                        .Any(x => x.CategoryName.ToLower() == entity.CategoryName.ToLower());
            if (exists)
                throw new Exception("Bu isimde bir kategori zaten var.");

            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (string.IsNullOrWhiteSpace(entity.CategoryName))
                throw new Exception("Kategori adı boş geçilemez.");

            if (entity.CategoryName.Length < 2 || entity.CategoryName.Length > 50)
                throw new Exception("Kategori adı 2-50 karakter arasında olmalıdır.");

            _categoryDal.Update(entity);
        }

        public void TDelete(Category entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            if (id <= 0)
                throw new Exception("Id değeri 0'dan büyük olmalıdır.");

            return _categoryDal.GetById(id);
        }
    }
}

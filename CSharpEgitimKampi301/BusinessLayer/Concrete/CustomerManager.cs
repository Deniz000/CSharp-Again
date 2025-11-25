using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Varsayım: Name/Surname alanların var
            if (string.IsNullOrWhiteSpace(entity.CustomerName))
                throw new Exception("Müşteri adı boş geçilemez.");

            if (string.IsNullOrWhiteSpace(entity.CustomerSurname))
                throw new Exception("Müşteri soyadı boş geçilemez.");

            if (entity.CustomerName.Length < 2 || entity.CustomerName.Length > 50)
                throw new Exception("Müşteri adı 2-50 karakter arasında olmalıdır.");

            if (entity.CustomerSurname.Length < 2 || entity.CustomerSurname.Length > 50)
                throw new Exception("Müşteri soyadı 2-50 karakter arasında olmalıdır.");

            // (Opsiyonel) Email alanın varsa basit kontrol
            // if (string.IsNullOrWhiteSpace(entity.Email) || !entity.Email.Contains("@"))
            //     throw new Exception("Geçerli bir email giriniz.");

            _customerDal.Insert(entity);
        }

        public void TUpdate(Customer entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (string.IsNullOrWhiteSpace(entity.CustomerName))
                throw new Exception("Müşteri adı boş geçilemez.");

            if (string.IsNullOrWhiteSpace(entity.CustomerSurname))
                throw new Exception("Müşteri soyadı boş geçilemez.");

            _customerDal.Update(entity);
        }

        public void TDelete(Customer entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            if (id <= 0)
                throw new Exception("Id değeri 0'dan büyük olmalıdır.");

            return _customerDal.GetById(id);
        }
    }
}

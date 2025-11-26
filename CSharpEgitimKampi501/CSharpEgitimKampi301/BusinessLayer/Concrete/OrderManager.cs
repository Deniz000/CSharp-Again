using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TInsert(Order entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Varsayım: CustomerId, TotalPrice, OrderDate alanların var
            if (entity.CustomerId <= 0)
                throw new Exception("Sipariş bir müşteriye ait olmalıdır.");

            if (entity.TotalPrice < 0)
                throw new Exception("Toplam tutar negatif olamaz.");

            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (entity.TotalPrice < 0)
                throw new Exception("Toplam tutar negatif olamaz.");

            _orderDal.Update(entity);
        }

        public void TDelete(Order entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order TGetById(int id)
        {
            if (id <= 0)
                throw new Exception("Id değeri 0'dan büyük olmalıdır.");

            return _orderDal.GetById(id);
        }
    }
}

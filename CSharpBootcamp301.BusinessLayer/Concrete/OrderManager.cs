using CSharpBootcamp301.BusinessLayer.Abstract;
using CSharpBootcamp301.DataAccessLayer.Abstract;
using CSharpBootcamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order TGetByID(int id)
        {
            return _orderDal.GetByID(id);
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}

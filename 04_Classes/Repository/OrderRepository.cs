using Model;
using Repository.VirtualDataBase;

namespace Repository
{
    public class OrderRepository
    {

        public void Create(Order order)
        {
            MyData.Orders.Add(order);
        }

        public void Delete(Order order)
        {
            MyData.Orders.Remove(order);
        }

        public void Update(Order order)
        {
            var _order = GetById(order.Id);

            _order.OrderDate = order.OrderDate;
            _order.OrderItems = order.OrderItems;
            _order.OrderStatus = order.OrderStatus;
            _order.Customer = order.Customer;
        }
        public Order GetById(int id)
        {
            var order =
                MyData.Orders.
                    FirstOrDefault(x => x.Id == id);

            if (order is null) return null;

            return order;
        }
    }
}
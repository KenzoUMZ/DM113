using DM_113_SOAP_Producer.Models;

namespace DM_113_SOAP_Producer.Services
{
    public class OrderService : IOrderService
    {
        private static List<Order> orders = new List<Order>();
        private static int counter = 1;

        // Construtor estático para popular dados mockados
        static OrderService()
        {
            orders.Add(new Order
            {
                Id = counter++,
                CustomerName = "Alice",
                CreatedAt = DateTime.Now.AddDays(-3),
                Status = "Pendente"
            });

            orders.Add(new Order
            {
                Id = counter++,
                CustomerName = "Bob",
                CreatedAt = DateTime.Now.AddDays(-1),
                Status = "Enviado"
            });

            orders.Add(new Order
            {
                Id = counter++,
                CustomerName = "Carol",
                CreatedAt = DateTime.Now,
                Status = "Entregue"
            });
        }

        public void CreateOrder(Order order)
        {
            order.Id = counter++;
            order.CreatedAt = DateTime.Now;
            orders.Add(order);
        }

        public Order GetOrder(int id)
        {
            return orders.Find(o => o.Id == id);
        }

        public OrderList GetAllOrders()
        {
            return new OrderList(orders);
        }

        public void UpdateOrderStatus(int id, string newStatus)
        {
            var order = orders.Find(o => o.Id == id);
            if (order != null)
            {
                order.Status = newStatus;
            }
        }
    }
}


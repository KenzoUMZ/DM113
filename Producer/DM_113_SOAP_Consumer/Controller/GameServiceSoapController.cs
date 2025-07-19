using GameServiceSoap;

namespace DM_113_SOAP_Consumer.Controller
{
    public class GameServiceSoapController
    {
        GameServiceSoap.OrderServiceClient soapClient;

        public GameServiceSoapController()
        {
            soapClient = new GameServiceSoap.OrderServiceClient(
                GameServiceSoap.OrderServiceClient.EndpointConfiguration.BasicHttpBinding_IOrderService);
        }

        public async Task<string> CreateOrderAsync(Order order)
        {
            var client = new OrderServiceClient(OrderServiceClient.EndpointConfiguration.BasicHttpBinding_IOrderService);

            await client.OpenAsync();
            await client.CreateOrderAsync(order);
            await client.CloseAsync();

            return $"Pedido criado com sucesso para {order.CustomerName}!";
        }

        public async Task<Order?> GetOrderAsync(int id)
        {
            var client = new OrderServiceClient(OrderServiceClient.EndpointConfiguration.BasicHttpBinding_IOrderService);

            await client.OpenAsync();
            var order = await client.GetOrderAsync(id);
            await client.CloseAsync();

            return order;
        }

        public async Task<OrderList> GetAllOrdersAsync()
        {
            var client = new OrderServiceClient(OrderServiceClient.EndpointConfiguration.BasicHttpBinding_IOrderService);

            await client.OpenAsync();
            var orders = await client.GetAllOrdersAsync();
            await client.CloseAsync();

            return orders;
        }

        public async Task<string> UpdateOrderStatusAsync(int id, string newStatus)
        {
            var client = new OrderServiceClient(OrderServiceClient.EndpointConfiguration.BasicHttpBinding_IOrderService);

            await client.OpenAsync();
            await client.UpdateOrderStatusAsync(id, newStatus);
            await client.CloseAsync();

            return $"Status do pedido {id} atualizado para '{newStatus}'";
        }

        public async Task<string> DeleteOrderAsync(int id)
        {
            var client = new OrderServiceClient(OrderServiceClient.EndpointConfiguration.BasicHttpBinding_IOrderService);

            await client.OpenAsync();
            await client.DeleteOrderAsync(id);
            await client.CloseAsync();

            return $"Pedido {id} deletado com sucesso!";
        }

    }
}

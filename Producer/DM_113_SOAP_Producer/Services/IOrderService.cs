using System.ServiceModel;
using DM_113_SOAP_Producer.Models;

namespace DM_113_SOAP_Producer.Services
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void CreateOrder(Order order);

        [OperationContract]
        Order GetOrder(int id);

        [OperationContract]
        OrderList GetAllOrders();

        [OperationContract]
        void UpdateOrderStatus(int id, string newStatus);
    }
}

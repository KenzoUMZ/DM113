using System.Runtime.Serialization;

namespace DM_113_SOAP_Producer.Models
{
    [CollectionDataContract]
    public class OrderList : List<Order>
    {
        public OrderList(IEnumerable<Order> collection) : base(collection)
        {
        }

        public OrderList() : base()
        {
        }
    }
}

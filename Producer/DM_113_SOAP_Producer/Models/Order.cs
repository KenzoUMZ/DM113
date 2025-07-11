using System.Runtime.Serialization;

namespace DM_113_SOAP_Producer.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public string Status { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;

namespace Assigment.Models
{
    [BsonIgnoreExtraElements]
    public class Customer
    {
        [BsonElement("CustomerID")]
        public int customerId { get; set; }

        [BsonElement("CustomerName")]
        public string customerName { get; set; } = string.Empty;

        [BsonElement("email")]
        public string email { get; set; } = string.Empty;

        [BsonElement("company")]
        public string company { get; set; } = string.Empty;

        public Customer()
        {
        }
        public Customer(int customerId, string customerName, string email, string company)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.email = email;
            this.company = company;
        }
    }
}

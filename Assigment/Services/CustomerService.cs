using Assigment.Models;
using MongoDB.Driver;

namespace Assigment.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMongoCollection<Customer> _customers;

        public CustomerService(ISureMDMDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);

            _customers = database.GetCollection<Customer>(settings.CollectionName[0]);
        }

        public List<Customer> Get()
        {
            return _customers.Find(customer => true).ToList();
        }

        public Customer Get(int id)
        {
            //throw new NotImplementedException();
            return _customers.Find(cus => cus.customerId == id).FirstOrDefault();
        }

        public Customer Create(Customer customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        public void Update(int id, Customer cus)
        {
            //throw new NotImplementedException();
            _customers.ReplaceOne(cust
                => cust.customerId == id, cus);
        }

        public void Remove(int id)
        {
            //throw new NotImplementedException();
            _customers.DeleteOne(cus => cus.customerId == id);

            //return _customers.Find(cus => cus.customerId == id).FirstOrDefault();
        }

        public List<int> GetAllCustomerID()
        {
            throw new NotImplementedException();
            //return _customers.Find(customer => true).Project(cus => cus.customerId).ToList();

        }
    }
}

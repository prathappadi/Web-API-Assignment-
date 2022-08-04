using Assigment.Models;

namespace Assigment.Services
{
    public interface ICustomerService
    {


        List<Customer> Get();
        Customer Get(int id);
        Customer Create(Customer student);
        void Update(int id, Customer student);
        void Remove(int id);

        //List<int> GetAllCustomerID();

    }
}

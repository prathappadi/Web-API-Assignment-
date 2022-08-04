using Assigment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assigment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {


        public static List<Customer> CusData = new List<Customer>
        {
            new Customer(1, "abcd", "prathap@gmail.com", "42Gears"),
            new Customer(2,"Shubham","Shubham@gmail.com","42Gears")

        };



        //show all The Customer
        [HttpGet(Name = "GETALLCUSTOMERS")]
        public ActionResult GetAllCustomer()
        {
            return Ok(CusData);
            //return 
        }

        //get all the Customer with Id
        [HttpGet("{id}")]
        public ActionResult GetCustomerById(int id)
        {
            var customerdata = CusData.Find(h => h.customerId == id);
            if (customerdata == null)
            {
                return BadRequest("Customer not found or doesnot Exists");
            }
            else
            {
                return Ok(customerdata);
            }
        }

        //get all customer IDs
        //[HttpGet]
        //public async Task<ActionResult<List<int>>> getAllCustomerId()
        //{
        //    //int[] customerIdAll = new int[cusData.Count];

        //    return cusData.Select(t => t.customerId).ToList();
        //}

        //add Customer
        [HttpPost]
        public ActionResult AddCustomer(Customer cusObj)
        {
            CusData.Add(cusObj);
            return Ok("Added Succefully");
        }

        //Delete Customer
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)

        {
            var deleteUser = CusData.Find(h => h.customerId == id);

            if (deleteUser == null)
            {
                return BadRequest("Customer DoesNot Exist");
            }
            return Ok("Deleted Customer");
        }

    }
}

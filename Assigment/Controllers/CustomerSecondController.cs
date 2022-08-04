using Assigment.Models;
using Assigment.Services;
using Microsoft.AspNetCore.Mvc;


namespace Assigment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSecondController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerSecondController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        //[BasicAuthentication]
        //[HttpGet]
        //public ActionResult<List<Customer>> Get()
        //{
        //    return _customerService.Get();
        //}

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerService.Get(id);
        }
        //[HttpGet]
        //public ActionResult<List<int>> GetAllId()
        //{
        //    return _customerService.GetAllCustomerID();
        //}

        //// POST api/<CustomerSecondController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CustomerSecondController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<CustomerSecondController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _customerService.Remove(id);
            return $"Deleted Customer with {id}";
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer cusObj)
        {
            _customerService.Create(cusObj);
            return Ok("Added Successfully");
        }
    }
}

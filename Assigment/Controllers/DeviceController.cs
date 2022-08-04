using Assigment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assigment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        public static List<Device> DeviceDetails = new List<Device>
        {
            new Device(1,100,"Lenovo",97,"JIO",64,68),
            new Device(1,102,"Redmi",98,"Airtel",128,132),
            new Device(2,1001,"Samsung",100,"Aircel",64,256)
        };

        [HttpGet]
        public ActionResult AllDeviceDetails()
        {
            return Ok(DeviceDetails);
        }

        [HttpGet("{customerID}")]
        public ActionResult GetDevicebyCustomerId(int customerId)

        {
            var deviceData = DeviceDetails.FindAll(h => h.customerId == customerId);
            return deviceData == null ? NotFound() : Ok(deviceData);

            // Ok(deviceData);
        }

        [HttpPost]
        public ActionResult AddCustomer(Device dev)
        {
            DeviceDetails.Add(dev);
            return Ok(" Device Added Succefully");
        }





    }
}

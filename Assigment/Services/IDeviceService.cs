using Assigment.Models;

namespace Assigment.Services
{
    public interface IDeviceService
    {

        List<Device> Get();
        Device Get(int id);
        Device Create(Device device);
        void Update(int id, Device device);
        void Remove(int id);
    }
}

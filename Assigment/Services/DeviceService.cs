using Assigment.Models;
using MongoDB.Driver;

namespace Assigment.Services
{
    public class DeviceService

    {
        private readonly IMongoCollection<Device> _devices; 

        public DeviceService(ISureMDMDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);

            _devices = database.GetCollection<Device>(settings.CollectionName[1]);
        }

        public List<Device> Get()
        {
            return _devices.Find(device => true).ToList();
        }

        public Device Get(int id)
        {
            //throw new NotImplementedException();
            return _devices.Find(cus => cus.deviceId == id).FirstOrDefault();
        }

        public Device Create(Device device)
        {
            _devices.InsertOne(device);
            return device;
        }

        public void Update(int id, Device dev)
        {
            throw new NotImplementedException();
            _devices.ReplaceOne(cust
                => cust.deviceId == id, dev);
        }

        public void Remove(int id)
        {
            //throw new NotImplementedException();
            _devices.DeleteOne(dev => dev.deviceId == id);

            //return _devices.Find(cus => cus.deviceId == id).FirstOrDefault();
        }
    }
}


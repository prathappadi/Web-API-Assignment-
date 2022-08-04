using MongoDB.Bson.Serialization.Attributes;

namespace Assigment.Models
{
    [BsonIgnoreExtraElements]
    public class Device
    {
        [BsonElement("CustomerID")]
        public int customerId { get; set; }
        
        [BsonElement("deviceid")]
        public int deviceId { get; set; }
        [BsonElement("deviceName")]
        public string deviceName { get; set; }

        [BsonElement("deviceBatteryPercentage")]
        public int deviceBatteryPercentage { get; set; }

        [BsonElement("deviceNetwork")]
        public String deviceNetwork { get; set; }

        [BsonElement("devicePhysicalStorage")]
        public int devicePhysicalStorage { get; set; }

        [BsonElement("deviceTotalStorage")]
        public int totalStorage { get; set; }

        //public DateTime deviceLastUpdated { get; set; }

        public Device()
        {

        }

        public Device(int customerId, int deviceId, string deviceName, int deviceBatteryPercentage, String deviceNetwork, int devicePhysicalStorage, int totalStorage)
        {
            this.customerId = customerId;
            this.deviceId = deviceId;
            this.deviceName = deviceName;
            this.deviceBatteryPercentage = deviceBatteryPercentage;
            this.deviceNetwork = deviceNetwork;
            this.devicePhysicalStorage = devicePhysicalStorage;
            this.totalStorage = totalStorage;
        }


    }
}

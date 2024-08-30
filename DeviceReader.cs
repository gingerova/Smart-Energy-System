using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AESProject.Classes.DummyData;

namespace AESProject.Classes
{
    public class DeviceReader
    {
        private DummyData.DummyData data = new DummyData.DummyData();
        public void DeviceReadData()
        {
            foreach (var region in data.regions)
            {
                foreach (var connectionPoint in data.connectionPoints.Where(cp => cp.RegionID == region.ID))
                {
                    foreach (var device in data.devices.Where(d => d.ConnectionPointID == connectionPoint.ID))
                    {
                        var deviceModel = data.deviceModels.First(dm => dm.ID == device.DeviceModelID);
                        Console.WriteLine($"{region.Name} bölgesi, {connectionPoint.Name} bağlantı noktasında, {device.Name} cihazı ({deviceModel.Name} modeli) cihaz anlık verileri:");
                        foreach (var parameter in data.parameters)
                        {

                            var randomDeger = new Random().Next(1, 1000);
                            Console.WriteLine($"{parameter.Name} parametresi okunan değer {randomDeger} {parameter.Unit}");
                        }
                    }
                }
            }
        }
    }
}

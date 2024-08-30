using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESProject.Classes.DummyData
{
    public class DummyData
    {
        public List<Region> regions = new List<Region>
    {
        new Region() {ID=1,Name="R1" },
        new Region() {ID=2,Name="R2" },
        new Region() {ID=3,Name="R3" }
    };
        public List<ConnectionPoint> connectionPoints = new List<ConnectionPoint>
    {
        new ConnectionPoint() {ID=1,IPAddress="1.1.1.1",Name="CP1",RegionID=1},
        new ConnectionPoint() {ID=2,IPAddress="1.1.1.2",Name="CP2",RegionID=2},
        new ConnectionPoint() {ID=3,IPAddress="1.1.1.3",Name="CP3",RegionID=3}
    };
        public List<Device> devices = new List<Device>
    {
        new Device() {ID=1,Name="C1",ConnectionPointID=1,NAD="NAD1",DeviceModelID=1},
        new Device() {ID=2,Name="C2",ConnectionPointID=2,NAD="NAD2",DeviceModelID=2},
        new Device() {ID=3,Name="C3",ConnectionPointID=3,NAD="NAD3",DeviceModelID=3}
    };
        public List<DeviceModel> deviceModels = new List<DeviceModel>
    {
        new DeviceModel() {ID=1,Name="M1" },
        new DeviceModel() {ID=2,Name="M2" },
        new DeviceModel() {ID=3,Name="M3" }
    };
        public List<Parameter> parameters = new List<Parameter>
    {
        new Parameter() {Address=1,Name="P1",Unit=Unit.A},
        new Parameter() {Address=2,Name="P2",Unit=Unit.V},
        new Parameter() {Address=3,Name="P3",Unit=Unit.Wh}

    };
    }
}

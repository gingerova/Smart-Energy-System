using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESProject.Classes
{
    public class Device
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ConnectionPointID { get; set; }
        public string NAD { get; set; }
        public int DeviceModelID { get; set; }
    }
}

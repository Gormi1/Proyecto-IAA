using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Collections.Generic;

namespace Domain_
{

    public class ModelUsbAuth
    {
        public List<UsbInfo> GetUsbDevices()
        {
            List<UsbInfo> l = new List<UsbInfo>();

            ManagementObjectCollection collection;

            using (var searcher = new ManagementObjectSearcher(@"select * from Win32_USBHub"))
            {
                collection = searcher.Get();
            }

            foreach (var device in collection)
            {
                UsbInfo OUsbInfo = new UsbInfo((string) device.GetPropertyValue("DeviceID"),
                                               (String) device.GetPropertyValue("PNPDeviceID"),
                                               (String) device.GetPropertyValue("Description"));

                l.Add(OUsbInfo);
            }
            collection.Dispose();

            return l;
        }
    }

    public class UsbInfo
    {
        public string DeviceId { get; set; }
        public string PnpDeviceId { get; set; }
        public string Description { get; set; }
        public UsbInfo(string DeviceId, string PnpDeviceId, string Descritpion)
        {
            this.DeviceId = DeviceId;
            this.PnpDeviceId = PnpDeviceId;
            this.Description = Description;
        }
    }
}

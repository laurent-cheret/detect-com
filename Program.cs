using System;
using System.Management;

namespace WMISample
{
    public class MyWMIQuery
    {
        public static void Main()
        {
            try
            {
                
                    ManagementObjectSearcher searcher =
                        new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("PROJETO MICROPROCESSADORES LAURENT LUAN KAIQUE THIAGO PIRES");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                    Console.WriteLine("Description: {0}", queryObj["Description"]);
                    Console.WriteLine("DeviceID: {0}", queryObj["DeviceID"]);
                    Console.WriteLine("PNPDeviceID: {0}", queryObj["PNPDeviceID"]);
                    Console.WriteLine("Name: {0}", queryObj["Name"]);

                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
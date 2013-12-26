using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace NetWorkSwitch
{
    class IPInfo
    {

        /// <summary>
        /// Returns the network card configuration of the specified NIC
        /// </summary>
        /// <PARAM name="nicName">Name of the NIC</PARAM>
        /// <PARAM name="ipAdresses">Array of IP</PARAM>
        /// <PARAM name="subnets">Array of subnet masks</PARAM>
        /// <PARAM name="gateways">Array of gateways</PARAM>
        /// <PARAM name="dnses">Array of DNS IP</PARAM>
        public static IPConfiguration GetIP(string nicName)
        {
            IPConfiguration unConfigIP = new IPConfiguration();

         

            ManagementClass mc = new ManagementClass(
              "Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                // Make sure this is a IP enabled device. 
                // Not something like memory card or VM Ware
                if ((bool)mo["ipEnabled"])
                {
                    if (mo["Caption"].Equals(nicName))
                    {
                        unConfigIP.ipAdresses = (string[])mo["IPAddress"];
                        unConfigIP.subnets = (string[])mo["IPSubnet"];
                        unConfigIP.gateways = (string[])mo["DefaultIPGateway"];
                        unConfigIP.dnses = (string[])mo["DNSServerSearchOrder"];

                        break;
                    }
                }
            }

            return unConfigIP;
        }


        public static List<string> GetListCarteReseau()
        {
            List<string> listeRetour = new List<string>();

             ManagementClass mc = new ManagementClass(
              "Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                // Make sure this is a IP enabled device. 
                // Not something like memory card or VM Ware
                if ((bool)mo["IPEnabled"])
                {
                    listeRetour.Add((string)mo["Caption"]);
                }
            }

            return listeRetour;
        }



        /// <summary>
        /// Set IP for the specified network card name
        /// </summary>
        /// <PARAM name="nicName">Caption of the network card</PARAM>
        /// <PARAM name="IpAddresses">Comma delimited string 
        ///           containing one or more IP</PARAM>
        /// <PARAM name="SubnetMask">Subnet mask</PARAM>
        /// <PARAM name="Gateway">Gateway IP</PARAM>
        /// <PARAM name="DnsSearchOrder">Comma delimited DNS IP</PARAM>
        public static void SetIP(string nicName, IPConfiguration unConfigIP)
        {
            ManagementClass mc = new ManagementClass(
              "Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                // Make sure this is a IP enabled device. 
                // Not something like memory card or VM Ware
                if ((bool)mo["IPEnabled"])
                {
                    if (mo["Caption"].Equals(nicName))
                    {

                        ManagementBaseObject newIP =
                          mo.GetMethodParameters("EnableStatic");
                        ManagementBaseObject newGate =
                          mo.GetMethodParameters("SetGateways");
                        ManagementBaseObject newDNS =
                          mo.GetMethodParameters("SetDNSServerSearchOrder");

                        newGate["DefaultIPGateway"] = new string[] { unConfigIP.GateWay };
                        newGate["GatewayCostMetric"] = new int[] { 1 };

                        newIP["IPAddress"] = unConfigIP.ipAdresses;
                        newIP["SubnetMask"] = unConfigIP.subnets;

                        newDNS["DNSServerSearchOrder"] = unConfigIP.dnses;

                        ManagementBaseObject setIP = mo.InvokeMethod(
                          "EnableStatic", newIP, null);
                        ManagementBaseObject setGateways = mo.InvokeMethod(
                          "SetGateways", newGate, null);
                        ManagementBaseObject setDNS = mo.InvokeMethod(
                          "SetDNSServerSearchOrder", newDNS, null);

                        break;
                    }
                }
            }
        }


    }
}

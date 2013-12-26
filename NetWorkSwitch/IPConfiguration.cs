using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWorkSwitch
{
    public class IPConfiguration
    {
        public IPConfiguration()
        {

        }

        public string[] ipAdresses;
        public string[] subnets;
        public string[] gateways;
        public string[] dnses;


        public IPConfiguration(string adresseIP,string netMask,string laGateway,string dns1,string dns2)
        {
            ipAdresses = new string[1];
            ipAdresses[0] = adresseIP;

            subnets = new string[1];
            subnets[0] = netMask;

            gateways = new string[1];
            gateways[0] = laGateway;

            dnses = new string[2];
            dnses[0] = dns1;
            dnses[1] = dns2;
        }

        public string GateWay
        {
            get
            {
                if (gateways != null && gateways.Length > 0) return gateways[0];
                else return String.Empty;
            }
        }
        public string IpAdresse
        {
            get
            {
                if (ipAdresses != null && ipAdresses.Length > 0) return ipAdresses[0];
                else return String.Empty; 
             
            }
        }
        public string Subnet
        {
            get
            {
                if (subnets != null && subnets.Length > 0) return subnets[0];
                else return String.Empty; 
                
            }
        }

        public string DNS1
        {
            get
            {
                if (dnses != null && dnses.Length > 0) return dnses[0];
                else return String.Empty;
            }
        }

        public string DNS2
        {
            get
            {
                if (dnses != null && dnses.Length > 1) return dnses[1];
                else return String.Empty;
            }
        }

    }
}

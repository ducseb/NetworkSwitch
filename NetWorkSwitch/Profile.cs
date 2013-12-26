using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWorkSwitch
{
    public class Profile
    {
        public string nomProfile;
        public IPConfiguration laConfig;


        public override string ToString()
        {
            return nomProfile;
        }
    }

}

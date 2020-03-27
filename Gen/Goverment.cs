using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    public class Goverment : IAgent
    {
        public string CountryName { get; set; }
        public string MinistryName { get; set; }
        public string AccountNumber { get; set; }


        public string GetAgentInfo()
        {
            return CountryName + " " + MinistryName;
        }

        public string GetPaymentInfo()
        {
            return MinistryName + " " + AccountNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    public class Company : IAgent
    {
        public string CompanyName { get; set; }
        public string Account { get; set; }

        public string GetAgentInfo()
        {
            return CompanyName;
        }

        public string GetPaymentInfo()
        {
            return Account;
        }
    }
}

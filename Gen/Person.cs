using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    public class Person : IAgent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Account { get; set; }


        public string GetAgentInfo()
        {
            return FirstName + " " + LastName;
        }

        public string GetPaymentInfo()
        {
            return string.IsNullOrEmpty(Account) ? "Cash" : Account;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    /*
     * Типы ограничений:
     * - class 
     * - struct
     * - concrete class 
     * - new()
     * - Interface
     */

    public class Order<TIncome, TOutcome, TAgent> : BaseOrder<TAgent>
        where TIncome : IOrderObject
        where TOutcome : IOrderObject
        where TAgent : IAgent
    {     
        public TIncome Income { get; set; }
        public TOutcome Outcome { get; set; }

        public Order(TAgent agent) : base(agent)
        {
        }

        public Order(TAgent agent, TIncome income, TOutcome outcome) : base(agent)
        {            
            Income = income;
            Outcome = outcome;
        }

        public TIncome GetIncome()
        {
            return Income;
        }

        public string GetAgentInfo()
        {
            return Agent.GetAgentInfo();
        }
    }
}

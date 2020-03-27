using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    public class BaseOrder<TAgent>
    {
        private static int currentId = 1;

        public int Id { get; private set; }
        public TAgent Agent { get; set; }

        public BaseOrder(TAgent a)
        {
            Id = currentId++;
            Agent = a;
        }
    }
}

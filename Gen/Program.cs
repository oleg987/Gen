using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order<Product, Money, Person>();

            var order2 = new Order<Product, Product>();

            var order3 = new Order<Money, Product>();

            var order4 = new Order<Money, Money>();

            //order.Income = new Product();
            //order.Outcome = new Money();

            //var order2 = new Order<Product, Product>();

            //var order3 = new Order<Company, int>();

            //string type1 = Console.ReadLine();
            //string type2 = Console.ReadLine();

            //if (type1.Equals("p") && type2.Equals("p"))
            //{
            //    var o = new Order<Product, Product>();
            //    Console.WriteLine(o);
            //}
            //else
            //{
            //    var o = new Order<Money, Money>();
            //    Console.WriteLine(o);
            //}


        }
    }
}

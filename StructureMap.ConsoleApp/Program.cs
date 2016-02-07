using Credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new Container();
            var container = new Container(MasterCardAction());
            //container.Configure(MasterCardAction());
            //container.Configure(x => x.For<ICreditCard>().Use<Visa>().Named("visa"));

            var shopper = container.GetInstance<Shopper>();

            Console.WriteLine(shopper.Charge());

            Console.Read();
        }

        private static Action<ConfigurationExpression> MasterCardAction()
        {
            return x => x.For<ICreditCard>().Use<MasterCard>();
        }
    }
}

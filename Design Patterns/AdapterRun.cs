using Design_Patterns.Structurals.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class AdapterRun
    {
        public AdapterRun()
        {
            Console.WriteLine("Start Client...\n");
            IncompatibleService incompatibleService = new IncompatibleService();
            Adapter adaptee = new Adapter(incompatibleService);

            Console.WriteLine(adaptee.GetRequest());
        }
    }
}

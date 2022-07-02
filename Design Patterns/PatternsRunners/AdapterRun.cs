using System;
using Design_Patterns.Structurals.Adapter;

namespace Design_Patterns.PatternsRunners
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

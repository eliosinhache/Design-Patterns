using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structurals.Adapter
{
    // The IServiceTarget defines the domain-specific interface used by the client code.
    class Adapter : IServiceTarget
    {
        private readonly IncompatibleService _adaptee;

        public Adapter(IncompatibleService adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            string operations = "Convert client data to incompatibleService data...\n";
            operations += "Send Request To Service\n";
            operations += "Result from service: " + _adaptee.SpecificRequestWithSpecificData();
            return operations;
        }
    }

    public interface IServiceTarget
    {
        string GetRequest();
    }

    class IncompatibleService
    {
        public string SpecificRequestWithSpecificData()
        {
            return "The specific Result";
        }
    }
}

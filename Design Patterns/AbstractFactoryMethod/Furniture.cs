using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactoryMethod
{
    class ClassicTable : IAbstractTable
    {
        public string PutTheTable()
        {
            return "Silverware puts on a Classic Table";
        }
    }
    class ModernTable : IAbstractTable
    {
        public string PutTheTable()
        {
            return "Silverware puts on a Modern Table";
        }
    }

    class ClassicChair : IAbstractChair
    {
        public string GetCloser(IAbstractTable table)
        {
            return $"Getting the Classic Chair closer after: {table.PutTheTable()}";
        }

        public string SitDown()
        {
            return "Sit on a Classic Chair";
        }
    }

    class ModernChair : IAbstractChair
    {
        public string GetCloser(IAbstractTable table)
        {
            return $"Getting the Moder Chair closer after: {table.PutTheTable()}";
        }

        public string SitDown()
        {
            return "Sit on a Modern Chair";
        }
    }
}

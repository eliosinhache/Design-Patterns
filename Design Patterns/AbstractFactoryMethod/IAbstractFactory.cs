using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactoryMethod
{
    interface IAbstractFactory
    {
        IAbstractTable CreateTable();
        IAbstractChair CreateChair();
    }

    interface IAbstractChair
    {
        string SitDown();
        string GetCloser(IAbstractTable table);
    }
    interface IAbstractTable
    {
        string PutTheTable();
    }
}

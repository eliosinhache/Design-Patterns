using Design_Patterns.Creationals.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class SingletonRun
    {
        public SingletonRun()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2) 
            {
                Console.WriteLine("Singleton works fine! Both instance are equals");
            } else
            {
                Console.WriteLine("The are a problem with the singleton. The instance are not equals");
            }

        }
    }
}

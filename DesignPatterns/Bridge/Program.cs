using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ExtendedAbstraction extendedAbstraction = new ExtendedAbstraction(new ConcreteImplementationDefault());
                extendedAbstraction.G().A().G();
                Console.WriteLine();
            }

            {
                ExtendedAbstraction extendedAbstraction = new ExtendedAbstraction(new ConcreteImplementationSound());
                extendedAbstraction.G().A().G();
                Console.WriteLine();
            }
        }
    }
}

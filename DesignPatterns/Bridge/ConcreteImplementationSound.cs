using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DesignPatterns.Bridge
{
    class ConcreteImplementationSound : IImplementation
    {
        public void Dash()
        {
            Console.Write("Bbi~");
        }

        public void Dot()
        {
            Console.Write("Bip");
        }

        public void Space()
        {
            Console.Write(" ");
        }
    }
}

using System;

namespace LearningCSharp.DesignPatterns.Bridge
{
    class ConcreteImplementationDefault : IImplementation
    {
        public void Dash()
        {
            Console.Write("-");
        }

        public void Dot()
        {
            Console.Write(".");
        }

        public void Space()
        {
            Console.Write(" ");
        }
    }
}
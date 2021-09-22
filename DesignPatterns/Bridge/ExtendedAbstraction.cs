using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DesignPatterns.Bridge
{
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {

        }

        public ExtendedAbstraction G()
        {
            Dash(); Dash(); Dot(); Space();
            return this;
        }
        public ExtendedAbstraction A()
        {
            Dot(); Dash(); Space();
            return this;
        }
        public ExtendedAbstraction R()
        {
            Dot(); Dash(); Dot(); Space();
            return this;
        }
        public ExtendedAbstraction M()
        {
            Dash(); Dash(); Space();
            return this;
        }
    }
}
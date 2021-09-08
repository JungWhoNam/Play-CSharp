using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.AdvTopic
{
    public class MathService
    {
        public delegate double ResultHandler(double value0, double value1);
        public delegate void OutboundHandler(double result);

        public ResultHandler MathDelegate;
        public OutboundHandler OutboundDelegate;

        public MathService()
        {
            MathDelegate = AddNumbers;
            MathDelegate += MultiplyNumbers;
        }

        private double AddNumbers(double value0, double value1)
        {
            var result = value0 + value1;
            OutboundDelegate(result);
            return result;
        }

        private double MultiplyNumbers(double value0, double value1)
        {
            var result = value0 * value1;
            OutboundDelegate(result);
            return result;
        }
    }
}

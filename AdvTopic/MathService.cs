using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.AdvTopic
{
    public class MathService
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public double AddNumbers(double value0, double value1)
        {
            var result = value0 + value1;
            MathPerformed(this, new MathPerformedEventArgs(result));
            return result;
        }

        public double MultiplyNumbers(double value0, double value1)
        {
            var result = value0 * value1;
            MathPerformed(this, new MathPerformedEventArgs(result));
            return result;
        }
    }
}

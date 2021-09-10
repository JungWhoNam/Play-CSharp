using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.AdvTopic
{
    public class LoggingService : IMathPerformedService
    {
        public void OnMathPerformed(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("Logging result " + args.Result);
        }
    }
}

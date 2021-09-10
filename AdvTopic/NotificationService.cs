using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.AdvTopic
{
    public class NotificationService : IMathPerformedService
    {
        public void OnMathPerformed(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("Notifying result: " + args.Result);
        }
    }
}

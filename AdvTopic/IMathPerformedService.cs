using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.AdvTopic
{
    public interface IMathPerformedService
    {
        void OnMathPerformed(object sender, MathPerformedEventArgs args);
    }
}

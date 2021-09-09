using System;

namespace LearningCSharp.AdvTopic
{
    public class MathPerformedEventArgs : EventArgs
    {
        public double Result { get; set; }

        public MathPerformedEventArgs(double result)
        {
            Result = result;
        }
    }
}

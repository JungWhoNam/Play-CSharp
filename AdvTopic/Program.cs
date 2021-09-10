using System;
using System.Collections.Generic;

//https://www.youtube.com/watch?v=YGZe06l9QwM&list=PLYMOUCVo86jGxzypthBW_6qMAO7GXzmCw&index=2&ab_channel=ProgrammingMadeEZ
// 30:50
namespace LearningCSharp.AdvTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();

            new List<IMathPerformedService>
            {
                new LoggingService(),
                new NotificationService()
            }.ForEach(serv => service.MathPerformed += serv.OnMathPerformed);

            service.AddNumbers(5.1, 0.3);
            service.MultiplyNumbers(5.1, 2.0);
        }
    }
}

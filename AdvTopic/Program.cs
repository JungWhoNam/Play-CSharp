using System;

//https://www.youtube.com/watch?v=YGZe06l9QwM&list=PLYMOUCVo86jGxzypthBW_6qMAO7GXzmCw&index=2&ab_channel=ProgrammingMadeEZ
// 30:50
namespace LearningCSharp.AdvTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            service.MathPerformed += OnOutboundEvent;
            service.AddNumbers(2.0, 1.1);
            service.MultiplyNumbers(2.0, 1.1);
        }

        static void OnOutboundEvent(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine($"Outbound Result: {args.Result}");
        }
    }
}

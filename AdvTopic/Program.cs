using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=YGZe06l9QwM&list=PLYMOUCVo86jGxzypthBW_6qMAO7GXzmCw&index=2&ab_channel=ProgrammingMadeEZ
// 19:50
namespace LearningCSharp.AdvTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            service.OutboundDelegate = OnOutboundDelegate;
            var result = service.MathDelegate(4.1, 2.0);
            Console.WriteLine($"Result: {result}");
        }

        static void OnOutboundDelegate(double result)
        {
            Console.WriteLine($"Outbound Result: {result}");
        }
    }
}

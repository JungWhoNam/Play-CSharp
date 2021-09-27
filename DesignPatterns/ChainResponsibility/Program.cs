using System;

namespace LearningCSharp.DesignPatterns.ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainNode isLessThan = new IsLessThan(10);
            isLessThan.Execute(5);
            isLessThan.Execute(15);

            ChainNode isOdd = new IsOdd();
            isOdd.Execute(4);
            isOdd.Execute(5);

            ChainNode isDivisible = new IsDivisible(5);
            isDivisible.Execute(15);
            isDivisible.Execute(14);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
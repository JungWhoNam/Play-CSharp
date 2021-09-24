using System;

// based on https://nowonbun.tistory.com/456
namespace LearningCSharp.DesignPatterns.ChainResponsibility
{
    public abstract class ChainNode
    {
        public ChainNode Next { get; set; }
        public abstract bool Execute(int data);
    }

    public class IsLessThan : ChainNode
    {
        public int Value { get; private set; }

        public IsLessThan(int value)
        {
            this.Value = value;
        }

        public override bool Execute(int data)
        {
            if (data < this.Value)
            {
                Console.WriteLine($"{data} is less than {this.Value}.");
                return true;
            }
            return false;
        }
    }

    public class IsOdd : ChainNode
    {
        public override bool Execute(int data)
        {
            if (data % 2 == 1)
            {
                Console.WriteLine($"{data} is odd.");
                return true;
            }
            return false;
        }
    }

    public class IsDivisible : ChainNode
    {
        public int Value { get; private set; }

        public IsDivisible(int value)
        {
            this.Value = value;
        }

        public override bool Execute(int data)
        {
            if (data % this.Value == 0)
            {
                Console.WriteLine($"{data} is divisible by {this.Value}.");
                return true;
            }
            return false;
        }
    }

    class ChainClass
    {

    }

}

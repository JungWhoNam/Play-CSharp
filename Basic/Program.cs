using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            character.Hp = 10;
            Console.WriteLine("HP is " + character.Hp);

            character.Hp = -10;
            Console.WriteLine("HP is " + character.Hp);

            character.Hp = 110;
            Console.WriteLine("HP is " + character.Hp);
        }
    }
}

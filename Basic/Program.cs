using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character0 = new Character();
            Character character1 = new Character("Tonny");

            {
                Character character = character0;

                character.Hp = 10;
                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                character.Hp = -10;
                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                character.Hp = 110;
                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                Console.WriteLine("{0} starts at {1}", character.GetType().Name, Character.baseline);
                // const are implicity static
                // so access them through the class name (instead through instance members)
                Console.WriteLine("{0} is {1}", character.GetType().Name, Character.type);
            }

            {
                Character character = character1;

                character.Hp = 10;
                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                character.Hp = -10;
                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                character.Hp = 110;
                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                Console.WriteLine("{0} starts at {1}", character.GetType().Name, Character.baseline);
                // const are implicity static
                // so access them through the class name (instead through instance members)
                Console.WriteLine("{0} is {1}", character.GetType().Name, Character.type);
            }

            {
                Character character = character0 + character1;

                Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

                Console.WriteLine("{0} starts at {1}", character.GetType().Name, Character.baseline);
                // const are implicity static
                // so access them through the class name (instead through instance members)
                Console.WriteLine("{0} is {1}", character.GetType().Name, Character.type);
            }
        }
    }
}

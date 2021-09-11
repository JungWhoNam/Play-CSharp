using System;

namespace LearningCSharp
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Character character0 = new Character();
        //    Character character1 = new Character("Tonny");

        //    {
        //        Character character = character0;

        //        character.Hp = 10;
        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        character.Hp = -10;
        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        character.Hp = 110;
        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        Console.WriteLine("{0} starts at {1}", character.GetType().Name, Character.baseline);
        //        // const are implicity static
        //        // so access them through the class name (instead through instance members)
        //        Console.WriteLine("{0} is {1}", character.GetType().Name, Character.type);
        //    }

        //    {
        //        Character character = character1;

        //        character.Hp = 10;
        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        character.Hp = -10;
        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        character.Hp = 110;
        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        Console.WriteLine("{0} starts at {1}", character.GetType().Name, Character.baseline);
        //        // const are implicity static
        //        // so access them through the class name (instead through instance members)
        //        Console.WriteLine("{0} is {1}", character.GetType().Name, Character.type);
        //    }

        //    {
        //        Character character = character0 + character1;

        //        Console.WriteLine("{0} has a health point of {1}", character.name, character.Hp);

        //        Console.WriteLine("{0} starts at {1}", character.GetType().Name, Character.baseline);
        //        // const are implicity static
        //        // so access them through the class name (instead through instance members)
        //        Console.WriteLine("{0} is {1}", character.GetType().Name, Character.type);
        //    }


        //    // ??= operator
        //    // ? and ?? togather
        //    // instead of assigning a value to the left operand, you can also throw an exception.
        //    {
        //        Character character = null;

        //        //character = new Character("Tom");

        //        //character ??= new Character();
        //        // ??= is the same as the below.
        //        //if (character == null) character = new Character();

        //        character?.ShoutName();

        //        Console.WriteLine("My name is {0}.", character?.name ?? "not defined");

        //        try
        //        {
        //            Console.WriteLine("My name is {0}.", character?.name ?? throw new ArgumentNullException(nameof(character), "cannot be null"));
        //        }
        //        catch (ArgumentNullException e)
        //        {
        //            Console.WriteLine("Error... {0}", e.Message);
        //        }
        //    }

        //    // ?? operator
        //    {
        //        Character c0 = null;
        //        Character c1 = new Character("tom");

        //        // assigns c0 or c1 (that is not null) to character
        //        // if both are not null, assigns c0 to character 
        //        Character character = c0 ?? c1;
        //        Console.WriteLine("My name is {0}.", character?.name);
        //    }

        //    // ?? operator is right-associative... a ?? b ?? c = a ?? (b ?? c)
        //    {
        //        Character c0 = new Character();
        //        Character c1 = new Character("tom");
        //        Character c2 = new Character("daisy");

        //        // assigns c0, c1, c2 (that is not null) to character
        //        // if all are not null, assigns c0 to character 
        //        Character character = c0 ?? c1 ?? c2;
        //        Console.WriteLine("My name is {0}.", character?.name);
        //    }
        //}



        // https://docs.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
        static void Main(string[] args)
        {
            {
                string root = @"C:\users";
                string root2 = @"C:\users";
                // 1)
                root = @"C:\Users";
                // 2)
                VisState state0 = new VisState() { root = "hello" };
                VisState state1 = new VisState() { root = "hello" };
                root = state0.root;
                root2 = state1.root;


                bool result = root.Equals(root2);
                Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
                result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
                Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
                Console.WriteLine($"Using == says that <{root}> and <{root2}> are {(root == root2 ? "equal" : "not equal")}");
            }

        }

        public class VisState
        {
            public string root;
        }
    }
}

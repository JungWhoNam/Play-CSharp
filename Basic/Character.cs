using System;
using System.Collections.Generic;
using System.Text;

// getter and setter properties
// const vs readonly keywords
namespace LearningCSharp
{
    class Character
    {
        // can only assign values in declaration part and in the constructor part (runtime constant)
        // cannot declare the keyword in methods (only in the constructor)
        // can be used with static modifiers
        public static readonly long baseline;
        public readonly string name = "John";

        // can only assign values in declaration part (compile constant)
        // can declare the keyword inside methodss
        // cannot be used with static modifiers
        public const string type = "Human";

        private int hp;

        // getter and setter properties
        public int Hp
        {
            get { return hp; }
            set
            {
                if (value < 0 || value > 100) hp = 0;
                else hp = value;
            }
        }

        static Character()
        {
            baseline = DateTime.Now.Ticks;
        }

        public Character()
        {
        }

        public Character(string name)
        {
            // can reassign values in the constructor because the variable has readonly keyword (if it has constant keyword wouldn't work).
            this.name = name;
        }

    }
}

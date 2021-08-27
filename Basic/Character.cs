using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Character
    {
        private int hp;

        public int Hp
        {
            get { return hp; }
            set
            {
                if (value < 0 || value > 100) hp = 0;
                else hp = value;
            }
        }
    }
}

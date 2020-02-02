using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class AngryChicken
    {
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        public bool Bread { get; set; } = true;
        public bool Pickle { get; set; } = true;

        public list<string> SpecialInstructions
        {
            get
            {
                list<string> instructions = new list<string>();
                if (!Bread)
                {
                    instructions.Add("hold bread");
                }
                if (!Pickle)
                {
                    instructions.Add("hold pickle");
                }
                return instructions;
            }
        }
    }
}

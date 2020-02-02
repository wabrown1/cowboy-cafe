using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class PecosPulledPork
    {
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        public uint Calories
        {
            get { return 528; }
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
                return instructions
            }
        }
    }
}

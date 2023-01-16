using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class player : GameCharacter 
    {
        public int shield = 100;
        public int lives = 3;

        public player(string name) : base(name)
        {

        }
    }
}

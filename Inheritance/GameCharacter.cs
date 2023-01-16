using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class GameCharacter
    {

        //fields
        public int health;
        public string name;
        //...
        //...


        //methods

        public GameCharacter(string name, int health)
        {
            health = 100;
            this.name = name;
            
            
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health < 0) health = 0;
        }

        public void Heal(int hp)
        {
            health += hp;
            if (health > 100) health = 100;
        }

        public void ShowStat()
        {
            Console.WriteLine("Health = " + health);
        }
    }
}

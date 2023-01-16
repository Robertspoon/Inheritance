using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");

            // instantiate classes
            //GameCharacter gameCharacter = new GameCharacter();
            player player = new player("Gamer");
            enemy enemy = new enemy("Anti-Gamer");

            //gameCharacter.ShowStat();
           // gameCharacter.TakeDamage(60);
           // gameCharacter.ShowStat();
           // Console.WriteLine();
            player.ShowStat();
            player.TakeDamage(30);
            player.ShowStat();
            player.Heal(100);
            player.ShowStat();
            Console.WriteLine("Name: " + player.name);
            Console.WriteLine("Lives = " + player.lives);
            Console.WriteLine("Shields = " + player.shield);
            Console.WriteLine();
            enemy.ShowStat();
            enemy.TakeDamage(20);
            enemy.ShowStat();
            player.Heal(100);
            player.ShowStat();
            Console.WriteLine("Name: " + enemy.name);

            Console.ReadKey(true);
        }
    }
}

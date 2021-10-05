using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllesConditionalProject
{
    class Program
    {
        static int weapon;
        static int health = 100;
        static int weaponPickup;

        static void ShowHud()
        {
            Console.WriteLine("<3 <3 <3 <3 <3 <3");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Weapon: ");
            Console.WriteLine("<3 <3 <3 <3 <3 <3");
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void HealthUp(int hp)
        {
            health = health + hp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Elle's conditional project");
            if (health < 0)
            {
                health = 0;
            }
            if (health > 100)
            {
                health = 100;
            }
            ShowHud();

            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllesConditionalProject
{
    class Program
    {
        static int health = 100;
        static int weapon;

        static void Weapon()
        {
            Console.WriteLine("Weapon: ");
            if (weapon == 0)
            {
                Console.WriteLine("Pistol");
            }
            if (weapon == 1)
            {
                Console.WriteLine("Shotgun");
            }
            if (weapon == 2)
            {
                Console.WriteLine("Spreader");
            }
            if (weapon == 3)
            {
                Console.WriteLine("Laser");
            }
            if (weapon == 4)
            {
                Console.WriteLine("Sniper");
            }
            if (weapon == 5)
            {
                Console.WriteLine("BFG");
            }

            if (weapon < 0)
            {
                weapon = 0;
            }
            if (weapon > 5)
            {
                weapon = 5;
            }
        }

        static void ShowHud()
        {
            Console.WriteLine("<3 <3 <3 <3 <3 <3");
            Console.WriteLine();
            Console.WriteLine("Health: ");
            Console.WriteLine(+ health);
            Console.WriteLine();
            Weapon();
            Console.WriteLine();
            Console.WriteLine("<3 <3 <3 <3 <3 <3");
            Console.WriteLine();
        }
        static void WeaponPickup()
        {
            weapon = weapon + 1;

            Console.WriteLine("You picked up a new weapon!");
            Console.WriteLine();
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
            Console.WriteLine("Owch! You were hit!");
            Console.WriteLine();
            if (health < 0)
            {
                health = 0;
            }
            if (health > 100)
            {
                health = 100;
            }
        }
        static void HealthUp(int hp)
        {
            health = health + hp;
            Console.WriteLine("Nice! You picked up a stimpak!");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
           
            ShowHud();

            TakeDamage(25);

            ShowHud();

            HealthUp(25);

            ShowHud();

            TakeDamage(50);

            WeaponPickup();

            ShowHud();

            WeaponPickup();

            ShowHud();

            WeaponPickup();

            ShowHud();

            WeaponPickup();

            ShowHud();

            WeaponPickup();

            ShowHud();

            TakeDamage(25);

            ShowHud();

            TakeDamage(50);//killing blow

            ShowHud();

            Console.ReadKey(true);
        }
    }
}

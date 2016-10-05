using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

// Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
//  Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.
//  When an object is constructed from this class it should have the ability to pass a name
//  Let's create an addition constructor that accepts 5 parameters so it can set custom values for every field.
//  Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter. The damage done should be 5 x strength.
//  (Optional) Change the last function to accept any object and just make sure it is of type Human before applying damage. Hint you may need to refer back to the Boxing/Unboxing tab! 

namespace ConsoleApplication

{
// _____________CLASS____________
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;

//default constructor
        public Human(string name_val)
        {
            this.name = name_val;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
            this.health = 100;
        }
//overloading constructor
        public Human(string name_val, int strength_val, int intelligence_val, int dexterity_val, int health_val )
        {
            this.name = name_val;
            this.strength= strength_val;
            this.intelligence = intelligence_val;
            this.dexterity = dexterity_val;
            this.health = health_val;
        }
//attack method
        public void Attack(Human enemy)
        {
           enemy.health -= 5*this.strength;
        }
    }
    public class Program
    {
// _____________MAIN____________
        public static void Main(string[] args)
        {
            Human me = new Human("Alex", 10, 200, 15, 1000);
            Human you = new Human("Iain");
            Console.WriteLine("This is me.health " + me.health);
            Console.WriteLine("This is me.strength " + me.strength);
            Console.WriteLine("This is you.health " + you.health);
            Console.WriteLine("This is you.strength " + you.strength);
            me.Attack(you);
            you.Attack(me);
            Console.WriteLine("Enemy is attacking me!");
            Console.WriteLine("This is me.health " + me.health);
            Console.WriteLine("This is me.strength " + me.strength);
            Console.WriteLine("I'm attacking enemy!");
            Console.WriteLine("This is you.health " + you.health);
            Console.WriteLine("This is you.strength " + you.strength);
        }
    }
}

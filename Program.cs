using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myHuman = new Human("name");

        }
    }
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public int health
        {
            get { return Health; }
        }
        // initiation function: called whenever a new person is made

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Dexterity = 3;
            Intelligence = 3;
            Health = 100;
        }

        // Second option to the Human class, makes it possible to change the attributes of the new human
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;

        }

        // Pass an entire class into a function. "Target" is another human. HUMAN V HUMAN.
        public int Attack(Human target)
        {
            int AttackVal = Strength * 5;
            target.Health -= AttackVal;
            return target.Health;

        }
    }
}

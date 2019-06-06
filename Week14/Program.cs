using System;
using System.Collections.Generic;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            BeeHive Beestles = new BeeHive(new Bee[]{new Bee("John", 3.2f), new Bee("Paul", 2.7f), new Bee("George", 1.1f), new Bee("Ringo", 2.0f)}, 4);
            BeeHive Nirvanectar = new BeeHive(new Bee[]{new Bee("Kurt", 2.3f), new Bee("Dave", 7.4f), new Bee("Krist", 1.5f)}, 3);

            Beestles.QueenBee = new QueenBee("Brian");

            int days = 7;

            string input = "yes";

            Console.WriteLine($"Collected {Beestles.CollectHoney(days)} from the Beastles after {days} days.");
            Console.WriteLine($"Collected {Nirvanectar.CollectHoney(days)} from Nirvanectar after {days} days.");

            Console.WriteLine($"There are {Beestles.Bees.Count} bees in the Beestles.");
            Console.WriteLine($"There are {Nirvanectar.Bees.Count} bees in Nirvanectar.");

            while (true)
            {
                Console.WriteLine("Would you like to access the Beestles and encourage the queen bee to produce a new bee? (yes/quit/no)");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    Beestles.Bees.Add(Beestles.QueenBee.MakeBee("A new Bee"));
                    Console.WriteLine($"Collected {Beestles.CollectHoney(days)} from the Beastles after {days} days.");
                    Console.WriteLine($"Collected {Nirvanectar.CollectHoney(days)} from Nirvanectar after {days} days.");

                    Console.WriteLine($"There are {Beestles.Bees.Count} bees in the Beestles.");
                    Console.WriteLine($"There are {Nirvanectar.Bees.Count} bees in Nirvanectar.");
                } else if (input == "quit")
                {
                    break;
                } else
                {
                    Console.WriteLine("Thats okay I respect your decision");
                }
            }
            Console.ReadKey();
        }
    }

    class Bee
    {
        public string Name;
        public float Size;

        public Bee(string name, float size)
        {
            Name = name;
            Size = size;
        }
    }

    class QueenBee : Bee
    {
        public QueenBee(string name) : base(name, 0) {}

        public Bee MakeBee(string name)
        {
            return new Bee(name, 0.1f);
        }
    }

    class BeeHive
    {
        public List<Bee> Bees;
        public int MaxBees;
        public QueenBee QueenBee;

        public BeeHive(Bee[] bees, int maxBees)
        {
            Bees = new List<Bee>();
            Bees.AddRange(bees);
            MaxBees = maxBees;
        }

        public float CollectHoney(int days)
        {
            float honey = 0;

            for (int i = 0; i < Bees.Count; i++)
            {
                honey += Bees[i].Size;
            }

            return honey * 0.2f * days;
        }
    }
}
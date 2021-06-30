using System;

namespace Uni_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            Console.WriteLine("Hello to our farm, we have 2 animals you can choose from!");

            var input = Console.ReadLine();
            PickAnAnimal(ref animal, input);
            input = Console.ReadLine();

            while (input != "4")
            {
                AnimalActions(animal, input);
                input = Console.ReadLine();
            }

            void AnimalActions(Animal animal, string input)
            {
                Console.WriteLine("Type 1 to eat!");
                Console.WriteLine("Type 2 to sleep!");
                Console.WriteLine("Type 3 to be idle!");
                Console.WriteLine("Type 4 to exit!");

                if (input == "1")
                {
                    if (animal.GetType().Name == "Horse")
                    {
                        Console.WriteLine("HORSE IS STARTING TO FEED");
                    }
                    Console.WriteLine(animal.GetType().Name);
                    animal.Feed();
                }
                else if (input == "2")
                {
                    animal.Sleep();
                }
                else if (input == "3")
                {
                    animal.Idle();
                }
            }

            void PickAnAnimal(ref Animal animal, string input)
            {
                Console.WriteLine("Type 1 for cow!");
                Console.WriteLine("Type 2 for horse!");

                if (input == "1")
                {
                    animal = new Cow();
                }
                else if (input == "2")
                {
                    animal = new Horse();
                }
                else 
                {
                    input = Console.ReadLine();
                    PickAnAnimal(ref animal, input);
                }
            }
        }

        
    }
}

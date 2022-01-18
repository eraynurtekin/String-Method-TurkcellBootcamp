using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAndCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> animals = new List<string> { "Cat", "Dog", "Fish", "Zebra", "Bird" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            //Using of IndexOf:
            Console.WriteLine("\nIndexOf(\"Cat\"): {0}",
             animals.IndexOf("Fish"));

            Console.WriteLine(animals.IndexOf("Fish"));
            //Using of Contains:

            Console.WriteLine(animals.Contains("Cat"));


            List<Zoo> zoos = new List<Zoo>();
            zoos.Add(new Zoo() { Name = "Penguin" });
            zoos.Add(new Zoo() { Name = "Lion" });
            zoos.Add(new Zoo() { Name = "Bird" });
            Console.WriteLine("***--Welcome To Zoo--***");

            foreach (Zoo item in zoos)
            {
                Console.WriteLine("Name: {0}", item.Name);
            }

            //Using of Count

            Console.WriteLine("Animals Count: {0}", zoos.Count);

            //Using of Split

            string animalGroup = "Parrot is a bird";

            string[] words = animalGroup.Split(' ');
            Console.WriteLine("Animal Group total {0} words. ", words.Length);
            Console.ReadLine();

        }
    }
}

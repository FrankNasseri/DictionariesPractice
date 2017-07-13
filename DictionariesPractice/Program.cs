using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax for dictionary 

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix" },
            //    {"A2", "Twizzlers" },
            //    {"A3", "Reeses" },
            //    {"A4", "Sour Patch Kids" }
            //};
            //foreach(KeyValuePair<string, string>item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //    //using add method to add drinks
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottle Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew Code Red");
            ////counting the number of entries in the dictionary
            ////Console.WriteLine(drinkMachine.Count);

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}

            //Create a dictionary for a thearter coat check with 10 elements
            //the key will be a number and the value will be the coat style
            //print all the elements to the console

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            //coatCheck.Add(1, "Leather Jacket");
            //coatCheck.Add(2, "Bomber Jacket");
            //coatCheck.Add(3, "Wind Breker");
            //coatCheck.Add(4, "Winter Jacket");
            //coatCheck.Add(5, "Rain Coat");
            //coatCheck.Add(6, "Trench Coat");
            //coatCheck.Add(7, "Puffer Jacket");
            //coatCheck.Add(8, "Northface");
            //coatCheck.Add(9, "Hoodie");
            //coatCheck.Add(10, "Zip-up");

            //foreach (KeyValuePair<int,string> jacket in coatCheck)
            //{
            //    Console.WriteLine(jacket.Key);
            //    Console.WriteLine(jacket.Value);
            //}

            //Car valet with 10 cars the key will be a customers last name and the value will be the car make
            //print all the elements to the console
            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Nasseri", "Maserati" },
            //    {"Thomas", "Ford" },
            //    {"Russo", "Jeep" },
            //    {"Calabrese", "Mercedes" },
            //    {"Marous", "Range Rover" },
            //    {"Rowe", "Volkswagon" },
            //    {"Phelps", "Mazda" },
            //    {"Argie", "Audi" },
            //    {"Rubin", "Volvo" },
            //    {"Bundy", "Toyota" }
            //};
            //foreach (KeyValuePair<string,string> car in carValet)
            //{
            //    Console.WriteLine(car);
            //}

            //create a dictionary of 10 zoo animals. the key will be the animal type. the value will be the number of animals
            //print the animal withthe highest quantity to the console.
            //remove the zoo animal with the lowest count. use the Remove()

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Monkeys", 11 },
                {"Zebras", 6 },
                {"Lions", 5 },
                {"Tigers", 5 },
                {"Bears", 7 },
                {"Gorillas", 4 },
                {"Camels", 3 },
                {"zlephants", 2 },
                {"Hippos", 9 },
                {"Panters", 1 }
            };
            Console.WriteLine(zooAnimals.Keys.Max()); 
            //Console.WriteLine(zooAnimals.Keys."Monk);


        }
    }
}

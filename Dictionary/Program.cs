using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix" },
            //    {"A2", "Twizzlers" },
            //    {"A3", "Reeses" },
            //    {"A4", "Sour Patch Kids" }
            //};
            //foreach(KeyValuePair<string, string> item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}




            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            //// using .Add method to .Add drinks
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew");

            //// .Count the number of entries .Add(ed) in the dictionary
            //Console.WriteLine(drinkMachine.Count);

            //foreach(KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key); // .Value - returns Value .Key - returns Key
            //    Console.WriteLine(drink.Value); 
            //}




            //// Create a dictionary for a theater coat check with 10 elements. 
            //// The .Key will be a number and the .Value will be the coat style.
            //// Print all elment to console.

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            //{

            //    coatCheck.Add(8, "Rain");
            //    coatCheck.Add(9, "Puffer");
            //    coatCheck.Add(10, "Sparkle");
            //    coatCheck.Add(11, "Trench");
            //    coatCheck.Add(12, "Tall");
            //    coatCheck.Add(13, "Green");
            //    coatCheck.Add(14, "Fleece");
            //    coatCheck.Add(15, "Pink");
            //    coatCheck.Add(22, "Soft");

            //};
            //foreach(KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat);
            //}





            //// Create a dictionary for a car valet service with 10 cars.
            //// The .Key will be the customer’s last name and the .Value will be the car make.
            //// Print all elements to console.

            //Dictionary<string, string> lastCar = new Dictionary<string, string>()
            //{

            //    {"Pham", "Nissian"},
            //    {"Piekutowski", "Dogde"},
            //    {"Hendrix", "Jeep" },
            //    {"Grayson", "Subaru" },
            //    {"Quinn", "Toyota" },
            //    {"Gunder", "Carless" },

            //};
            //foreach(KeyValuePair<string, string> last in lastCar)
            //{
            //    Console.WriteLine(last);
            //}





            // Create a program of 10 zoo animals, the .Key will be animal type .Value will be the number of animals.
            // Print the animals with the highest quantity to the console.
            // .Remove the zoo animal with the 2 lowest count.

            Dictionary<string, int> animalType = new Dictionary<string, int>();
            {
                animalType.Add("Pigs", 4);
                animalType.Add("Lions", 7);
                animalType.Add("Turtles", 10);
                animalType.Add("Meerkat", 20);
                animalType.Add("Elephants", 4);
                animalType.Add("Flamingos", 46);
                animalType.Add("Brids", 69);
                animalType.Add("Rhino", 2);
                animalType.Add("Polar Bear", 8);
                animalType.Add("Gorillas", 15);
            };

            foreach (KeyValuePair<string, int> animal in animalType.OrderByDescending(i => i.Value).ToList(5)) //.Take(10))    //(key => key.Value)) not declaring i or key?
            {

                animalType.Remove(animal.Key);

                Console.WriteLine("We have {0} {1} in the zoo!", animal.Value, animal.Key);

                
            }



        } 
        
    }
}

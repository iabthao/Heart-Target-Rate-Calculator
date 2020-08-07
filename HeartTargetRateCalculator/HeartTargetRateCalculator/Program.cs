using System;

namespace HeartTargetRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //set a title            
            Console.Title = ("Heart Rate Calculator");
            
            //ask for firstName
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            //last name
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            //year of birth
            Console.WriteLine("Please enter your year of birth:");
            int yearbirth = int.Parse(Console.ReadLine());

            //Check value, can't be negative or lesser than 0, prompt reenter

            while (yearbirth <= 0)
            {

                Console.WriteLine("Please enter a valid year of birth");
                Console.WriteLine("Enter your year of birth: ");
                yearbirth = int.Parse(Console.ReadLine());
            }

            //get year

            int currentYear = DateTime.Now.Year;

            //instantiate

            HeartRates heartrates = new HeartRates(firstName, lastName, yearbirth, currentYear);

            //display content

            Console.WriteLine();

            Console.WriteLine($"Hi {firstName} {lastName},");

            Console.WriteLine($"You are {heartrates.PersonAge} years old.");

            //display max rates

            Console.WriteLine($"Your maximum heart rate is {heartrates.MaxRates} beats per minute.");

            //displays min & maximum heart rate for target-rate range

            Console.WriteLine($"Your recommended target-heart-range is {Convert.ToInt32(heartrates.MinHeartRates)} to {Convert.ToInt32(heartrates.MaxHeartRates)} beats per minute.");
            
            
        }
    }
}

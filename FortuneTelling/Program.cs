using System;

namespace FortuneTelling
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What month were you born in (spelled out)");
            string month = Console.ReadLine();
            Console.WriteLine("How many siblings do you have?");
            string siblings = Console.ReadLine();
            Console.WriteLine("What is your favorite primary color? Type HELP for a list of ROYGBIV colors");

            
                string color = Console.ReadLine();
                if (color.ToLower() == "help")
                {
                    Console.WriteLine("Colors to choose from");
                    Console.WriteLine();
                    Console.WriteLine("Red");
                    Console.WriteLine("Yellow");
                    Console.WriteLine("Orange");
                    Console.WriteLine("Green");
                    Console.WriteLine("Blue");
                    Console.WriteLine("Indigo");
                    Console.WriteLine("Violet");

                }
                while (color.ToLower() != "red" &&
                    color.ToLower() != "orange" &&
                    color.ToLower() != "yellow" &&
                    color.ToLower() != "green" &&
                    color.ToLower() != "blue" &&
                    color.ToLower() != "indigo" &&
                    color.ToLower() != "violet")
                {
                    Console.WriteLine("What is your favorite primary color? Type HELP for a list of ROYGBIV colors");
                    color = Console.ReadLine();
                    if (color.ToLower() == "help")
                    {
                        Console.WriteLine("Colors to choose from");
                        Console.WriteLine();
                        Console.WriteLine("Red");
                        Console.WriteLine("Yellow");
                        Console.WriteLine("Orange");
                        Console.WriteLine("Green");
                        Console.WriteLine("Blue");
                        Console.WriteLine("Indigo");
                        Console.WriteLine("Violet");
                    }

                }
            //What kind of house you live in
            string house = null;
            if (color.ToLower() == "red") house = "homeless";
            if (color.ToLower() == "orange") house = "living with parents";
            if (color.ToLower() == "yellow") house = "trailer";
            if (color.ToLower() == "blue") house = "boat";
            if (color.ToLower() == "green") house = "mansion";
            if (color.ToLower() == "indigo") house = "tree house";
            if (color.ToLower() == "violet") house = "house";

            //How many kids you will have
            string kids = null;
            if (age == 0) kids = "unborn";
            if (age >= 15 && age < 25) kids = "one";
            if (age >= 25 && age < 50) kids = "four";
            if (age >= 50 && age < 100) kids = "ten";
            if (age >= 100) kids = "all grown or dead";

            Console.WriteLine("Your name is" + " "+ firstName + " " + lastName);
            Console.WriteLine("You are" + " " + age + " " + "and you were born in" + month);
            Console.WriteLine("You have" + " " + siblings + " " + "sibling(s)");
            Console.WriteLine("Your favorite color is" + color);
            Console.WriteLine("Based on your info and the will of the cosmos");
            Console.WriteLine("You will live in a" + house);
            Console.WriteLine("and you will have" + kids + "kids");

        }
    }
}

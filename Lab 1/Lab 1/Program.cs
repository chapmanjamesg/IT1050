using System;
namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("What is your First Name?");
            string firstName = Console.ReadLine();
            Console.Write("What is your Middle Initial?");
            string middleInitial = Console.ReadLine();
            Console.Write("What is your Last Name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;
            Console.Write("How tall are you in Feet?");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("How many inches remain?");
            double heightInches = double.Parse(Console.ReadLine());
            double totalHeightIn = (heightFeet * 12) + heightInches);
            double totalHeightCM = totalHeightIn * 2.54;
            Console.Write("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.Write("True or False: Are you a US Citizen?");
            bool isCitizen = bool.Parse(Console.ReadLine());
            bool canVote = (age >= 18) && isCitizen;
            Console.WriteLine("Your full name:" + fullName);
            Console.WriteLine("Your Height in Centimeters:" + totalHeightCM);
            Console.WriteLine("Are you able to vote:" + canVote);
            Console.WriteLine("Press any Button to Continue...");
            Console.ReadKey();
        }
    }
}

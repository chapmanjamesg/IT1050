namespace Example5_MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Donnie = new Person("Donnie", "Santos", 37);
            Person James = new Person("James", "Chapman", 30);
            Person michael = new Person("Michael", "Santos", 29);
            Person Alana = new Person();
            Alana.FirstName = "Alana";
            Alana.LastName = "Santos";
            Alana.Age = 43;

            int sum1 = Donnie.AddTwoIntegers(3, 4);
            int sum2 = michael.AddTwoIntegers(4, 5);
            int sum3 = James.AddTwoIntegers(4, 4);

            Donnie.speak("I am the smartest person in the world!");
            michael.speak("That is definitely true.");
            James.speak("I am just here for the cookies.");
            Alana.speak("Word.");

            System.Console.ReadKey();
        }
    }
}

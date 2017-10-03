namespace Section_2_objectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.firstName = "Donnie";
            person1.middleInitial = "J";
            person1.lastName = "Santos";
            person1.Age = 37;

            person2.firstName = "Michael";
            person2.middleInitial = "A";
            person2.lastName = "Santos";
            person2.Age = 29;

            person1.stateYourNameandAge();
            person2.stateYourNameandAge();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}

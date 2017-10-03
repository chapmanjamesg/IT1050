namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.AskForNameandAge();
            P1.CreateSpouseifMarried();

            Person P2 = new Person();
            P2.AskForNameandAge();
            P2.CreateSpouseifMarried();

            System.Console.WriteLine("The average age is " + Person.AverageAge());
            System.Console.ReadKey();


        }
    }
}

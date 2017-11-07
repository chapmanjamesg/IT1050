namespace class_october_10th
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.LifeExpectancy = 78.5;

            Person Donnie = new Person();
            Donnie.Name = "Donnie";

            Person ed = new Person();
            ed.Name = "Ed";

            string myName1 = Donnie.GetMyName();

            System.Console.WriteLine(Donnie.GetMyName());
            System.Console.WriteLine(ed.GetMyName());
        }
    }
}

namespace Section_2_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Person somePerson = new Person();

            somePerson.Name = "John Doe";
            somePerson.age = 21;


            Person anotherPerson = new Person();
            anotherPerson.Name = "Jane Doe";
            anotherPerson.age = 19;

            Person oldestPerson = somePerson; // object references

            // Managed Languages
            // garbage Collector

            anotherPerson = null;
            somePerson = null;
            oldestPerson = null;


        }
    }
}

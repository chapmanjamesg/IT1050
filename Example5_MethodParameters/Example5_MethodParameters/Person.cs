namespace Example5_MethodParameters
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        // definition of constructor:
        // method with the same name as the class!
        // no return type!

        //Constructer Version 1
        public Person()
        {

        }

        // Constructor Version 2
        public Person(string theirfirstname, string theirlastname, int theirAge)
        {
            this.FirstName = theirfirstname;
            this.LastName = theirlastname;
            this.Age = theirAge;
        }

        public int AddTwoIntegers(int x, int y)
        {
            System.Console.WriteLine(this.FirstName + " is thinking...");
            return x + y;
        }

        public void speak(string whatToSay)
        {
            string output = this.FirstName;
            output += " ";
            output += this.LastName;
            output += " say, '";
            output += whatToSay;
            output += "'";

            System.Console.WriteLine(output);
        }
    }
}

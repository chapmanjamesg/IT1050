namespace Lab_2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static int Count;
        public static int SumOfAllAge;

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAge / (double)Person.Count;

        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);

        }
        public void AskForNameandAge()
        {
            System.Console.WriteLine("First Name    :   ");
            this.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Last Name    :    ");
            this.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Age     :   ");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAge += this.Age;

        }
        public void CreateSpouseifMarried()
        {
            System.Console.WriteLine("Are you married?  (y/n)   :  ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.AskForNameandAge();
                this.Spouse.Spouse = this;

            }

        }
    }
}

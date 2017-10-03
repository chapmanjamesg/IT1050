namespace Section_2_objectMethods
{
    class Person
    {
        public string firstName;         // Member (Instance) Variable Declaration (Noun)
        public string middleInitial;     // Member (Instance) Variable Declaration (Noun)
        public string lastName;          // Member (Instance) Variable Declaration (Noun)
        public int Age;

        public string GetFullName()
        {

            return this.firstName + " " + this.middleInitial + ". " + this.lastName;  // shorter way
        }

        public int GetAgeInTenYears()
        {

            return this.Age + 10;  //transforms verb to a noun
        
        }
        public void stateYourNameandAge()   //pure Verb
        {
            System.Console.WriteLine(this.firstName + " says, Hello.");
            System.Console.WriteLine("My Name is " + this.GetFullName());
            System.Console.WriteLine("My Age is " + this.Age);
        }
    }
}

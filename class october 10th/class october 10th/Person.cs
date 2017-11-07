namespace class_october_10th
{
    class Person
    {
        public static double LifeExpectancy;

        public string Name;
        public string GetMyName()
        {
            return this.Name;
        }
        public void PrintMyName()
        {
            System.Console.WriteLine(this.Name);
        }
    }
}

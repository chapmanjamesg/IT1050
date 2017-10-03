namespace Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders myorder = new Orders();
            myorder.GatherDataFromUser();
        

            System.Console.WriteLine("Order Details for " = myorder.FirstName + " " + myorder.LastName + ".");
            System.Console.WriteLine("Your Total Calorie Count = " + myorder.GetTotalCalories() + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}

namespace FightingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Show.HorizontalDivider();

            GoodGuy Harry = new GoodGuy("Harry Potter", 999);
            GoodGuy Hermione = new GoodGuy("Hermione Granger", 200);
            GoodGuy Ron = new GoodGuy("Ron Weasley", 100);

            BadGuy Voldemort = new BadGuy("Tom Riddle", 800);
            BadGuy Bellatrix = new BadGuy("Bellatrix Lestrange", 600);
            BadGuy Draco = new BadGuy("Draco Malfoy", 400);

            Show.HorizontalDivider();

            Voldemort.steal(Harry, 200);
            Voldemort.steal(Draco, 200);
            Bellatrix.steal(Draco, 200);

            Harry.Capture(Bellatrix);
            Harry.give(Hermione, 400);
            Harry.give(Ron, 400);

            Show.HorizontalDivider();
            System.Console.ReadKey();
        }
    }
}

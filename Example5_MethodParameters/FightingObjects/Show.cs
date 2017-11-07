
namespace FightingObjects
{
    public static class Show
    {
        public static void HorizontalDivider()
        {
            System.Console.WriteLine(" +========================================================+");
        }

        public static void CaptureMessage(GoodGuy goodGuy, BadGuy badGuy, double amount)
        {
            Show.Formatted(goodGuy.name + " captured " + badGuy.name + " and got " + amount);
            Show.money(goodGuy);
            Show.money(badGuy);
        }

        public static void GiveMessage(GoodGuy giver, GoodGuy receiver, double amount)
        {
            Show.Formatted(giver.name + " gave " + amount + " to " + receiver.name);
            Show.money(giver);
            Show.money(receiver);
        }

        public static void StealMessage(BadGuy badGuy, GoodGuy goodGuy, double amount)
        {
            Show.Formatted(badGuy.name + " stole " + amount + " from " + goodGuy.name);
            Show.money(badGuy);
            Show.money(goodGuy);
        }

        public static void StealMessage2(BadGuy badGuy, BadGuy otherBadGuy, double amount)
        {
            Show.Formatted(badGuy.name + " stole " + amount + " from " + otherBadGuy.name);
            Show.money(badGuy);
            Show.money(otherBadGuy);
        }
        public static void CreationMessage(string name, double amount)
        {
            Show.Formatted(name + " has been created and has " + amount);
        }

        private static void money(GoodGuy goodGuy)
        {
            Show.money(goodGuy.name, goodGuy.money);
        }
        private static void money(BadGuy badGuy)
        {
            Show.money(badGuy.name, badGuy.money);
        }
        private static void money(string name, double amount)
        {
            Show.Formatted(name + " now has a total of " + amount);
        }
        private static void Formatted(string output)
        {
            output += ".";
            System.Console.WriteLine(" | " + output.PadRight(54) + " | ");
        }
    }
}

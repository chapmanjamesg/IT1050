namespace FightingObjects
{
    public class GoodGuy
    {
        private string name;
        private double money;

        public GoodGuy(string name, double money)
        {
            Show.CreationMessage(name, money);
            this.name = name;
            this.money = money;
        }
       
        public void Capture(BadGuy badGuy)
        {
            double amount = badGuy.money;
            this.money += amount;
            badGuy.money = 0;
            Show.CaptureMessage(this, badGuy, amount);
        }

        public void give(GoodGuy otherGoodGuy, double amount)
        {
            otherGoodGuy.money += amount;
            this.money -= amount;
            Show.GiveMessage(this, otherGoodGuy, amount);
        }
    }
}

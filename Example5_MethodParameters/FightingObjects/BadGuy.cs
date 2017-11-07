namespace FightingObjects
{
    public class BadGuy
    {
        private string name;
        private double money;

        public BadGuy(string name, double money)
        {
            Show.CreationMessage(name, money);
            this.name = name;
            this.money = money;
        }

        public void steal(GoodGuy goodGuy, double amount)
        {
            this.money += amount;
            goodGuy.money -= amount;
            Show.StealMessage(this, goodGuy, amount);
        }

        public void steal(BadGuy otherBadGuy, double amount)
        {
            this.money += amount;
            otherBadGuy.money -= amount;
            Show.StealMessage2(this, otherBadGuy, amount);
        }

    }
}

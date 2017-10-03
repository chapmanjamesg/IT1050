namespace Summary
{
    class Orders
    {
        public string FirstName;
        public string LastName;

        public int Tortilla;
        public int Carnitas;
        public int TacoShells;
        public int Rice;
        public int Steak;
        public int Chicken;
        public int Barbacoa;
        public int Guacamole;
        public int SourCream;
        public int Beans;
        public int Cheese;
        public int CornSalsa;
        public int Fajita;
        public int OtherSalsa;

        public void GatherDataFromUser()
        {
            this.FirstName = Questions.AskForString("First Name");
            this LastName = Questions.AskForString("Last Name");
            this.Chicken = Questions.AskForInterger("How many orders of chicken");
            this.Carnitas = Questions.AskForInterger("How many orders of Carnitas");
            this.Steak = Questions.AskForInterger("How many orders of Steak");
            this.Barbacoa = Questions.AskForInterger("How many orders of barbacoa");

        }
    }
}

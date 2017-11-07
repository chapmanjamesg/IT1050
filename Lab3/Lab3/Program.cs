namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", "John");
            Student Joe = new Student("Joe", "John");
            Student Mellisa = new Student("Mellisa", "Mike");
            Student Matt = new Student("Matt", "Mike");

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Mellisa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.Print();
            Joe.Print();
            Mellisa.Print();
            Matt.Print();


        }
    }
}

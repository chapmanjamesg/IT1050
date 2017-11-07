using system;
namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            teachers theteacher = new teachers();
            theteacher.name = "Donnie Santos";
            teachers.count++;

            students student1 = new students;
            student1.name = "John Doe";
            student1.grade = "b";
            students.count++;

            students student2 = new students;
            student2.name = "Jane Doe";
            student2.grade = "A";
            students.count++;

            System.Console.WriteLine("teachers: " + teachers.count);
            System.Console.WriteLine("students: " + students.count);
            System.Console.WriteLine("press any key to continue...");
            System.Console.ReadKey();

        }
    }
}

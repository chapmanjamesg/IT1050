namespace Lab3
{
    public class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = 0;
        }

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }

        public void Print()
        {
            System.Console.WriteLine(Name + ", Grade: " + Grade + ", taught by: " + Teacher + " teacher of: " + CourseName);
        }
    }
}
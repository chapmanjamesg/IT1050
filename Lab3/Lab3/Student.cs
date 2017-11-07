namespace Lab3
{
    public class Student
    {
        public string Name;
        public int Grade;
        public string Instructor;
        public string CourseName;

        public Student(string Name, string Instructor)
        {
            this.Name = Name;
            this.Instructor = Instructor;
            Grade = 0;
        }

        public void SetGrade(Student thisStudent, int Grade)
        {
            this.Grade += Grade;
        }

        public void Print()
        {
            System.Console.WriteLine(Name + ", Grade: " + Grade + ", taught by: " + Instructor + " teacher of: " + CourseName);
        }
    }
}
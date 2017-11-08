namespace Lab3
{
    public class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string Name, string courseName)
        {
            this.Name = Name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int Grade)
        {
            student.SetGrade(Grade);                       
        }
        public void InstructorInfo()
        {
            System.Console.WriteLine(Name + ", instructor of " + CourseName);
        }
    }
}

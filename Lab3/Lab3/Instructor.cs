namespace Lab3
{
    public class Instructor
    {
        public string Name;
        public string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student studentName, int Grade)
        {
            studentName.Grade += Grade;
            studentName.CourseName = CourseName;
                       
        }
        public void InstructorInfo()
        {
            System.Console.WriteLine(Name + ", instructor of " + CourseName);
        }
    }
}

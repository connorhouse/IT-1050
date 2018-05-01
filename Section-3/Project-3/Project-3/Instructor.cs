namespace Project_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string thierName, string thierCourseName)
        {
            this.Name = thierName;
            this.CourseName = thierCourseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine(Name + ": Teaching = " + CourseName);
        }
    }
}

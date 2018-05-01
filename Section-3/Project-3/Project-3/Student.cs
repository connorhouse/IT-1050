namespace Project_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private string Teacher;

        public Student(string thierName, string thierTeacher)
        {
            this.Name = thierName;
            this.Teacher = thierTeacher;
        }

        public Student(int Grade)
        {
            this.Grade = 0;
        }

        public void SetGrade(int z)
        {
            this.Grade = z;
        }

        public void Print()
        {
            System.Console.WriteLine(Name + " = Grade: " + Grade + ", Teacher: " + Teacher);
        }
    }
}
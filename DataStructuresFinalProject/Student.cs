using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalProject
{
    public class Student
    {
        private string StudentName;
        private string StudentLastName;
        private string Studentumber;
        private string StudentDepartment;

        public Student(string studentName, string studentLastName, string studentNumber, string studentDepartment)
        {
            this.StudentName = studentName;
            this.StudentLastName = studentLastName;
            this.Studentumber = studentNumber;
            this.StudentDepartment = studentDepartment;
        }

        public Student() { }

        public string Name
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        public string LastName
        {
            get { return StudentLastName; }
            set { StudentLastName = value; }
        }

        public string Number
        {
            get { return Studentumber; }
            set { Studentumber = value; }
        }

        public string Department
        {
            get { return StudentDepartment; }
            set { StudentDepartment = value; }
        }

        
    }
}

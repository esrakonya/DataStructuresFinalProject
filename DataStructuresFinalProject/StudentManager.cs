using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalProject
{
    class StudentManager : IStudent
    {
        public void StudentInformation(Student student)
        {
            Console.Write("Öğrencinin adı : " + student.Name);
            Console.WriteLine();
            Console.Write("Öğrencinin soyadı : " + student.LastName);
            Console.WriteLine();
            Console.Write("Öğrenci numarası : " + student.Number);
            Console.WriteLine();
            Console.Write("Öğrencinin bölümü : " + student.Department);
            Console.WriteLine();
        }
    }
}

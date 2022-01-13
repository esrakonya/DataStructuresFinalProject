using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalProject
{
    class LessonManager : ILesson
    {
        public void LessonList(Student student, SinglyLinkedList list)
        {
            Console.Write("Kaçıncı sınıf olduğunuzu giriniz : ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hangi dönemin derslerini görmek istiyorsunuz (bahar/güz) : ");
            string period = Console.ReadLine();
            Console.WriteLine(student.Name + " " + student.LastName + " adlı, " + student.Number + " numaralı öğrencinin " + grade + ". sınıf " + period + " dönemi alacağı dersler : ");
        }
    }
}

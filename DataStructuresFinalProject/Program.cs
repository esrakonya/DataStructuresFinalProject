 using System;
using System.Collections.Generic;

namespace DataStructuresFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            list1.Push("Elektronik Devreler");
            list1.Push("Nesneye Yönelik Programlama");
            list1.InsertAfter(list1.Head.Next, "Bilgisayar Destekli Teknik Çizim");
            list1.Push("Veri Yapıları ve Algoritmalar");
            list1.AddLast("Diferansiyel Denklemler");
            list1.InsertAfter(list1.Head.Next.Next, "Elektronik Devreler Lab.");
            list1.AddLast("Girişimcilik");

            Student student1 = new Student("Esra", "Konya", "123456789","Bilgisayar Mühendisliği");

            StudentManager studentManager1 = new StudentManager();
            studentManager1.StudentInformation(student1);

            LessonManager lessonManager1 = new LessonManager();
            lessonManager1.LessonList(student1, list1);

            list1.PrintList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Student student2 = new Student("Cenk", "Seçkin", "147258369","Makine Mühendisliği");

            SinglyLinkedList list2 = new SinglyLinkedList();
            list2.Push("Isı Transferi");
            list2.AddLast("Makine Tasarımı 1");
            list2.InsertAfter(list2.Head.Next, "Makine Dinamiği");
            list2.InsertAfter(list2.Head.Next.Next, "Yaz Stajı");
            list2.DeleteNode("Yaz Stajı");
            list2.AddLast("Motorlar 1");
            list2.InsertAfter(list2.Head.Next.Next.Next, "Metallere Plastik Şekil Verme");
            list2.Push("Makine Elemanları 2");
            list2.Push("Makine Lab. 1");
            list2.AddLast("Teknik seçmeli ders");

            StudentManager studentManager2 = new StudentManager();
            studentManager2.StudentInformation(student2);

            LessonManager lessonManager2 = new LessonManager();
            lessonManager2.LessonList(student2, list2);

            list2.PrintList();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalProject
{
    public class Lesson
    {
        private string LessonName;

        public Lesson(string lessonName)
        {
            LessonName = lessonName;
        }

        public Lesson() { }

        public string LessonsName
        {
            get { return LessonName; }
            set { LessonsName = value; }
        }
    }
}

using System;

namespace SD_KnowledgeCheck2
{
    public class Student : Person
    {
        public int StudentID { get; set; }

        public Student(string name, int studentID) : base(name) => StudentID = studentID;
    }
}

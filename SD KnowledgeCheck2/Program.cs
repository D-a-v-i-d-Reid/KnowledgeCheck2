using SD_KnowledgeCheck2;
using System;
using System.Collections.Generic;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine() ?? " ");

var recordList = new List<Student>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var student = new Student("", 0);

    Console.WriteLine("Enter the name for the student: ");
    student.Name = Console.ReadLine() ?? " ";

    Console.WriteLine("Enter the Student ID for the student: ");
    student.StudentID = int.Parse(Console.ReadLine() ?? " ");

    recordList.Add(student);
}



// Print out the list of records using Console.WriteLine()
Console.WriteLine("List of records:");
foreach (var student in recordList)
{
    Console.WriteLine($"Name: {student.Name}, Student ID: {student.StudentID}");
}
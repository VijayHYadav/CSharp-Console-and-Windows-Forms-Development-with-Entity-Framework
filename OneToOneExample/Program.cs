using ClassLibrary4;
using System;

namespace OneToOneExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student class's object
            Student student = new Student();
            student.RollNo= 1;
            student.StudentName = "Scott";
            student.Email = "scott@gmail.com";

            // Branch class's object
            // Branch br = new Branch();
            // br.BranchName = "Computer Science Engineering";
            // br.NoOfSemesters= 8;

            // one-to-one relation
            // One Way
            // student.branch = br;

            // one-to-one relation
            // Second Way
            student.branch = new Branch();
            student.branch.BranchName = "Computer Science Engineering";
            student.branch.NoOfSemesters = 8;

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemesters);
        }
    }
}

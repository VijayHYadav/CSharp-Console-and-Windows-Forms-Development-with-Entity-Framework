using ClassLibrary5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwoMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of Student class
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName= "Allen";
            student.Email = "allen@gmail.com";
            student.examinations = new List<Examination>();
            student.examinations.Add(new Examination() { 
                ExaminationName = "Module Test1", Month= 1,Year= 2021, MaxMarks=100, SecuredMarks=85
            });
            student.examinations.Add(new Examination()
            {
                ExaminationName = "Module Test2",
                Month = 1,
                Year = 2022,
                MaxMarks = 100,
                SecuredMarks = 85
            });
            student.examinations.Add(new Examination()
            {
                ExaminationName = "Module Test3",
                Month = 1,
                Year = 2023,
                MaxMarks = 100,
                SecuredMarks = 85
            });

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);

            foreach (Examination examination in student.examinations)
            {
                Console.WriteLine(examination.ExaminationName + " : " + examination.Year+"/"+examination.Month+"/");
            }
        }
    }
}

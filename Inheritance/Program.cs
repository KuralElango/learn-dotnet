using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hostel
    {
        public static void HostelName()
        {
            Console.WriteLine("Hostel Name is Rest N Nest");
        }
    }
    public class Dept:Hostel
    {
        public static void DeptName()
        {
            Console.WriteLine("Department name is ECE");
        }
    }
    public class Student:Dept
    {
        public static void StudentName()
        {
            Console.WriteLine("Student name is Harish");
        }
        public static void StudentId()
        {
            Console.WriteLine("StudentId is 225289678629");
        }
    }
    public class College:Student
    {
        public static void CollegeName()
        {
            Console.WriteLine("College Name is sree sastha");
        }
        public static void CollegeId()
        {
            Console.WriteLine("College ID is 2522");
        }

        static void Main(string[] args)
        {
           CollegeName();
           CollegeId();
            StudentName();
            StudentId();
            DeptName();
            HostelName();

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpSchool.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teacher = new Teacher { Id = 1, Name = "John", Salary = 150, Classes = new List<string> {"3e"} };
        private Teacher teacherNoPay = new Teacher { Id = 1, Name = "John" };
        private Teacher teacherNegativePay = new Teacher { Id = 1, Name = "John", Salary = -150 };

        [TestMethod()]
        public void ValidateSalaryTest()
        {
            teacher.ValidateSalary();
            Console.WriteLine(teacher.Salary);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            teacher.Validate();
            Console.WriteLine(teacher.ToString());  
        }
    }
}
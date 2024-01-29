using BrushUpSchool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpSchool.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student student = new Student { Id = 1, Name = "John", Semester = 3 };
        private Student studentNoName = new Student { Id = 1, Semester = 3 };
        private Student studentShortName = new Student { Id = 1, Name = "", Semester = 3 };
        private Student studentNoSemester = new Student { Id = 1, Name = "John" };
        private Student studentLowSemester = new Student { Id = 1, Name = "John", Semester = -1 };
        private Student studentHighSemester = new Student { Id = 1, Name = "John", Semester = 9 };

        [TestMethod()]
        public void ValidateNameTest()
        {
            student.ValidateName();
            Console.WriteLine(student.Name);  
        }
        [TestMethod()]
        public void ValidateSemesterTest()
        {
            student.ValidateSemester();
            Console.WriteLine(student.Semester);
        }
        [TestMethod()]
        public void ValidateTest()
        {
            student.Validate();
            Console.WriteLine(student.ToString());
        }
    }
}

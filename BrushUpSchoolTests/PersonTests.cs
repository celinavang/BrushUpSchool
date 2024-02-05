using BrushUpSchool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpSchoolTests
{
    [TestClass()]
    internal class PersonTests
    {
        private Person person = new Person { Id = 1, Name = "John" };
        private Person personNoName = new Person { Id = 2 };
        private Person personShortName = new Person { Id = 3, Name = ""};

        [TestMethod()]
        public void ValidateNameTest()
        {
            person.ValidateName();
            Console.WriteLine(person.Name);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            person.Validate();
            Console.WriteLine(person.ToString());
        }
    }
}

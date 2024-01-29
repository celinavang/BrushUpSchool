using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpSchool
{
    public class Student : Person
    {

        public int Semester {  get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Semester;
        }

        public void ValidateSemester()
        {
            if (Semester < 1)
            {
                throw new ArgumentOutOfRangeException("Semester cannot be less than 1");
            }
            if (Semester > 8)
            {
                throw new ArgumentOutOfRangeException("Semester cannot be more than 8");
            }
        }

        public void Validate() 
        {
            ValidateName();
            ValidateSemester();
        }
    }
}

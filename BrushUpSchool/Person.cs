using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpSchool
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id + " " + Name;
        }

        public void ValidateName()
        {
            if (Name ==  null)
            {
                throw new ArgumentNullException("Name is null");
            }
            if (Name.Length < 1)
            {
                throw new ArgumentException("Name must be at least 1 char");
            }
        }

        public void Validate() 
        {
            ValidateName();
        }

    }


}

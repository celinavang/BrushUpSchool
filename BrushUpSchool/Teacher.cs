namespace BrushUpSchool
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public List<string> Classes { get; set; } = new List<string>();
        public override string ToString()
        {
            return Id + " " + Name + " " + Salary;
        }

        public void ValidateSalary() 
        {
            if (Salary < 0)
                throw new ArgumentOutOfRangeException("Salary cannot be negative");
        }

        public void ValidateClasses()
        {
            if (!Classes.Any()) throw new ArgumentException("Teacher must have at least one class");
        }

        public void Validate()
        {
            ValidateName();
            ValidateSalary();
            ValidateClasses();
        }

    }
}

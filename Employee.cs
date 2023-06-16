
namespace cSharp_OOP_Practices
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee() {
            Name = "Unknown";
            Position = "Unknown";
            Salary = 0;
        }
        public Employee(string name, string position, double salary)
        {
            this.Name = name;
            this.Position = position;
            this.Salary = salary;
        }
       
    }
}

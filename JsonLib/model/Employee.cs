using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLib.model
{
    public class Employee
    {
        public String Name { get; set; }
        public int Salary { get; set; }
        public int MonthsEmployed { get; set; }
        public List<String> JobAreas { get; set; }

        public Employee()
        {
            JobAreas = new List<String>();
        }

        public override string ToString()
        {
            return $"Name={Name}, Salary={Salary}, MonthsEmployed={MonthsEmployed}, JobAreas=[{String.Join(", ", JobAreas)}]";
        }
    }
}

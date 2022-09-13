using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLib.model
{
    public class UnKnown
    {
        public String? Name { get; set; }
        public String? Address { get; set; }
        public List<Car> Cars { get; set; }
        public List<Employee> Employees { get; set; }

        public UnKnown()
        {
            Cars = new List<Car>();
            Employees = new List<Employee>();
        }

        public override string ToString()
        {
            return $"Name={Name}, Address={Address}, Cars=[{String.Join(", ", Cars)}], Employees=[{String.Join(", ", Employees)}]";
        }

    }
}

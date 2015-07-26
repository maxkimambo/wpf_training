using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Employee
    {

        public string Name { get; set; }

        public string Title
        {
            get; set;
            

        }

        public static Employee GetEmployee()
        {
            return new Employee {Name = "Max", Title = "Software engineer"}; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysAssignmnet
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Employee(int eid, string ename)
        {
            this.EmpId = eid;
            this.EmpName = ename;
        }
    }
    class Arraylists
    {
        static void Main()
        {
            ArrayList e = new ArrayList();//non generic
            List<Employee> Li = new List<Employee>();//Generic
            Employee e1 = new Employee(1, "vasant");
            Employee e2 = new Employee(2, "vagdevi");
            Employee e3 = new Employee(3, "Bindhu");
            Li.Add(e1);
            Li.Add(e2);
            Li.Add(e3);
            foreach (Employee i in Li)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName);
            }
            Console.ReadKey();
        }
    }
}

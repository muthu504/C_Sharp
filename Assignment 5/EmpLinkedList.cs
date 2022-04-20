using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListForEmployees
{
    internal class EmpLinkedList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            LinkedList<String> list = new LinkedList<String>();
            Console.WriteLine("Adding Employee Details");
            list.AddFirst("Vasanth"); //a) adding a new employee
            list.AddLast("Bindhu");   //a) adding a new employee
            list.AddLast("Vagdevi");  //a) adding a new employee
            list.AddLast("chitti");   //a) adding a new employee
            list.AddLast("Tarun");   //a) adding a new employee

            foreach (String item in list)   //b) displaying a list of employees using foreach loop
            {
                Console.WriteLine("We Overwhelmingly welcome newly Joiners : {0} ",item);    
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine(list.Contains("Vasanth"));   //performing specific search operation (true/false)
            Console.WriteLine(list.Contains("Bindhu"));  //performing specific search operation (true/false)
            Console.WriteLine("===============================================================");
            //c)total number of employees in the list/Count of employees
            Console.WriteLine("Total number of employees in the linked list is : {0} ", list.Count); 
            Console.WriteLine("Program ends...");
        }
    }
}

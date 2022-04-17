using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharrp_Assignment
{
    internal class Highest
        {
            public static void Main()
            {
            //accept the avg marks of 5 stdents and dp higest marks

            /* Console.WriteLine("Enter the Avg marks of student1");
             int AvgStudent1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the Avg marks of student2");
             int AvgStudent2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the Avg marks of student3");
             int AvgStudent3 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the Avg marks of student4");
             int AvgStudent4 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the Avg marks of student5");
             int AvgStudent5 = Convert.ToInt32(Console.ReadLine());


             int[] A1 = new int[10];
             A1[0] = AvgStudent1;
             A1[1] = AvgStudent2;
             A1[2] = AvgStudent3;
             A1[3] = AvgStudent4;
             A1[4] = AvgStudent5;*/
            // using loop and reducing the copmlexity and runtime 
            int[] student = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the Avg marks of student {0}" ,i);
                student[i] = Convert.ToInt32(Console.ReadLine());
            }
                
                Console.WriteLine("Highest marks obtained:" + student.Max());
            //max() is a function that display the highest value 
                Console.ReadLine();
            //output value
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharrp_Assignment
{
    public class Areaofcircle
    {
            public static void Main()
            {
                // variable declaration
                double r, aera_cir;
                //declared pie value
                double Pie = 3.14;
                //collecting value from user 
                Console.WriteLine("Input the radius of the circle : ");
                r = Convert.ToDouble(Console.ReadLine());
                //funtionality
                // area of circle = pie * r * r
                aera_cir =  Pie * r * r ;
                //output 
                Console.WriteLine("Area of Circle : {0}", aera_cir);
                Console.Read();
            }
        }
}
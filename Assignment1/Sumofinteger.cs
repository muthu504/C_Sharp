using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharrp_Assignment
{
    internal class Sumofinteger
    {
        public static void Main(string[] args)
            {

                int[] n1 = new int[5];
                int sum = 0;

                /* n = Convert.ToInt32(Console.ReadLine());
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = Convert.ToInt32(Console.ReadLine());
                n4 = Convert.ToInt32(Console.ReadLine()); */
                int n;
                for (int i = 0; i < 5; i++)
                {
                    n1[i] = Convert.ToInt32(Console.ReadLine());
                }

                sum = sumofinteger(n1);

                Console.WriteLine("Result={0}", sum);
                // Console.ReadKey();
            }
            static int sumofinteger(params int[] val)
            {
                int sum = 0;
                foreach (int i in val)
                {
                    sum += i;
                }
                return sum;
            }
        }
    }

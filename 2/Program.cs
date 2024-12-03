using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[12];
            omas = Input(omas.Length);
            Output(omas);
            Console.WriteLine($"\nсредний рост человека в группе = {Average(omas)}");
            Console.ReadKey();
        }

        static int[] Input(int size)
        {
            Random rand = new Random();
            int[] omas = new int[size];
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rand.Next(163,190);
            }
            return omas;
        }

        static void Output(int[] omas)
        {
            int count = 1;
            foreach (var i in omas)
            {
                Console.WriteLine($"рост {count} человека в группе - {i} см ");
                count++;
            }
        }

        static double Average(int[] omas)
        {
            double sum = 0;
            foreach(var el in omas)
            {
                sum += el;
                
            }
            return sum/2;
        }
        }
    }

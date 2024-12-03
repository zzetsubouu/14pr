using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    /// <summary>
    /// создать массив, заполнить и вывести в обратном порядке
    /// </summary>
    class Program
    {
        static int Steal()
        {
            Console.Write("размер одномерного массива: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("ошибка");
            }
            return size;
        }
        static int[] Input(int size)
        {
            int[] omas = new int[size];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"введите {i + 1} значение массива: ");
                omas[i] = int.Parse(Console.ReadLine());
            }
            return omas;
        }
        static void Output(int[] omas)
        {
            for (int i = omas.Length-1; i > -1; i--)
            {
                Console.WriteLine($"{i+1} элемент массива  = {omas[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] omas = new int[Steal()];
            omas = Input(omas.Length);
            Output(omas);
            Console.ReadKey();
        }
    }
}

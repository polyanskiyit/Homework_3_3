using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRow = 2;
            int maxCol = 2;
            double[,] arr_1 = new double[maxRow, maxCol];
            double[,] arr_2 = new double[maxRow, maxCol];

            double t = 0;
            double res = 0;
            
            double[,] arr_3 = new double[maxRow, maxCol];
            double sumArr_3 = 0;

            Console.WriteLine("Порiвняння масивiв");
            Console.WriteLine("Введiть 4-и чисела для першого масива: ");
            for(int i=0; i<maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    arr_1[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("\nВведiть 4-и чисела для другого масива: ");
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    arr_2[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\n--- Результат ---\nПерший масив:");
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    Console.Write(arr_1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nДругий масив:");
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    Console.Write(arr_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            

            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (arr_1[i, j] > arr_2[i, j])
                    {
                        arr_3[i, j] = ((arr_1[i, j] - arr_2[i, j]) * 100) / arr_1[i, j];
                    }
                    else if (arr_1[i, j] < arr_2[i, j])
                    {
                        arr_3[i, j] = ((arr_2[i, j] - arr_1[i, j]) * 100) / arr_2[i, j];
                    }
                    else
                    {
                        arr_3[i, j] = 100;
                    }

                    if (arr_1[i, j] == arr_2[i, j])
                    {
                        t++;
                    }   
                }
                res = (t / (maxRow * maxCol)) * 100;
            }

            Console.WriteLine("\nМасиви подiбнi на {0} %", (int) res);

            Console.WriteLine();
            Console.WriteLine("\n\nПодiбнiсть кожного елемента у процентах: ");
            
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    //safd
                    Console.Write((int)arr_3[i, j] + " %  ");
                    sumArr_3 += arr_3[i, j];
                }
                Console.WriteLine();
            }
            sumArr_3 = sumArr_3 / (maxRow * maxCol);

            Console.WriteLine("\nТочна подiбнiсть у процентах: {0} %", (int)sumArr_3);

            Console.Read();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<ISortAlgorithm> algorithms = new List<ISortAlgorithm>();

                foreach (var a in Assembly.GetExecutingAssembly().GetTypes().Where(a => a.IsClass && a.BaseType.Name == "BaseAlgorithm" && a.Name != "SleepSort"))
                {
                    algorithms.Add((BaseAlgorithm)Activator.CreateInstance(a, new object[] { DataGenerator.GenerateData(5, 100) }));
                    Console.WriteLine(a.Name);
                }                

                foreach (var algo in algorithms)
                {
                    Console.WriteLine(algo.Name);
                    Console.WriteLine("***************************************");
                    Console.WriteLine();
                    Console.WriteLine("Initial data");
                    Console.WriteLine("***************************************");
                    DisplayArray(algo.Items);
                    Console.WriteLine();
                    int start = Environment.TickCount;
                    algo.Sort();
                    int end = Environment.TickCount;
                    Console.WriteLine();
                    Console.WriteLine("Sorted data");
                    Console.WriteLine("***************************************");
                    DisplayArray(algo.Items);
                    Console.WriteLine();
                    Console.WriteLine("Sorting completed in milliseconds: " + (end - start));
                    Console.WriteLine("***************************************");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

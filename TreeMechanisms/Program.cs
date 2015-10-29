using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TreeMechanisms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
                Tree tree = new Tree(array);

                MethodInfo[] infos = typeof(Tree).GetMethods(BindingFlags.Public | BindingFlags.Instance);

                foreach (var info in infos)
                {
                    if (info.DeclaringType != typeof(Tree))
                        continue;

                    Console.WriteLine("Executing " + info.Name);
                    info.Invoke(tree, null);
                    Console.WriteLine();
                    Console.WriteLine("*************************");
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
    }
}

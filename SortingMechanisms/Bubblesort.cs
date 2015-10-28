using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class BubbleSort : BaseAlgorithm
    {
        public BubbleSort(int[] array) : base(array)
        { }

        public override string Name
        {
            get { return "Bubble sort"; }
        }

        public override void Sort()
        {
            //Take an adjacent pair from the beginning, swap if necessary. 
            //Continue till nth place, when the largest value is at the end of the array.
            //Repeat for (n-1)th position, (n-2)th position, etc.

            //Bubble sort improvisation: break if no swap occurs
            bool continueSort;

            for (int i = array.Count() - 2; i > 0; i--)
            {
                continueSort = false;
                for (int j = 0; j <= i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j, j + 1);
                        continueSort = true;
                    }
                }
                if (!continueSort)
                    break;
            }
        }
    }
}

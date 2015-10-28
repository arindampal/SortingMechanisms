using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class InsertionSort : BaseAlgorithm
    {
        public InsertionSort(int[] array) : base(array)
        { }

        public override string Name
        {
            get { return "Insertion sort"; }
        }

        public override void Sort()
        {
            //Start with a sorted list of 1 element on the left, and N - 1 unsorted items on the right.
            //Take the first unsorted item(element #2) and insert it into the sorted list, moving elements as necessary. 
            //We now have a sorted list of size 2, and N -2 unsorted elements. Repeat for all elements.
            
            for(int i = 1; i < array.Count(); i++)
            {
                int j;
                for(j = 0; j < i; j++)
                {
                    if (array[j] > array[i])
                        break;
                }

                if (j < i)
                {
                    //break executed, reordering is necessary.
                    int valueToInsert = array[i];
                    for (int k = i - 1; k >= j; k--)
                        array[k + 1] = array[k];
                    array[j] = valueToInsert;
                }
            }
        }
    }
}

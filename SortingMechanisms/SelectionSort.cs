using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    class SelectionSort : BaseAlgorithm
    {
        public SelectionSort(int[] array) : base(array)
        { }

        public override string Name
        {
            get { return "Selection sort"; }
        }

        public override void Sort()
        {
            //Scan all items and find the smallest.
            //Swap it into position as the first item.
            //Repeat the selection sort on the remaining n-1 items.
            for(int i = 0; i< array.Count() - 1; i++)
            {
                int indexWithMinValue = i;

                for (int j = i+1; j < array.Count(); j++)
                {
                    if (array[indexWithMinValue] > array[j])
                        indexWithMinValue = j;
                }

                if (indexWithMinValue != i)
                    Swap(i, indexWithMinValue);
            }
        }
    }        
}

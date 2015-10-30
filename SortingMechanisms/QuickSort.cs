using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class QuickSort : BaseAlgorithm
    {
        public QuickSort(int[] array) : base(array)
        { }

        public override string Name
        {
            get { return "Quick sort"; }
        }

        public override void Sort()
        {
            Sort(0, array.Count() - 1);
        }

        private void Sort(int startIndex, int lastIndex)
        {
            if(startIndex < lastIndex)
            {
                int pivotIndex = Partition(startIndex, lastIndex);
                Sort(startIndex, pivotIndex - 1);
                Sort(pivotIndex + 1, lastIndex);
            }
        }

        private int Partition(int startIndex, int lastIndex)
        {
            int pivotIndex = startIndex;
            int pivotValue = array[pivotIndex];
            int i = pivotIndex;
            for(int j = i + 1; j <= lastIndex; j++)
            {
                if(array[j] < pivotValue)
                {
                    //To prevent same item swapping for the first time.
                    //Does not make sense actually to be honest.
                    if(j != i + 1)
                        Swap(j, i + 1);
                    i++;
                }
            }

            Swap(pivotIndex, i);

            return i;
        }
    }
}

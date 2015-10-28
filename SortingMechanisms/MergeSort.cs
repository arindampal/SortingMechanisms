using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class MergeSort : BaseAlgorithm
    {
        public MergeSort(int[] array) : base(array)
        { }
        public override string Name
        {
            get { return "Merge sort"; }
        }

        public override void Sort()
        {
            SplitAndSort(0, array.Count() - 1);
        }

        private void SplitAndSort(int startIndex, int lastIndex)
        {
            if (startIndex == lastIndex)
                return;
            else if (lastIndex == (startIndex + 1))
            {
                if (array[startIndex] > array[lastIndex])
                    Swap(startIndex, lastIndex);
            }
            else
            {
                int middleIndex = (lastIndex + startIndex) / 2;
                SplitAndSort(startIndex, middleIndex);
                SplitAndSort(middleIndex + 1, lastIndex);
                Merge(startIndex, middleIndex, lastIndex);
            }
        }

        private void Merge(int startIndex, int middleIndex, int lastIndex)
        {
            for (int i = middleIndex + 1; i <= lastIndex; i++)
            {
                int j;
                for (j = startIndex; j < i; j++)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class HeapSort : BaseAlgorithm
    {
        public HeapSort(int[] array) : base(array)
        { }

        public override string Name
        {
            get { return "Heap sort"; }
        }

        public override void Sort()
        {
            Heapify(array.Count());

            int lastIndex = array.Count() - 1;

            while (lastIndex > 0)
            {
                Swap(0, lastIndex);
                lastIndex--;
                RestructureHeap(0, lastIndex);
            }
        }

        public void Heapify(int count)
        {
            //Find the index of the last parent node.
            int lastParentNodeIndex = (int)Math.Floor((double)((count - 2) / 2));

            while(lastParentNodeIndex >= 0)
            {
                RestructureHeap(lastParentNodeIndex, count - 1);
                
                //Go to previous parent node and repeat process in while loop.
                lastParentNodeIndex--;
            }
        }

        private void RestructureHeap(int parentIndex, int lastElementIndex)
        {
            int root = parentIndex;

            while(root*2 + 1 <= lastElementIndex)
            {
                int leftChildIndex = root * 2 + 1;
                int swapIndex = root;

                //Check if left child larger than parent. Raise flag if yes.
                if (array[leftChildIndex] > array[swapIndex])
                    swapIndex = leftChildIndex;

                //Check if right child is present and larger than higher of the parent and left child. Raise flag if yes.
                if (leftChildIndex + 1 <= lastElementIndex && array[swapIndex] < array[leftChildIndex + 1])
                    swapIndex = leftChildIndex + 1;

                if(swapIndex == root)
                {
                    //Root is highest hence valid, return.
                    return;
                }
                else
                {
                    Swap(root, swapIndex);
                    root = swapIndex; //Rpeat to continue shifting down the child now.
                }
            }
        }
    }
}

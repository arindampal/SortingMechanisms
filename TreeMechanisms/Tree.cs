using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeMechanisms
{
    public class Tree
    {
        private int[] array;
        public Tree(int[] array)
        {
            this.array = array;
        }        

        #region Private Methods

        private void PreOrder(int parentIndex)
        {
            int leftIndex = parentIndex * 2 + 1;
            int rightIndex = leftIndex + 1;
            Console.Write(array[parentIndex] + " ");
            if (leftIndex <= array.Count() - 1)
                PreOrder(leftIndex);
            if (rightIndex <= array.Count() - 1)
                PreOrder(rightIndex);
        }

        private void PostOrder(int parentIndex)
        {
            int leftIndex = parentIndex * 2 + 1;
            int rightIndex = leftIndex + 1;

            if (leftIndex <= array.Count() - 1)
                PostOrder(leftIndex);
            if (rightIndex <= array.Count() - 1)
                PostOrder(rightIndex);
            Console.Write(array[parentIndex] + " ");
        }

        private void InOrder(int parentIndex)
        {
            int leftIndex = parentIndex * 2 + 1;
            int rightIndex = leftIndex + 1;

            if (leftIndex <= array.Count() - 1)
                InOrder(leftIndex);
            Console.Write(array[parentIndex] + " ");
            if (rightIndex <= array.Count() - 1)
                InOrder(rightIndex);            
        }

        #endregion

        #region Public Methods

        public void FindMinimum()
        {

        }

        public void FindMaximum()
        {

        }

        public void PreOrder()
        {
            PreOrder(0);
        }

        public void PostOrder()
        {
            PostOrder(0);
        }

        public void InOrder()
        {
            InOrder(0);
        }

        #endregion

    }
}

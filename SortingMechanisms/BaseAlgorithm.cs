using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public abstract class BaseAlgorithm : ISortAlgorithm
    {
        protected int[] array;
        public BaseAlgorithm(int[] array)
        {
            this.array = array;
        }

        public abstract string Name { get; }

        public int[] Items
        {
            get { return array; }
        }

        public abstract void Sort();

        protected void Swap(int index1, int index2)
        {
            array[index1] += array[index2];
            array[index2] = array[index1] - array[index2];
            array[index1] = array[index1] - array[index2];
        }
    }
}

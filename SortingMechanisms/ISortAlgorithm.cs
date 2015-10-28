using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    interface ISortAlgorithm
    {
        void Sort();
        string Name { get; }

        int[] Items { get; }
    }
}

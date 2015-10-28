using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class DataGenerator
    {
        //Generates array of integers as requested.
        public static int[] GenerateData(int count, int maxLimit)
        {
            //Changing seed to arriv at different input values.
            Random random = new Random(DateTime.Now.Millisecond);
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = random.Next(0, maxLimit);

            return array;
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingMechanisms
{
    public class SleepSort : BaseAlgorithm
    {
        public SleepSort(int[] array) : base(array)
        {
            queue = new ConcurrentQueue<int>();
            tasks = new List<Task>();
        }

        ConcurrentQueue<int> queue;
        List<Task> tasks;

        public override string Name
        {
            get
            {
                return "Sleep sort";
            }
        }

        public override void Sort()
        {
            foreach (var value in array)
            {
                var task = Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(value * 1000);
                    queue.Enqueue(value);
                });                

                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());

            for (int i = 0; i < array.Count(); i++)
            {
                int result;
                if (queue.TryDequeue(out result))
                    array[i] = result;
            }
        }
    }
}

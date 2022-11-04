using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class MergeSort
    {
        public void Display()
        {
            List<int> unsorted = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> sorted;

            Random random = new Random();
            Console.WriteLine("Original array element");
            for(int i = 0; i <10; i++)
            {
                unsorted.Add(random.Next(0, 10));
                Console.WriteLine(unsorted[i] + " ");
            }
            Console.WriteLine();

            sorted = (unsorted);
            Console.WriteLine("sorted array element");
            foreach (int x in sorted)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine("\n");
            if (unsorted.Count < 1)
            {
                return;

                List<int> left = new List<int>();
                List<int> right = new List<int>();

                int middle = unsorted.Count / 2;
                for(int i=0; i<middle;i++)
                {
                    left.Add(unsorted[i]);
                }
                for (int i= middle; i<unsorted.Count;i++)
                {
                    right.Add(unsorted[i]);
                }
                left = (left);
                right = (right);
                return;
            }
            if(unsorted.Count <0)
            {
                Console.WriteLine("Array is Sorted");
            }
            else
            {
                Console.WriteLine("Array is not Sorted");
            }
            
        }
    }
}

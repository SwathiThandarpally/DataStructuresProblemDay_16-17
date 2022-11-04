using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class InsertSort
    {
        public void Display()
        {
            int[] arr = new int[5] { 8, 16, 24, 32, 40 };
            int n = 5, i, j, val, flag;

            Console.WriteLine("Insert sort ");
            Console.WriteLine("Initial Array is");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for (i=1;i<n;i++)
            {
                val = arr[i];
                flag = 0;
                for(j=i-1;j>=0&&flag!=1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            Console.WriteLine("After Aray is ");
            for (i=0;i<n;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class BinarySearch
    {
        public void Display()
        {
            List<string> list = new List<string>();
            list.Add("Bat");
            list.Add("Cat");
            list.Add("Dog");
            list.Add("Rat");
            list.Add("Song");

            Console.WriteLine("The origial list is ");
            foreach(string g in list)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("\n The List is sorted form");
            list.Sort();
            Console.WriteLine();
            foreach(string g in list)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("\nInsert Rabbit :");

            int index = list.BinarySearch("Rabbit");

            if (index < 0)
            {
                list.Insert(~index, "Rabbit");
            }
            Console.WriteLine();
            foreach(string g in list)
            {
                Console.WriteLine(g);
            }
            if(index > 0)
            {
                Console.WriteLine("Word is found");
            }
            else
            {
                Console.WriteLine("Word is not found");
            }
            
                
        }
    }
}

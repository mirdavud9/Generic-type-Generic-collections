using Generic_type__Generic_collections;
using System;

namespace CustomListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ListInt sinifinin testi:");
            ListInt listInt = new ListInt();
            listInt.Add(10);
            listInt.Add(20);
            listInt.Add(30);
            listInt.AddRange(40, 50, 60);
            Console.WriteLine("ListInt elementleri " + listInt);
            Console.WriteLine("Sum: " + listInt.Sum());
            Console.WriteLine("30 varmi? " + listInt.Contains(30));
            listInt.Remove(20);
            Console.WriteLine("eger 20 cixarilsa " + listInt);

            Console.WriteLine("CustomList<int> sinifinin testi");
            CustomList<int> customList = new CustomList<int>();
            customList.Add(100);
            customList.Add(200);
            customList.Add(300);
            customList.AddRange(400, 500);
            Console.WriteLine("CustomList elementleri " + customList);
            Console.WriteLine("Sum: " + customList.Sum());
            Console.WriteLine("Capacity: " + customList.Capacity);
            Console.WriteLine("Count: " + customList.Count);

        }
    }
}

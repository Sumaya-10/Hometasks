using System.Collections.Generic;

namespace Indexertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();

            list.Add(1);
            list.Add(2, 3, 4);
            Console.WriteLine(list.ToString()); 
            
            Console.WriteLine(list.ToString()); 
                Console.WriteLine(list.Contains(3)); 
            

            Console.WriteLine(list.Sum()); 
            

            int last = list.Pop();


            Console.WriteLine(last); 
            Console.WriteLine(list.ToString());
        }
    }
}

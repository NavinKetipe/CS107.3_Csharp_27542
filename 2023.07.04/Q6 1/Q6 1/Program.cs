using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayClass arrayObj = new ArrayClass();
            int[] array = arrayObj.arrayMethod(size);

            Console.WriteLine("\nDispaly the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            Console.ReadLine();
        }
    }
}
   
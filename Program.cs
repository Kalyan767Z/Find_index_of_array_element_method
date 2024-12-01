using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Find_index_of_array_element_method
{
    internal class Program
    {
        static int Findndex(int[] array, int element)
        {
            int result = -1;
            for (int i = 0;i<array.Length;i++)
            {
                if (array[i] == element)
                {
                    result = i;
                    break;
                }
                else continue;
            }
            return result;
        }      


        static void Main(string[] args)
        {
            Console.Write("Enter the number of array elements: ");
            uint.TryParse(Console.ReadLine() , out uint elementsCount);
            if (elementsCount < 1)
            {
                Console.WriteLine("\nImpossible array");
                return;
            }
            
            int[] myArray = new int[elementsCount];

            for (int i = 0; i < elementsCount; i++)
            {
                Console.Write("Enter element with an index " + i + ": ");

                if (!int.TryParse(Console.ReadLine(), out myArray[i]))
                {
                    Console.WriteLine("\nThe array cannot contain this value");
                    return;
                }
            }
            
            Console.Write("Enter the number whose index you want to find: ");

            if (!int.TryParse(Console.ReadLine(), out int elementCount))
            {
                Console.WriteLine("\nInvalid index");
                return;
            }

            else
            {
                if (elementCount >= 0 && elementCount <= myArray.Length)
                    Console.WriteLine("The number " + elementCount + " has index: " + Findndex(myArray, elementCount));

                else 
                    Console.WriteLine("\nInvalid index");
            }
        }
    }
}

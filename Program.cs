
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnParcticealgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5};
            printOddNumber();
            printandSum(array);        
            int  [] returnedArray = returnArray();
            printArray(array);




        }


        public static void printOddNumber()
        {

            // Check whether a given number is even or oddz

            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i+" is a odd number");
                }
                else
                {
                    Console.WriteLine(i + " is a even number");
                }
            }
            Console.ReadLine();
        }


        // Sum and Print 1-5 printing out the current number and sum so far at each step of the way
        public static void printandSum(int [] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];

                Console.WriteLine("Nume" + array[i] + ",Sum" + sum);
               
            }
            Console.ReadLine();
        }

        // function that returns an array with all numbers from 1 to 255
        public static int[]  returnArray()
        {

            int[] array = new int[255];
           // int[] array_2 = {2,3,6,8};

            for (int i = 0; i < array.Length; i++)
            {
               array[i] = i+1;
               // Console.WriteLine(array[i]);
                
            }
            return array;

           // Console.ReadLine();
        }

        public static void printArray(int [] array)
        {
            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }

           // Console.ReadLine();
        }
    }
}
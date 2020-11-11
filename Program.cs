
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
           
            char [] name ={'P','H','I','L','I','A','T','E','M','B','O'};


               // printOddNumber();
               //
               // printandSum(array);        
              //   int  [] returnedArray = returnArray();
               //  printArray(array);
                 // printNumber(array);
                 //manipulateName(name);
                // reverseArray(name);

              // int []newArray= reverseMidArrayLeft(array);
              // printArray(newArray);
                 int[] array = { 1,2,3,4,5,6,7,8,9,10};
               // int []newArray2= reverseMidArrayRight(array);
              // printArray(newArray2);
               //addFive(array);
               int [] k = AddFive(array);
               printArray(k);
              // AddFive(array);
                    

        }
        public static int [] AddFive(int [] two){
            for(int i =0; i<two.Length; i++){
               

                two[i] = two[i] + 5;

                
            }
          return two;
        }

        public static void addFive(int [] five){
             int [] newArray2 = new int [five.Length];
            int lo= 5;
            for(int i = 0; i<five.Length;i++){
               newArray2[i]= lo + five[i];
                Console.WriteLine(newArray2[i]);

            }
            Console.ReadLine();

        }
        
        public static int []reverseMidArrayRight(int [] P){

            int [] newArray2 = new int [P.Length];
            int index = 0;

            for(int i= P.Length/2; i>0; i--){
                newArray2[index]=P[i];
                index++;
            }
           for(int i=P.Length/2 + 1; i<P.Length; i++){
                newArray2[index]=P[i];
                index++;
            }

            return newArray2;
        }

       public static int[] reverseMidArrayLeft(int [] O){

            int [] newArray = new int [O.Length];
            int index = 0;

            for(int i= O.Length/2;i>=0; i--){
                newArray[index]= O[i];
                index++;
            }
            for(int i=O.Length/2 + 1; i< O.Length; i++){
                newArray[index]=O[i];
                index++;
            }
           return newArray;
        }

        public static char [] reverseArray(char [] S){
            char [] L = new char [S.Length];
            int index =0;
            for(int i=S.Length-1; i>=0; i--){
                L[index]= S[i];
                index++;
                
            }
            return L;
        }

        public static int manipulateName(char [] A){
            int count =0;

            for(int i=0; i<A.Length;i++){
                if(A[i]=='I'){
                    count++;
                }
            }
            return count;
        }

        public static void printNumber(int []  z){

                for(int i =1; i<z.Length; i++){
                    Console.WriteLine(z[i]);
                }
                Console.ReadLine();
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
            Console.Write("[");
            for (int i=0; i < array.Length; i++)
            {
                Console.Write(array[i]+",");


            }
            Console.Write("]");
            Console.ReadLine();
        }
    }
}
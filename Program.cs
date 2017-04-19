using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {66,12,16,88,99,4,23,73,14};
            
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", arr));

            //Printing array after pass
            Console.WriteLine("Sorted Array : " + String.Join(" ", InsertionSort(arr)));                   
        }

        static int[] InsertionSort(int[] arr) {
            int n = arr.Length;
            int passes=0;

            for(var i=1; i < n; i++){
                int j = i - 1;
                int temp = arr[i];

                while(j >= 0 && temp < arr[j])
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j+1] = temp;                
                passes ++;
            }

            Console.WriteLine("Passes to sort : " + passes);
            return arr;
        }
    }
}

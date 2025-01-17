//اول کل ارایه را معکوس میکنیم
//قسمت اول ارایه را معکوس میکنم
//قسمت دوم ارایه را معکوس میکنیم
//2- REVERSEARRAY:این متد بخشی از ارایه را در بازه مشخص شده معکوس میکند
//3- print array: ارایه را چاپ میکند تا بتوانیم نتیجه را مشاهده
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        int rotateBy = 2; // تعداد مکان‌هایی که آرایه باید بچرخد

        Console.WriteLine("Original Array: ");
        PrintArray(array);

        RotateArray(array, rotateBy);
     
        Console.WriteLine("Rotated Array: ");
        PrintArray(array);
    }

    static void RotateArray(int[] arr, int positions)
    {
        int length = arr.Length;
        positions = positions % length; // در صورت چرخش بیشتر از طول آرایه، باقی‌مانده را در نظر بگیر

        ReverseArray(arr, 0, length - 1);              // کل آرایه را معکوس کن
        ReverseArray(arr, 0, positions - 1);          // قسمت اول را معکوس کن
        ReverseArray(arr, positions, length - 1);     // قسمت دوم را معکوس کن
    }

    static void ReverseArray(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
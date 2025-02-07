// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static int sum(int a, int b)
    {
        return a + b;
    }

    static int listSum(int[] a, int b)
    {
        int temp = 0;
        for (int i = 0; i < a.Length; i++)
        {
            temp += a[i];

        }
        return temp;
    }

    static void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;

    }
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 0;
        int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // 1. 두 개의 int를 더한 값을 반환하는 add 함수를 만들고, a, b를 입력으로 사용하여 리턴값을 c에 저장
        c = sum(a,b);
        Console.WriteLine("1. Add: " + c);

        // 2. 배열과 개수를 입력받아 총합을 계산하여 리턴하는 sum 함수를 만들고 호출하여 c에 저장
        c = listSum(array1, array1.Length);
        Console.WriteLine("2. Sum: " + c);

        // 3. a, b 레퍼런스를 입력하여 값을 바꾸는 swap 함수를 만들어 a, b의 값을 바꾸기
        Swap(a,b);  

        Console.WriteLine("3. Swap: a = " + a + ", b = " + b);
    }

   

  
}
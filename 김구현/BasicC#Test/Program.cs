// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

class Program
{
    static int add(int[] aaa)
    {
        int sum = 0;

        for(int i = 0; i < aaa.Length;i++)
        {
            sum += aaa[i];
        }

        return sum;
    }
        static void Main()
    {
        int a = 8;
        int b = 2;
        int c = 0;
        int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum;

        add(array1);
        // 1. 두 개의 int를 더한 값을 반환하는 add 함수를 만들고, a, b를 입력으로 사용하여 리턴값을 c에 저장


        sum = add(array1);


        Console.WriteLine("1. Add: " + c);

        // 2. 배열과 개수를 입력받아 총합을 계산하여 리턴하는 sum 함수를 만들고 호출하여 c에 저장
       
        Console.WriteLine("2. Sum: " + c);

        // 3. a, b 레퍼런스를 입력하여 값을 바꾸는 swap 함수를 만들어 a, b의 값을 바꾸기
        

        Console.WriteLine("3. Swap: a = " + a + ", b = " + b);
    }

  
}
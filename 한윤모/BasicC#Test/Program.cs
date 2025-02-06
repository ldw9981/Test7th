// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

class Program
{
    static int add(int x, int y)
    {
        return x + y;
    }
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 0;
        int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // 1. 두 개의 int를 더한 값을 반환하는 add 함수를 만들고, a, b를 입력으로 사용하여 리턴값을 c에 저장

        c = add(a, b);
        Console.WriteLine("1. Add: " + c);

        /*
        // 2. 배열과 개수를 입력받아 총합을 계산하여 리턴하는 sum 함수를 만들고 호출하여 c에 저장
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < input.Length; i++)
        {
            try
            {
                //sum = int.Parse(input[i]);
            }
            catch (FormatException)
            {
                Console.WriteLine("숫자를 입력");
            }
        }*/
       
        //nsole.WriteLine("2. Sum: " + sum);

        // 3. a, b 레퍼런스를 입력하여 값을 바꾸는 swap 함수를 만들어 a, b의 값을 바꾸기
        

        Console.WriteLine("3. Swap: a = " + a + ", b = " + b);
    }

  
}
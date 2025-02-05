﻿// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 0;
        int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        // 1. 두 개의 int를 더한 값을 반환하는 add 함수를 만들고, a, b를 입력으로 사용하여 리턴값을 c에 저장
        
        Console.WriteLine("1. Add: " + c);

        // 2. 배열과 개수를 입력받아 총합을 계산하여 리턴하는 sum 함수를 만들고 호출하여 c에 저장

        Sum(array1, ref c);
        Console.WriteLine("2. Sum: " + c);

        // 3. a, b 레퍼런스를 입력하여 값을 바꾸는 swap 함수를 만들어 a, b의 값을 바꾸기
        
        Swap(ref a, ref b);
        Console.WriteLine("3. Swap: a = " + a + ", b = " + b);
    }
    
    static public int Sum(int[] array, ref int c)
    {
        c = 0;

        foreach (int i in array)
        {
            c += i;
        }

        return c;
    }

    static public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

}
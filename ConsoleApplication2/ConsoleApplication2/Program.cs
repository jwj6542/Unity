using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ GenPyramid(5); }
            //for(int i=0; i<9; i++)
            //{
            //    Console.WriteLine("i: {0}", i);
            //}

            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine("i : {0}", i);
            //}
            //int num = 0;
            //while (num < 9)
            //{
            //    Console.WriteLine("num1:{0},num2:{1}" ,num+1,num + 2);
            //    num++;
            //}
            //int num = 0;
            //do
            //{
            //    Console.WriteLine("num:{0}", num++);
            //} while (num < 5);

            //int[] array = { 0, 1, 2, 3, 4 };
            //foreach(int a in array)
            //{
            //    Console.WriteLine(a);
            //}

            //for(int i = 0; i<=2; i++)
            //{
            //    for(int k=0; k<5; k++)
            //    {
            //        Console.WriteLine("i+k : {0}", i + k);
            //    }
            //for(int i = 0; i<5;  i++)
            // {
            //     if(i == 3)
            //     {
            //         //Console.WriteLine("탈출 i: {0}",i);
            //         break;
            //     }
            //     Console.WriteLine(i);
            // }

            //int a = 0;
            //while (true) {
            //    Console.WriteLine("a:{0}", a);
            //    if (a == 10) break;
            //    a++;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        Console.WriteLine("수업끝");
            //        break;
            //    }
            //    for(int j=0; j<5; j++)
            //    {
            //        Console.WriteLine("i+j ={0}", i + j);
            //    }
            //    Console.WriteLine("");

            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3) continue;
            //    Console.WriteLine(i);
            //}
            //반복문을 활용해 100개의 난수 (1~100)발생시켜 ,홀수 ,짝수로 구분해서 카운트후 출력
            //    int count = 0;
            //    Random rand = new Random();
            //    for (int i = 0; i < 100; i++)
            //    {
            //        int num = rand.Next(0, 100);
            //        Console.WriteLine("num: {0}", num);
            //        if ((num+ 1) % 2 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("홀수: {0},짝수: {0}", (100 - count), count);
            //*
            //**
            //***
            //****
            //*****

            //for(int i =0; i<5; i++)
            //{
            //    for(int j=0; j<i+1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}  


            //for(int i =5; i>0; i--)
            //  {
            //      for(int j=0; j<i+1; j++)
            //      {
            //          Console.Write("*");
            //      }
            //      Console.WriteLine("");
            //  }  

            //     private static void GenPyramid(int n) 피라미드로 점찍기
            //{
            //    for (int i = 0; i < n; i++) 
            //    {
            //        for (int j = n - i - 1; j > 0; j--) 
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int k = 0; k < (2 * i) + 1; k++) 
            //        {
            //        }
            //            Console.Write("*");
            //        Console.WriteLine();

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j + 1 >= i) Console.Write("*");
            //        else Console.Write(" ");                                        
            //    }
            //    Console.WriteLine("");
            //}
            //for(int i=0; i<5; j++)
            //{
            //    for(int j=0; j<5; j++)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //            {
            //                else Console.Write(" ");
            //            }
            //        }
            //    }
            //}
            //배열
            //int[] num1 = new int[] { 5, 2, 5, 6, 1, 5, 14, 1 };
            //for(int i =0; i < num1.Length; i++)
            //{
            //    Console.WriteLine("num1 : {0}", num1[i]);
            //}
            //Console.WriteLine("");
            //num1[2] = 10;
            //for (int i = 0; i < num1.Length; i++)
            //{
            //    Console.WriteLine("num1 : {0}", num1[i]);
            //}
            //string[] week = new string[] { "Sun", "Moon", "Tue", "Wed", "Thr", "Fri", "Sat" };
            //foreach(String i in week)
            //{
            //    Console.WriteLine(i);
            //}
            // int[] num5 = new int[] { 5, 1, 3, 0, 1, 4, 65, 7, 87, 34 };
            //foreach (int i in num5)
            //{
            //    Console.WriteLine("정렬후 :{0}", i);
            //}
            //for (int i=0; i<num5.Length; i++)
            //{
            //    for (int j = i + 1; j < num5.Length; j++)
            //    {
            //        if (num5[i] < num5[j])
            //        {
            //            int temp = num5[i];
            //            num5[i] = num5[j];
            //            num5[j] = temp;
            //        }

            //    }
            //}
            //Console.WriteLine("");
            //foreach(int i in num5)
            //{
            //    Console.WriteLine("정렬후 :{0}", i);
            //}

            //Console.WriteLine("");
            //System.Array.Sort(num5);
            //foreach (int i in num5)
            //{
            //    Console.WriteLine("정렬후 : {0}", i);
            //}
            //System.Array.Reverse(num5);
            //foreach(int i in num5)
            //{
            //    Console.WriteLine("정렬후 :{0}", i);
            //int[,] num = new int[3, 4] { { 1, 9, 8, 5 }, { 10, 4, 7, 0 }, { 11, 3, 6, 2 } };
            //for(int i=0; i<3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("num[{0},{1}]:{2}", i, j, num[i,j]);
            //    }
            //}
            //2차원 숫자 정렬
            //int[,] arr = new int[5, 5];
            //int index = 0;
            //for (int i =0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arr[i, j] = index + 1;
            //        index++;
            //        Console.Write("{0}\t", arr[i, j]);
                    
            //    }
            //    Console.WriteLine("");
            //}
            for(int i=0; i<25; i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine("");
                }
                arr[i / 5, i % 5] = i + 1;
                Console.Write("{0}\t", arr[i / 5, i % 5]);
            }
        }
    }
}




                          
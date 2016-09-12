using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 13;
            int q = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int n = 1000000, i, j;
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                a[i] = 1;
            }
            for (i = 2; i < n; i++)
            {


                if (a[i] == 1)
                {
                    for (j = i; j < n; j += i)
                    {
                        a[j] = 0;
                    }
                    a[i] = 1;

                    if (100 < i && i < 1000)
                    { a2++; }
                    else if (1000 <= i && i < 10000)
                    { a3++; }
                    else if (10000 <= i && i < 100000)
                    { a4++; }
                    else if (100000 <= i && i < 1000000)
                    { a5++; }


                }
            }
            int h = 0;
            int[] arr2 = new int[a2];
            int[] arr3 = new int[a3];
            int[] arr4 = new int[a4];
            int[] arr5 = new int[a5];
            for (i = 100; i < 1000; i++)
            {
                if (a[i] == 1)
                {
                    arr2[h] = i;
                    h++;
                }
            }
            h = 0;
            for (i = 1000; i < 10000; i++)
            {
                if (a[i] == 1)
                {
                    arr3[h] = i;
                    h++;
                }
            }
            h = 0;
            for (i = 10000; i < 100000; i++)
            {
                if (a[i] == 1)
                {
                    arr4[h] = i;
                    h++;
                }
            }
            h = 0;
            for (i = 100000; i < 1000000; i++)
            {
                if (a[i] == 1)
                {
                    arr5[h] = i;
                    h++;
                }
            }
            for (int s = 0; s < a2; s++)
            {
                int b = 0; int c = 0;
                for (h = 0; h < a2 - 1; h++)
                {


                    if (arr2[s] == (arr2[h + 1] % 100) * 10 + arr2[h + 1] / 100)
                    { b = arr2[h + 1]; }
                }

                for (h = 0; h < a2 - 1; h++)

                { if (arr2[s] == (arr2[h + 1] % 10) * 100 + arr2[h + 1] / 10)
                    { c = arr2[h + 1]; }

                }
                if (b != 0 && c != 0)
                {
                    q++;
                   //  Console.WriteLine("{0},{1},{2}", arr2[s], b, c);
                }

            }
            f = f + q ;
           // Console.WriteLine(f);
            q = 0;
            for (int s = 0; s < a3; s++)
            {
                int b = 0; int c = 0; int d = 0;
                for (h = 0; h < a3 - 1; h++)
                {


                    if (arr3[s] == (arr3[h + 1] % 1000) * 10 + arr3[h + 1] / 1000)
                    { b = arr3[h + 1]; break; }
                }
                for (h = 0; h < a3 - 1; h++)
                {


                    if (arr3[s] == (arr3[h + 1] % 100) * 100 + arr3[h + 1] / 100)
                    { c = arr3[h + 1]; break; }
                }
                for (h = 0; h < a3 - 1; h++)

                {
                    if (arr3[s] == (arr3[h + 1] % 10) * 1000 + arr3[h + 1] / 10)
                    { d = arr3[h + 1]; break; }

                }
                if (b != 0 && c != 0 &&  d != 0)
                {
                    q++;
                   // Console.WriteLine("{0},{1},{2},{3}", arr3[s], b, c, d);
                }

            }
            f = f + q ;
           // Console.WriteLine(f);
            q = 0;
            for (int s = 0; s < a4; s++)
            {
                int b = 0; int c = 0; int d = 0; int m = 0;
                for (h = 0; h < a4 - 1; h++)
                {


                    if (arr4[s] == (arr4[h + 1] % 10000) * 10 + arr4[h + 1] / 10000)
                    { b = arr4[h + 1]; break; }
                }
                for (h = 0; h < a4 - 1; h++)
                {


                    if (arr4[s] == (arr4[h + 1] % 1000) * 100 + arr4[h + 1] / 1000)
                    { c = arr4[h + 1]; break; }
                }
                for (h = 0; h < a4 - 1; h++)

                {
                    if (arr4[s] == (arr4[h + 1] % 100) * 1000 + arr4[h + 1] / 100)
                    { d = arr4[h + 1]; break; }

                }
                for (h = 0; h < a4 - 1; h++)

                {
                    if (arr4[s] == (arr4[h + 1] % 10) * 10000 + arr4[h + 1] / 10)
                    {m = arr4[h + 1]; break; }

                }
                if (b != 0 && c != 0 && d != 0&& m!=0)
                {
                    q++;
                   // Console.WriteLine("{0},{1},{2},{3}", arr4[s], b, c, d,m);
                }

            }
            f = f + q;
           // Console.WriteLine(f);
            q = 0;
            for (int s = 0; s < a5; s++)
            {
                int b = 0; int c = 0; int d = 0; int m = 0; int p = 0;
                for (h = 0; h < a5 - 1; h++)
                {


                    if (arr5[s] == (arr5[h + 1] % 100000) * 10 + arr5[h + 1] / 100000)
                    { b = arr5[h + 1]; break; }
                }
                for (h = 0; h < a5 - 1; h++)
                {


                    if (arr5[s] == (arr5[h + 1] % 10000) * 100 + arr5[h + 1] / 10000)
                    { c = arr5[h + 1]; break; }
                }
                for (h = 0; h < a5 - 1; h++)

                {
                    if (arr5[s] == (arr5[h + 1] % 1000) * 1000 + arr5[h + 1] / 1000)
                    { d = arr5[h + 1]; break; }

                }
                for (h = 0; h < a5 - 1; h++)

                {
                    if (arr5[s] == (arr5[h + 1] % 100) * 10000 + arr5[h + 1] / 100)
                    { m = arr5[h + 1]; break; }

                }
                for (h = 0; h < a5 - 1; h++)

                {
                    if (arr5[s] == (arr5[h + 1] % 10) * 100000 + arr5[h + 1] / 10)
                    { p = arr5[h + 1]; break; }

                }
                if (b != 0 && c != 0 && d != 0 && m!=0 && p!=0)
                {
                    q++;
                    //Console.WriteLine("{0},{1},{2},{3},{4},{5}", arr5[s], b, c, d,m,p);
                }

            }
            f = f + q ;
            Console.WriteLine("Количество круговых простых чисел до 1000000={0}",f);
        
        }
    }
}

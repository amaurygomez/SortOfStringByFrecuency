using System;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;


namespace SortOfStringFrecuency
{
    public class SortStringByFrequency
    {
        public string[] SortByStringByFrequency(string[] str, int size)
        {
            string[] newStr = new string[size];
            for (int i = 0; i < size; i++)
            {
                int[] f = new int[str[i].Length];
                char[] strt = str[i].ToCharArray();
                for (int y = 0; y < strt.Length; y++)
                {
                    f[y] = countFrequency(strt, strt[y]);
                }
                newStr[i] = sortArray(strt, f);
                Console.WriteLine(sortArray(strt, f));
            }
            return newStr;
        }

        public static int countFrequency(char[] a, char b)
        {
            var count = 0;
            foreach (char i in a)
            {
                if (i == b)
                {
                    count++;
                }
            }
            return count;
        }
        public static String sortArray(char[] a, int[] b)
        {
            var t = 0;
            char c;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (b[j] < b[j + 1])
                    {
                        t = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = t;
                        c = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = c;
                    }
                }
            }
            Console.WriteLine(string.Join("", b));
            return string.Join("", a);
        }

        //bool isValid(String str)
        //{
        //    return Regex.IsMatch(str, @"^[a-zA-Z]+$");
        //}
    }
}

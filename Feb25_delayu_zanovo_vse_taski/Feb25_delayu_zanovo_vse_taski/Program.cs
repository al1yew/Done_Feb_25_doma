using System;

namespace Feb25_delayu_zanovo_vse_taski
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FindCharIndex
            //Console.WriteLine("Salam soz daxil edin:");
            //string word = Console.ReadLine();
            //Console.WriteLine("herf daxil edin:");
            //string inputletter = Console.ReadLine();
            //char letter = char.Parse(inputletter);
            //Console.WriteLine(FindCharIndex(word, letter));
            #endregion

            #region IsPrime
            //Console.WriteLine("Salam\nRegem daxil edin, biz size\nsade ve ya murekkeb oldugunu deyek:\nFalse Murekkebdir, True Sadedir");

            //string a = Console.ReadLine();
            //int input = int.Parse(a);
            //Console.WriteLine(IsPrime(input));

            #endregion

            #region CalcAvg

            //int[] array = new int[4];
            //Console.WriteLine("Salam");
            //int i = 0;

            //while (i < 4)
            //{
            //    Console.WriteLine("Regem daxil edin:");
            //    string str = Console.ReadLine();
            //    int num = int.Parse(str);
            //    Array.Resize(ref array, 4);
            //    array[i] = num;
            //    i++;    
            //}
            //Console.WriteLine(CalcAvg(array));
            #endregion
        }

        #region FindCharIndexMetod
        //static int FindCharIndex(string a, char b)
        //{
        //    foreach (char item in a)
        //    {
        //        if (item == b)
        //        {
        //            return 0;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region IsPrime
        //static bool IsPrime(int a) 
        //{
        //    for (int i = 2; i < a; i++)
        //    {
        //        if (a % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion

        #region CalcAvg
        //static string CalcAvg(int[] arr) 
        //{
        //    int count = 0;

        //    for (int j = 0; j < arr.Length; j++)
        //    {
        //        count += arr[j];
        //    }
        //    Console.WriteLine($"Ballariniz cemi {count}-dir\nOrtalamasi ise {count/4}.\nAshagidaki xanada melumat gelecek:");
        //    if (count/4 > 60)
        //    {
        //        return "Mezun olduz.";
        //    }
        //    return "Mezun olmadiz.";
        //}
        #endregion
    }
}

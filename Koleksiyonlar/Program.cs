using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin","murat ","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //string[] isimler2 = new string[5];
            //isimler2 = isimler;
            //isimler2[4] = "engin";
            //for (int i = 0; i < isimler2.Length-1 ; i++)
            //{
            //    isimler2[i] = isimler[i];
            //    Console.WriteLine(isimler2[i]);
            //}
            List<string> isimlerr = new List<string>() { "engin", "murat ", "Kerem", "Halil" };
            isimlerr.Add("Selim");

            for (int i = 0; i < isimlerr.Count; i++)
            {
                Console.WriteLine(isimlerr[i]);
            }
        }
    }
}

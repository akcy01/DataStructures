using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class Program
    {
        static void Main(string[] args) 
        {
            int[] sayilar = new int[] { 1, 2, 3, 4, 5 }; //Bu şekilde de dizi oluşturabiliyoruz

            var numbers = Array.CreateInstance(typeof(int), 5);//Bu şekilde de dizi oluşturabiliyoruz.
            numbers.SetValue(5, 0);
            numbers.SetValue(6, 1);
            numbers.SetValue(7, 2);
            numbers.SetValue(8, 3); 
            numbers.SetValue(9, 4);

            var arr = new ArrayList(); //Bu şekilde de dizi oluşturabiliyoruz.


            /* Bir çok array metodu var.Google'dan aratıp bulabilirsin çok fazla metod var. */
            Array.Sort(sayilar);
            arr.Add(13);

        }
    }
}

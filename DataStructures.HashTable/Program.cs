using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Table hTable = new Table(5);

            hTable.Add(0, "Ahmet");
            hTable.Add(10, "Mehmet");
            hTable.Add(15, "Hasan");
            hTable.Add(3, "Hüseyin");

            /* 4.Görselde neyin nereye eklendiğini belirtmeye çalıştım. Mod'u 0 olanlar aynı dizi indexine zincir şeklinde ekleniyor. 3 ise index numarası 3 olan indexe ekleniyor.! Yani Hüseyin modu 3 olduğu için index numarası 3 olan kısma ekleniyor ! */
        }
    }
}

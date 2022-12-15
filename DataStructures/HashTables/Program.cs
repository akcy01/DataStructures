using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTables
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* HashTable tanımlama */
            var sehirler = new Hashtable();

            /* Ekleme Yapma */
            sehirler.Add(31, "Hatay");
            sehirler.Add(1, "Adana");
            sehirler.Add(34, "İstanbul");

            foreach (DictionaryEntry item in sehirler) //DictionaryEntry sayesinde içlerindeki key ve value'lere erişebildik
            {
                Console.WriteLine(item);
            }

            /* Elemana Erişme */
            Console.WriteLine(sehirler[34]);

            /* Eleman Silme */
            sehirler.Remove(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Tanımlama */
            var cities = new LinkedList<string>();
            cities.AddFirst("New York");
            cities.AddFirst("Toronto");
            cities.AddLast("Bakü");

            /* Ekleme */
            cities.AddAfter(cities.Find("Toronto"), "Ordu"); //Torontonun olduğu düğümü bulacak sonrasına Orduyu ekleyecek
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dictionary
{
    public class Program
    {
        static void Main(string[] args) 
        {
            /* Tanımlama ve Ekleme */
            var telefonKodlari = new Dictionary<int, string>()
              {
                  {332,"Konya" },
                  {342,"Hatay" },
                  {715,"İstanbul"}
              };
            telefonKodlari.Add(153, "Artvin"); //Böyle de ekleme yapabiliyoruz.
        }
    }
}

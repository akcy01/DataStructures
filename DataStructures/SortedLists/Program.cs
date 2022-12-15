using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Tanımlama ve Eleman Ekleme */
            var list = new SortedList()
            {
                {1 ,"Oğuz"},
                {2 ,"Kemal"},
                {5,"Beyza" },
                {3, "Lale" },
                {9,"Ayşe" }
            }; //Sıralı halde vermesek de otomatikmen key'e göre sıralayacaktır makine.
        }
    }
}

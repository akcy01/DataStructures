using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Tanımlama */
            var characterQueue = new Queue<int>();

            /* Ekleme */
            characterQueue.Enqueue(1);
            characterQueue.Enqueue(2);

            /* Çıkarma */
            characterQueue.Dequeue(); //İlk 1 çıkacak çünkü ilk 1 girdi.
        }
    }
}

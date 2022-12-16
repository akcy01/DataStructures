using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Tanımlama */
            var characterStack = new Stack<char>();

            /* Ekleme */
            characterStack.Push('A');
            characterStack.Push('B'); //C en yukardaki değer olacak 
            characterStack.Push('C'); 

            /* Çıkarma */
            characterStack.Pop(); //İlk olarak C çıkarılacak çünkü en yukardaki C
        }
    }
}

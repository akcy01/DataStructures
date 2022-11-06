using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructures.LinkedList.SinglyLinkedList.Node;

namespace DataStructures.LinkedList.SinglyLinkedList.Add
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Liste list = new Liste();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);

            list.Append(5);
            list.Append(9);

            list.InsertAfter(3, 19);

            list.Print();


        }    
    }
}

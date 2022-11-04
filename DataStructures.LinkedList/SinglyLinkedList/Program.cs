using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructures.LinkedList.SinglyLinkedList.Node;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            /* Temelde LinkedList yapısı bu şekilde oluşturulur. */
            Node one = new Node(1);
            Node second = new Node(15);
            Node third = new Node(13);

            one.next = second;
            second.next = third;

            Console.WriteLine(one.data);
            Console.WriteLine(second.data);
            Console.WriteLine(third.data);

         
        }    
   
    }
}

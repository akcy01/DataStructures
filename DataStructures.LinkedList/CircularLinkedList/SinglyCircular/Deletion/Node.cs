using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using DataStructures.LinkedList;
using DataStructures.LinkedList.CircularLinkedList;
using DataStructures.LinkedList.CircularLinkedList.SinglyCircular;
using DataStructures.LinkedList.CircularLinkedList.SinglyCircular.Add;

namespace DataStructures.LinkedList.CircularLinkedList.SinglyCircular.Deletion
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

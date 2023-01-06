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
    public class List
    {
        Node head;
        Node tail;
        public List()
        {
            head = null;
            tail = null;
        }
        public void Push(int data)
        {
            Node eleman = new Node(data);
            if(head == null)
            {
                head = tail = eleman;
                tail.next = head;
                Console.WriteLine("Liste oluşturuldu ilk eleman eklendi");
            }
            else
            {
                eleman.next = head;
                head = eleman;
                tail.next = head;
                Console.WriteLine("Başa eleman eklendi");
            }

        }
        public void Append(int data)
        {
            Node eleman = new Node(data);
            if (head == null)
            {
                head = tail = eleman;
                tail.next = head;
                Console.WriteLine("Liste oluşturuldu ilk eleman eklendi");
            }
            else
            {
                tail.next = eleman;
                tail = eleman;
                tail.next = head;
                Console.WriteLine("Sona eleman eklendi");
            }

        }
    }
}

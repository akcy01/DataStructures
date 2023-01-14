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
        public void DeleteBeginning()
        {
            if(head == null)
            {
                Console.WriteLine("Liste BOŞ");
            }
            else if(head.next == head)
            {
                head = tail = null;
                Console.WriteLine("Liste boşaldı");
            }
            else
            {
                head = head.next;
                tail.next = head;
                Console.WriteLine("Baştan eleman silindi");
            }
        }
        public void DeleteEnd()
        {
            if (head == null)
            {
                Console.WriteLine("Liste BOŞ");
            }
            else if (head.next == head)
            {
                head = tail = null;
                Console.WriteLine("Liste boşaldı");
            }
            else
            {
                Node temp = head;
                while(temp.next != tail) 
                {
                    temp = temp.next;
                }
                temp.next = null;
                tail = temp;
                temp.next = head;
                Console.WriteLine("Sondan eleman silindi");
            }
        }
    }
}

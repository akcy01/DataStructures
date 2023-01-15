using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.CircularLinkedList.DoublyCircular.Add
{
    public class List
    {
        Node head;
        Node tail;
        public List()
        {
            this.head = null;
            this.tail = null;
        }
        public void Push(int data) /* Başa ekleme */
        {
            Node eleman = new Node(data);

            if(head== null)
            {
                head = tail = eleman;

                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
                Console.WriteLine("Liste yapısı oluşturuldu, ilk eleman eklendi.");
            }
            else
            {
                eleman.next = head;
                head.prev = eleman;
                head = eleman;
                head.prev = tail;
                tail.next = head;
                Console.WriteLine("Başa eleman eklendi.");
            }
        }
        public void Append(int data) /* Sona ekleme */
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = tail = eleman;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
                Console.WriteLine("Liste yapısı oluşturuldu, ilk eleman eklendi.");
            }
            else
            {
                tail.next = eleman;
                eleman.prev = tail;
                tail = eleman;
                tail.next = head;
                head.prev = tail;
                Console.WriteLine("Sona eleman eklendi");
            }
        }
    }
}

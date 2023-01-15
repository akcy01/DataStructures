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
        public void AddMiddle(int index,int data) /* Araya ekleme */
        {
            Node eleman = new Node(data);

            if (head == null && index == 0)
            {
                head = tail = eleman;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
                Console.WriteLine("Liste yapısı oluşturuldu, ilk eleman eklendi.");
            }
            else if(head != null && index == 0)
            {
                Push(data);
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp != tail)
                {
                    if(i == index)
                    {
                        temp2.next = eleman;
                        eleman.prev = temp2;
                        eleman.next = temp;
                        temp.prev = eleman;
                        Console.WriteLine("Araya eleman eklendi");
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == index)
                {
                    temp2.next = eleman;
                    eleman.prev = temp2;
                    eleman.next = temp;
                    temp.prev = eleman;
                    Console.WriteLine("Araya eleman eklendi");
                }
            }
        }
    }
}

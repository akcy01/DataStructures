using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DoublyLinkedList.Deletion
{
    public class Liste
    {
        Node head;
        Node tail;
        public Liste()
        {
            head = null; 
            tail = null;
        }
        public void Push(int data) /* Başa ekleme */
        {
            Node eleman = new Node(data);

            if(head== null)
            {
                head = tail= eleman;
                Console.WriteLine("Liste oluşturuldu.İlk eleman eklendi");
            }
            else
            {
                eleman.next = head;
                head.prev= eleman;
                head = eleman;
                Console.WriteLine("Listenin başına eleman eklendi");
            }
        }
        public void Append(int data) /* Sona ekleme */
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = tail = eleman;
                Console.WriteLine("Liste oluşturuldu.İlk eleman eklendi");
            }
            else
            {
                tail.next = eleman;
                eleman.prev = tail;
                tail = eleman;
                Console.WriteLine("Listenin sonuna eleman eklendi");
            }
        }
        public void DeleteBeginning()
        {
            if(head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else if (head.next==null)
            {
                head = tail = null;
                Console.WriteLine("Listede kalan son düğüm de silindi.");
            }
            else
            {
                head = head.next;
                head.prev = null;
                Console.WriteLine("Baştan eleman silindi");
            }
        }
        public void DeleteEnd()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else if (head.next == null)
            {
                head = tail = null;
                Console.WriteLine("Listede kalan son düğüm de silindi.");
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
                Console.WriteLine("Sondan eleman silindi");
            }
        }
        public void DeleteMiddle(int index)
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else if (head.next == null && index == 0)
            {
                head = tail = null;
                Console.WriteLine("Listede kalan son düğüm de silindi.");
            }
            else if (head.next != null && index == 0)
            {
                DeleteBeginning();
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp.next != null) 
                {
                    if(i == index)
                    {
                        temp2.next = temp.next;
                        temp.next.prev = temp2;
                        Console.WriteLine("Aradan düğüm silindi");
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if(i == index)
                {
                    DeleteEnd();
                }
            }
        }
    }
}

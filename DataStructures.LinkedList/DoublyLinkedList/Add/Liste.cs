using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DoublyLinkedList.Add
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
        public void AddMiddle(int data,int index) /* Araya ekleme */
        {
            Node eleman = new Node(data);

            if (head == null && index == 0)
            {
                head = tail = eleman;
                Console.WriteLine("Liste oluşturuldu.İlk eleman eklendi");
            }
            else if(head !=null && index == 0)
            {
               Push(data);
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {

                }

                Console.WriteLine("Araya eleman eklendi.");
            }
        }
    }
}

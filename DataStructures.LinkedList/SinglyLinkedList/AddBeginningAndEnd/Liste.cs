using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList.AddBeginningAndEnd
{
    public class Liste
    {
        Node head;
        public Liste()
        {
            head = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);

            if(head == null) //Head boş ise direkt başa eleman ekleme işlemi gerçekleştiriyoruz.
            {
                head = newNode;
                Console.WriteLine("Liste oluşturuldu ve ilk düğüm eklendi.");
            }
            else
            {
               newNode.next = head; // Head'ımızı bir ileri kaydırdık ve yeni düğümü başa aldık.
               head = newNode;     //Baş elemanın yeni düğümümüz olduğunu burada belirttik.  
               Console.WriteLine("Başa eleman eklendi.");
            }
        }
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                Console.WriteLine("List oluşturuldu ilk düğüm eklendi.");
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;//While'dan çıktığında son düğümde olacak.Son düğümün next'ini newNode yaparak son düğümü newNode yapmış olduk.
                Console.WriteLine("Sona eleman eklendi.");
            }
        }
        public void Print()
        {
            Node temp = head;
            if(head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                while(temp.next != null) //temp son düğüme gelene kadar çalışsın dedik burada.
                {
                    Console.Write(temp.data + " => ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data + " Son ");
            }
        }
    }
}

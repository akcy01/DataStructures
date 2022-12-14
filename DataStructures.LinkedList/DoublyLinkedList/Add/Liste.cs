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
            bool sonuc = false;
            Node eleman = new Node(data);

            if (head == null && index == 0)
            {
                sonuc = true;
                head = tail = eleman;
                Console.WriteLine("Liste oluşturuldu.İlk eleman eklendi");
            }
            else if(head !=null && index == 0)
            {
                sonuc = true;
                Push(data);
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while(temp.next != null)
                {
                    if(i == index)
                    {
                        sonuc = true;
                        temp2.next = eleman;
                        eleman.prev = temp2;

                        eleman.next = temp;
                        temp.prev = eleman;
                        Console.WriteLine("Araya ekleme yapıldı");
                        i++;
                        break;
                    }
                }
                if (i == index) /* Kullanıcı son düğüme ekleme yapmak istediğinde.While'dan çıktığında son düğümde olacak.*/
                {
                    sonuc = true;
                    temp2.next = eleman;
                    eleman.prev = temp2;

                    eleman.next = tail;
                    tail.prev = eleman;
                    Console.WriteLine("Araya eleman eklendi.");
                }
            }
            if(sonuc == false) /* Validasyon işlemi */
            {
                Console.WriteLine("Hatalı index seçimi yaptınız.");
            }
        }
    }
}

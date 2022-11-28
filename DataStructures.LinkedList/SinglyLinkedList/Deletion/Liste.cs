using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList.Deletion
{
    public class Liste
    {
        Node head;
        public Liste()
        {
            head = null;
        }
        public void Push(int data) /* Başa ekleme */
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
        public void InsertAfter(int index,int data)//Bir index alıyoruz çünkü düğümü belirtilen indexe ekleyeceğiz.
        {
            Node newNode = new Node(data);
            if(head == null && index == 0)
            {
                head = newNode;
            }
            else if( head != null && index == 0)//0.index'e de eleman eklemek isteyebilir.
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                int i = 0; //İki adet temp'e ihtiyacımız var.Çünkü bir tanesi eklenecek indisin solundaki değeri diğeri de sağındaki değeri tutacak
                Node temp = head; 
                Node temp2 = temp;
                while(temp.next != null)
                {
                    if(i == index)
                    {
                        temp2.next = newNode;
                        newNode.next = temp;
                        Console.WriteLine("Araya eleman eklendi");
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if(i == index) // Diyelim ki son index'e ekleme yapılmak istendi.While döngüsünde i son index'e gelmiş olacak zaten.While'dan çıkınca bu if'e girecek ve son düğüme ekleme yapacak.
                {
                    temp2.next = newNode;
                    newNode.next = temp;
                    Console.WriteLine("Araya eleman eklendi");
                }
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
        public void DeleteBeginning()
        {
            if(head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                head = head.next; //Baştaki head otomatikmen silinecek ve Next'e geçecek.
                Console.WriteLine("Baştan eleman silindi");
            }
        }
    }
}

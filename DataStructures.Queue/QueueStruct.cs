using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class QueueStruct
    {
        Node front; //Kuyruğun başı
        Node rear; //Kuyruğun sonu
        public QueueStruct()
        {
            this.front = null;
            this.rear = null;
        }
        public void Enqueue(int data) //Eleman ekleme
        {
            Node eleman = new Node(data);
            if(front == null) /* Eğer queue yapısı boşsa diye kontrol ettik */
            {
                front = rear = eleman;
            }
            else //Eklemeyi sondan yapıyoruz
            {
                rear.next = eleman;
                rear = eleman;
                Console.WriteLine("Ekleme yapıldı");
            }
        }
        public int Dequeue() //Eleman çıkarma
        {
            if(front == null)
            {
                Console.WriteLine("Kuyruk boş");
                return -1;
            }
            else
            {
                int data = front.data;
                front = front.next;
                Console.WriteLine("Kuyruktan eleman çıkarıldı");
                return data;
            }
        }
    }
}

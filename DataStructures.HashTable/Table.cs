using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class Table
    {
        int size;
        Node[] dizi;
        public Table(int size) // Oluşturulacak dizinin boyutu.
        {
            this.size = size;
            dizi = new Node[size];

            for (int i = 0; i < size; i++) //Diziyi oluşturup içine düğümlerimizi yerleştirdik.Yani 3 isimli görseldeki işlemi gerçekleştirdik !
            {
                dizi[i] = new Node();
            }
        }
        public int CreateIndex(int key) // Modunu alıyoruz düğümü ekleyeceğimiz indexi belirliyoruz.
        {
            return key % size;
        }
        public void Add(int key, string isim)
        {
            int index = CreateIndex(key);

            Node eleman = new Node(key, isim);

            Node temp = dizi[index];

            if (temp.next == null)
            {
                temp.next = eleman;
                Console.WriteLine("Sütunun ilk elemanı eklendi");
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
                Console.WriteLine(isim + " " + "eklendi");
            }
        }
        public void Print()
        {
            /* Sütun sütun dizinin elemanlarını inceleyeceğiz. 0. index'den son index'e kadar eleman var mı kontrol edilecek. Eğer varsa önce o düğümlerin üzerinden geçilecek. Örneğin 0. index'de 3 düğüm varsa bu 3 düğüm gezildikten sonra diğer indexe gecilecek. */
            for (int i = 0; i < size; i++)
            {
                Node temp = dizi[i]; //Bu whileden her cıktıgında bir artacak böylelikle tüm diziyi ve dizinin içerisindeki düğümleri gezmiş olacağız.
                Console.WriteLine("dizi [{0}] => ", i);

                while(temp.next != null)
                {
                    temp = temp.next;
                    Console.Write(temp.key + " " + temp.isim);
                }
                Console.WriteLine();
            }
        }
    }
}

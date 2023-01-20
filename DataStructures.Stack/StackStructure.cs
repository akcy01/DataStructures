using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class StackStructure
    {
        Node top;
        public StackStructure()
        {
            top = null;
        }
        public void Push(int data) /* Ekleme */
        {
            Node eleman = new Node(data);
            if(top == null)
            {
                top = eleman;
                Console.WriteLine("Stack yapısı oluşturuldu.İlk eleman eklendi");
            }
            else
            {
                eleman.next = top;
                top = eleman;
                Console.WriteLine("Eleman eklendi");
            }
        } 
        public int Pop() /* Çıkarma */
        {
            if(top == null)
            {
                Console.WriteLine("Stack boş");
                return -1;
            }
            else
            {
                int sayi = top.data;
                top = top.next;
                Console.WriteLine("Sayı stack'den çıkartıldı.");
                return sayi;
            }
        }
        public void Peek() /* Tepe elemanının döndürülmesi */
        {
            if(top == null)
            {
                Console.WriteLine("Stack boş");
            }
            else
            {
                Console.WriteLine(top.data);
            }
        }
        public void Print() /* Yazdırma işlemi */
        {

        }
    }
}

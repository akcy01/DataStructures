using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class Node
    {
        public int key;
        public string isim;
        public Node next;
        public Node() //Dizinin içerisindeki gösterici olan düğüm.
        {
            this.next = null;
        }
        public Node(int key, string isim) //Dizinin dışında bağlı liste olarak duracak düğüm. Zinciri yapacağımız düğümler yani.
        {
            this.key = key;
            this.isim = isim;
            this.next = null;
        }
    }
}

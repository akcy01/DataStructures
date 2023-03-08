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

            for(int i = 0; i < size; i++) //Diziyi oluşturup içine düğümlerimizi yerleştirdik.Yani 3 isimli görseldeki işlemi gerçekleştirdik !
            {
                dizi[i] = new Node();
            }
        }
    }
}

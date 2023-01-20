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

            }
        } 
    }
}

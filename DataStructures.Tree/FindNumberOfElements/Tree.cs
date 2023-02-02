using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.FindNumberOfElements
{
    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node newNode(int data)
        {
            root = new Node(data); 
            return root;
        }
        public Node Insert(Node root,int data)      /* Ağaca ekleme işlemi */
        {
            if(root != null)
            {
                if(data < root.data)
                {
                    root.left = Insert(root.left, data);
                }
                else
                {
                    root.right= Insert(root.right, data);
                }
            }
            else
            {
                root = newNode(data);
                return root;
            }
            return root;
        }
        public void InOrder(Node root)          /* Küçükten büyüğe sıralama */
        {
            InOrder(root.left);
            Console.Write(root.data + " ");
            InOrder(root.right);
        }
        public int Size(Node root) /* Ağacın eleman sayısı */
        {
            if(root == null)
                return 0;
            else
            {
                return Size(root.left) + 1 + Size(root.right); //Sol tarafı ayrı sağ tarafı ayrı sayıyoruz.Eleman null olmadığı her seferinde bir artacağı için + 1 koyduk !
            }
        }
        public int Height(Node root) /* Ağacın yüksekliği */
        {
            if(root == null)
            {
                return -1;
            }
            else
            {
                int left;
                int right;
                left = Height(root.left);
                right = Height(root.right);
                if(left > right)
                {
                    return left + 1;
                }
                else
                {
                    return right + 1;
                }
            }
        }
    }
}

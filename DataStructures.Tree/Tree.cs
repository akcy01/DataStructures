using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
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
        public Node Insert(Node root,int data) /* Ağaca düğüm ekleme */
        {
            Node eleman = new Node(data);
            if(root != null)
            {
                if(data < root.data)
                {
                    root.left = Insert(root.left, data);
                }
                else
                {
                    root.right = Insert(root.right, data);
                }
            }
            else
            {
                root = newNode(data);
            }
            return root;
        }
    }
}

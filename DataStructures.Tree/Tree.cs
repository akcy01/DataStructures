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
        public void preOrder(Node root) /* Agac uzerinde dolasma */
        {
            if(root != null)
            {
                Console.WriteLine(root.data);
                preOrder(root.left);
                preOrder(root.right);
            }
        }
        public void inOrder(Node root) /* Agac uzerinde dolasma */
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.WriteLine(root.data);
                inOrder(root.right);
            }
        }
        public void postOrder(Node root) /* Agac uzerinde dolasma */
        {
            if (root != null)
            {
                postOrder(root.left); 
                postOrder(root.right);
                Console.WriteLine(root.data);
            }
        }
    }
}

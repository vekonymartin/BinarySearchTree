using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    enum AdmittanceType { PreOrder, InOrder, PostOrder }
    class BinarySearchTree <T>
    {
        class TreeItem // nested class              
        {
            public int key;
            public T include;
            public TreeItem left;   // left child
            public TreeItem right;  // right child

            public TreeItem(int key, T include)
            {
                this.key = key;
                this.include = include;
            }

            public override string ToString()
            {
                return $"[{this.key.ToString()}] {this.include.ToString()}";
            }
        }

        TreeItem root;

        public BinarySearchTree()
        {
            this.root = null; // empty tree
        }

        public void Insert(int key, T include)
        {

        }

        private void Insert(ref TreeItem p, int key, T include)
        {
            if (p == null)
                p = new TreeItem(key, include);
            else if (p.key < key)
                Insert(ref p.right, key, include);
            else if (p.key > key)
                Insert(ref p.left, key, include);
            else
                throw new ThisKeyIsExistException() { Message = "This key has been exist in this tree!"};
        }

        public void Admittance(AdmittanceType type)
        {
            switch (type)
            {
                case AdmittanceType.PreOrder: PreOrder(this.root);
                    break;
                case AdmittanceType.InOrder: InOrder(this.root);
                    break;
                case AdmittanceType.PostOrder: PostOrder(this.root);
                    break;
                //default:      |
                    //break;    |   --> Not necessary
            }
        }

        private void PreOrder(TreeItem p)
        {
            if(p != null)
            {
                Console.WriteLine(p);
                PreOrder(p.left);
                PreOrder(p.right);
            }
        }

        private void InOrder(TreeItem p)
        {
            if (p != null)
            {
                InOrder(p.left);
                Console.WriteLine(p);
                InOrder(p.right);
            }
        }

        private void PostOrder(TreeItem p)
        {
            if (p != null)
            {
                PostOrder(p.left);
                PostOrder(p.right);
                Console.WriteLine(p);
            }
        }
    }
}

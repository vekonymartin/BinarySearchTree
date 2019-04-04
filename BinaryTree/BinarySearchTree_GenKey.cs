using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearchTree_GenKey <TKey, TValue> where TKey : IComparable
    {
        class TreeItem
        {
            public TKey key;
            public TValue contain;
            public TreeItem left;   // left child
            public TreeItem right;  // right child

            public TreeItem(TKey key, TValue contain)
            {
                this.key = key;
                this.contain = contain;
            }

            public override string ToString()
            {
                return $"[{this.key.ToString()}] {this.contain.ToString()}";
            }
        }

        TreeItem root;

        public BinarySearchTree_GenKey()
        {
            this.root = null;
        }

        public void Insert(TKey key, TValue contain)
        {
            Insert(ref root, key, contain);
        }

        private void Insert(ref TreeItem p, TKey key, TValue contain)
        {
            if (p == null)
                p = new TreeItem(key, contain);
            else if (p.key.CompareTo(key) < 0)
                Insert(ref p.right, key, contain);
            else if (p.key.CompareTo(key) > 0)
                Insert(ref p.left, key, contain);
            else
                throw new ThisKeyIsExistException() { Message = "This key has been exist in this tree!" };
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
                default:
                    break;
            }
        }

        private void PreOrder(TreeItem p)
        {
            if (p != null)
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

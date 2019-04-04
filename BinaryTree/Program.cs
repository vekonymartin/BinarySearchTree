using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BST
            //==========================
            // BINARY SEARCH TREE
            //==========================
            BinarySearchTree<string> BST = new BinarySearchTree<string>();

            BST.Insert(5, "Tony Stark");
            BST.Insert(8, "Thor");
            BST.Insert(1, "Hulk");
            BST.Insert(9, "Black Panther");
            BST.Insert(2, "Pokember");
            BST.Insert(10, "Thanos");

            Console.WriteLine("PREORDER\n", new string('-',8));
            BST.Admittance(AdmittanceType.PreOrder);
            Console.WriteLine("INORDER\n", new string('-',8));
            BST.Admittance(AdmittanceType.InOrder);
            Console.WriteLine("POSTORDER\n", new string('-',8));
            BST.Admittance(AdmittanceType.PostOrder);
            #endregion
            Console.WriteLine(new string('=',20));
            #region BSTG
            //=================================
            // BINARY SEARCH TREE GENERIC TYPE
            //=================================
            BinarySearchTree_GenKey<int, string> BSTG = new BinarySearchTree_GenKey<int, string>();

            BSTG.Insert(50, "apple");
            BSTG.Insert(60, "banana");
            BSTG.Insert(70, "blackberry");
            BSTG.Insert(40, "pineapple");
            BSTG.Insert(10, "coconut");
            BSTG.Insert(20, "pear");

            Console.WriteLine("\nPREORDER\n", new string('-', 8));
            BSTG.Admittance(AdmittanceType.PreOrder);
            Console.WriteLine("\nINORDER\n", new string('-', 8));
            BSTG.Admittance(AdmittanceType.InOrder);
            Console.WriteLine("\nPOSTORDER\n", new string('-', 8));
            BSTG.Admittance(AdmittanceType.PostOrder);
            #endregion

            Console.ReadLine();
        }
    }
}
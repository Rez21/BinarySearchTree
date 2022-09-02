using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        class MyBinaryNode<T> where T : IComparable
        {
            public T data;
            public BinarySearchTree<T> leftTree;
            public BinarySearchTree<T> rightTree;

            public MyBinaryNode(T data)
            {
                this.data = data;
            }
        }
        // Variable
        MyBinaryNode<T> rootNode;
        public void Add(T data)
        {
            // If the tree is empty
            if (rootNode == null)
            {
                rootNode = new MyBinaryNode<T>(data);
                return;
            }
            MyBinaryNode<T> temp = rootNode;

            // If the given element is less than compared then traverse left
            if (data.CompareTo(temp.data) < 0)
            {
                if (temp.leftTree == null)
                {
                    temp.leftTree = new BinarySearchTree<T>();
                    temp.leftTree.rootNode = new MyBinaryNode<T>(data);
                    return;
                }
                else
                    temp.leftTree.Add(data);
            }
            // If the given element is greater than compared then traverse right
            else if (data.CompareTo(temp.data) > 0)
            {
                if (temp.rightTree == null)
                {
                    temp.rightTree = new BinarySearchTree<T>();
                    temp.rightTree.rootNode = new MyBinaryNode<T>(data);
                    return;
                }
                else
                    temp.rightTree.Add(data);
            }
        }
        public int Size()
        {
            int count = 0;

            // If the tree is empty
            if (this.rootNode == null)
            {
                return 0;
            }

            // Iterate to the all left node of tree
            if (rootNode.leftTree != null)
            {
                count += rootNode.leftTree.Size();
            }

            // Iterate to all right nodes of tree 
            if (rootNode.rightTree != null)
            {
                count += rootNode.rightTree.Size();
            }

            count++;
            return count;
        }
        public void DisplayInOrder()
        {
            // If the tree is empty
            if (this.rootNode == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            if (rootNode.leftTree != null)
            {
                rootNode.leftTree.DisplayInOrder();
            }

            Console.WriteLine(rootNode.data);

            if (rootNode.rightTree != null)
            {
                rootNode.rightTree.DisplayInOrder();
            }
        }

       
        public bool Search(T data)
        {
            // If the tree is empty
            if (this.rootNode == null)
            {
                Console.WriteLine("\nTree is empty");
                return false;
            }

            // Compare the given data with rootNode data
            int comparision = data.CompareTo(rootNode.data);

            // If rootNode is the searched element
            if (comparision == 0)
            {
                Console.WriteLine("\n{0} is found in tree", data);
                return true;
            }

            else if (comparision < 0 && rootNode.leftTree != null)
                return rootNode.leftTree.Search(data);

            else if (comparision > 0 && rootNode.rightTree != null)
                return rootNode.rightTree.Search(data);

            Console.WriteLine("\n{0} is not found in tree", data);
            return false;
        }
    }
}

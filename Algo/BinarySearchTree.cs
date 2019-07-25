using System;
using System.Collections.Generic;

namespace Algo
{
    // for understanding
    //https://www.youtube.com/watch?v=COZK7NATh4k&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=28
    // https://www.geeksforgeeks.org/binary-search-tree-set-1-search-and-insertion/
    //https://www.youtube.com/watch?v=hWokyBoo0aI&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=29
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
        public Node(int data)
        {
            this.Data = data;
            Right = Left = null;
        }

        public void display()
        {
            Console.WriteLine("[", +Data + "]");
        }

    }

    public class BinarySearchTree
    {
        public Node root;
        Queue<Node> queue = new Queue<Node>();
        List<int> list = new List<int>();
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            root = BSTInsert(root, data);
        }

        public bool Search(int data)
        {
            return SearchBST(root, data);
        }

        /// <summary>
        /// Traversal beadth first approach with level reading.
        /// </summary>
        /// <returns></returns>
        public List<int> TraversalBFA()
        {
            //Breadth first apporch we read on level basis
            /* Let us create following BST 
                        50            L-0
                     /     \ 
                    30      70        L-1
                   /  \    /  \ 
                 20   40  60   80     L-2*/

            // lets read this tree: result sould be 50,30,70,20,40,60,80
            //lets create the queue and add nodes.
            // while popping out node if node has left or right child add them to queue (FIFO)
            //while popping print its data.
            List<int> list = new List<int>();
            list = TraverseBSTBFA(root);
            return list;
        }

        /// <summary>
        /// Depth first 
        /// left child will always read before right.
        /// </summary>
        /// <returns></returns>
        public List<int> TraversalDFA()
        {

            //postorder();  child first
            //inorder();    left child - parent -  right.
            //preorder();   parent first
            return null;

        }
        #region Private Methods

        private List<int> TraverseBSTBFA(Node root)
        {
            if (root == null)
            {
                return null;
            }
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
               // Node currentNode = queue.Dequeue();
                list.Add(currentNode.Data);
               // TraverseBSTBFA(queue.Peek());
            }
            return list;
        }
        private Node BSTInsert(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else if (root.Data > data)
            {
                // go left side
                root.Left = BSTInsert(root.Left, data);
            }
            else
            {
                //go right side
                root.Right = BSTInsert(root.Right, data);
            }
            return root;
        }

        private bool SearchBST(Node root, int data)
        {
            if (root == null)
            {
                return false;
            }
            else if (data == root.Data)
            {
                return true;
            }
            else if (data < root.Data)
            {
                //go left
                return SearchBST(root.Left, data);
            }
            else
            {
                //go right
                return SearchBST(root.Right, data);
            }
        }

        #endregion

    }

    public class ImplementBST
    {
        BinarySearchTree BSTree = new BinarySearchTree();
        public ImplementBST()
        {
            /* Let us create following BST 
                         50 
                      /     \ 
                     30      70 
                    /  \    /  \ 
                  20   40  60   80 */
            BSTree.Insert(50);
            BSTree.Insert(30);
            BSTree.Insert(20);
            BSTree.Insert(40);
            BSTree.Insert(70);
            BSTree.Insert(60);
            BSTree.Insert(80);
        }

        public void searchBST()
        {
            //  BinarySearchTree BSTree = new BinarySearchTree();
            BSTree.Search(60); //true;
            BSTree.Search(100); //false;
        }

        public void TraverseBST()
        {
            List<int> list = BSTree.TraversalBFA();
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }
        }
    }
}

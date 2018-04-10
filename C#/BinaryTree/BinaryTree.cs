using System;

namespace csharp
{
    public class BinaryTree
    {
        public static void RunBinaryTree()
        {
            Tree tree = new Tree();
            int val = 1;
            tree.insert(val);
            if (tree.search(val))
            {
                Console.WriteLine("found " + val);
            }
            else
            {
                Console.WriteLine("not found");
            }

        }
    }
    public class Tree
    {
        public Node root;

        public void insert(int value)
        {
            root = insertRecurse(value, root);
            Console.WriteLine(value + " was inserted");
        }
        public bool search(int value)
        {
            return searchRecurse(value, root);
        }
        private Node insertRecurse(int value, Node node)
        {

            if (node == null)
            {
                node = new Node(value);
                return node;
            }
            if (node.value == value)
                return node;
            Node next = value > node.value ? node.right : node.left;
            return insertRecurse(value, next);

        }

        public bool searchRecurse(int value, Node node)
        {
            if (node == null)
            {
                return false;

            }
            if (node.value == value)
            {
                return true;
            }
            Node next = value > node.value ? node.right : node.left;
            return searchRecurse(value, next);
        }
    }
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int value) { this.value = value; }
    }
}

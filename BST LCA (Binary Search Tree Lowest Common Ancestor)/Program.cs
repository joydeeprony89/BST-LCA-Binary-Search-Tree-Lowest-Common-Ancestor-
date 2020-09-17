using System;

namespace BST_LCA__Binary_Search_Tree_Lowest_Common_Ancestor_
{
    class Program
    {
        class Node
        {
            public int value;
            public Node left, right;

            public Node(int value)
            {
                this.value = value;
                left = right = null;
            }
        }

        class BinaryTree
        {
            public Node root;
        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(20);
            tree.root.left = new Node(8);
            tree.root.right = new Node(22);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(12);
            tree.root.left.right.left = new Node(10);
            tree.root.left.right.right = new Node(14);

            int n1 = 10, n2 = 14;
            Node t = LCAIteretive(tree.root, n1, n2);
            Console.WriteLine(
                "LCA of " + n1 + " and " + n2
                + " is " + t.value);

            n1 = 14;
            n2 = 8;
            t = LCAIteretive(tree.root, n1, n2);
            Console.WriteLine(
                "LCA of " + n1 + " and " + n2
                + " is " + t.value);

            n1 = 10;
            n2 = 22;
            t = LCAIteretive(tree.root, n1, n2);
            Console.WriteLine(
                "LCA of " + n1 + " and " + n2
                + " is " + t.value);
        }

        static Node LowestCommonAncestor(Node root, int a, int b)
        {
            if (root == null) return null;

            if(root.value > a && root.value > b)
            {
                return LowestCommonAncestor(root.left, a, b);
            }

            if (root.value < a && root.value < b)
            {
                return LowestCommonAncestor(root.right, a, b);
            }

            return root;
        }

        static Node LCAIteretive(Node root, int a , int b)
        {
            if (root == null) return null;

            while (root != null)
            {
                if (root.value > a && root.value > b)
                    root = root.left;

                else if (root.value < a && root.value < b)
                    root = root.right;
                else 
                    break;
            }

            return root;
        }
    }
}

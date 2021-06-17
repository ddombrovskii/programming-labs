using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class TreeNode
    {
        private double info;
        private TreeNode left;
        private TreeNode right;

        public double Info
        {
            get { return info; }
            set { info = value; }
        }

        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public TreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public TreeNode () { }

        public TreeNode (double info)
        {
            Info = info;
        }

        public TreeNode (double info, TreeNode left, TreeNode right)
        {
            Info = info;
            Left = left;
            Right = right;
        }
    }

    public class BinaryTree
    {
        private TreeNode root;

        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public BinaryTree()
        {
            root = null;
        }

        public TreeNode CreateTree(int n)
        {
            TreeNode root;

            if (n == 0)
                root = null;
            else
            {
                AddElementForm addForm = new AddElementForm();
                addForm.ShowDialog();
                root = new TreeNode(addForm.GetNumber());

                root.Left = CreateTree(n / 2);
                root.Right = CreateTree(n - n / 2 - 1);
            }

            return root;
        }

        public double FindMax(TreeNode root)
        {
            double maxNode = double.NegativeInfinity; // минус бесконечность

            if (root != null)
            {
                maxNode = root.Info;

                double leftMax = FindMax(root.Left);
                double rightMax = FindMax(root.Right);
                double leftright = Math.Max(leftMax, rightMax);
                maxNode = Math.Max(maxNode, leftright);
            }

            return maxNode;
        }

        public void Clear()
        {
            root = null;
        }
    }
}

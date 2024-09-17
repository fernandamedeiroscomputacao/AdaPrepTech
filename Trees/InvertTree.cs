using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class InvertTree
    {
        /********** 226 Invert Binary Tree *****************/
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public TreeNode InvertTreeProblem(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode temp = root.left;

            root.left = root.right;
            root.right = temp;

            InvertTreeProblem(root.left);
            InvertTreeProblem(root.right);

            return root;
        }
    }
}

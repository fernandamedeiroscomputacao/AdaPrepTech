using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class IsSymmetricProblem
    {
        //O(N)
        //O(h)
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

        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return CompareNode(root.left, root.right);

        }

        public bool CompareNode(TreeNode root1, TreeNode root2)
        {

            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 == null || root2 == null)
            {
                return false;
            }

            if (root1.val != root2.val)
            {
                return false;
            }

            return CompareNode(root1.left, root2.right) && CompareNode(root1.right, root2.left);
        }
    }
}

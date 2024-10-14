using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class DiameterOfBinaryTreeProblem
    {
        //543        
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

        public class Solution
        {
            private int diameter;

            public int DiameterOfBinaryTree(TreeNode root)
            {
                diameter = 0;
                DiameterBTAux(root);
                return diameter;
            }

            public int DiameterBTAux(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int leftDepth = DiameterBTAux(root.left);
                int rightDepth = DiameterBTAux(root.right);

                diameter = Math.Max(diameter, leftDepth + rightDepth);

                return Math.Max(leftDepth, rightDepth) + 1;

            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class FlipProblem
    {
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

        public bool FlipEquiv(TreeNode root1, TreeNode root2)
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

            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) ||
                   (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));

        }
    }
}

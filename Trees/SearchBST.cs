using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class SearchBST
    {
        /*************** 700 - search-in-a-binary-search-tree ************************/
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

        public TreeNode SearchBSTProblem(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            if (val < root.val)
            {
                return SearchBSTProblem(root.left, val);
            }
            else
            {
                return SearchBSTProblem(root.right, val);
            }

        }

    }
}

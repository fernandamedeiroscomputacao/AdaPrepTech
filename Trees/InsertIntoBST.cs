using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class InsertIntoBST
    {

        /*********************** 701 Insert into a Binary Search Tree ************************/

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

        public TreeNode InsertIntoBSTProblem(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            if (val > root.val)
            {
                root.right = InsertIntoBSTProblem(root.right, val);
            }
            else
            {
                root.left = InsertIntoBSTProblem(root.left, val);
            }

            return root;
        }

    }
}

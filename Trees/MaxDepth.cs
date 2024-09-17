using AdaPrepTech.DataStrutures.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.Trees
{
    public class MaxDepth
    {
        /*********** 559. Maximum Depth of N-ary Tree ***********************/

        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public int MaxDepthProblem(Node root)
        {
            return MaxDepthAux(root);
        }

        public int MaxDepthAux(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.children.Count == 0)
            {
                return 1;
            }

            int max_depth = 0;

            foreach (Node child in root.children)
            {
                int depth = MaxDepthAux(child);
                max_depth = Math.Max(max_depth, depth);
            }

            return max_depth + 1;
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPadTests.BinaryTree;

namespace ScratchPad.BinaryTree
{
    public class MergeTrees
    {
        public TreeNode MergeTwoTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;

            if (t2 == null)
                return t1;

            var runner1 = t1;
            var runner2 = t2;

            runner1.data += runner2.data;

            runner1.left = MergeTwoTrees(runner1.left, runner2.left);
            runner1.right = MergeTwoTrees(runner1.right, runner2.right);

            return t1;
        }
    }
}

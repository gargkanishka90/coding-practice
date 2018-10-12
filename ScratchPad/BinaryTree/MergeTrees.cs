using System.Collections.Generic;
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

        public TreeNode MergeTwoTreesIterative(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;

            if (t2 == null)
                return t1;

            var st = new Stack<TreeNode[]>();
            st.Push(new [] { t1, t2 });

            while (st.Count > 0)
            {
                var temp = st.Pop();

                if(temp[0] == null || temp[1] == null)
                    continue;

                temp[0].data += temp[1].data;

                if (temp[0].left == null)
                {
                    temp[0].left = temp[1].left;
                }
                else
                {
                    st.Push(new []{ temp[0].left, temp[1].left });
                }

                if (temp[0].right == null)
                {
                    temp[0].right = temp[1].right;
                }
                else
                {
                    st.Push(new []{ temp[0].right, temp[1].right});
                }
            }

            return t1;
        }
    }
}

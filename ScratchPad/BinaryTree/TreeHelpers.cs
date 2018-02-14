using System;
using System.Collections.Generic;
using PracticePad.Leetcode;

namespace ScratchPadTests.BinaryTree
{
    public class TreeHelpers
    {
        public static TreeNode CreateRandomTree()
        {
            var node1 = new TreeNode(6);
            var node2 = new TreeNode(8);
            var node3 = new TreeNode(10);
            var node4 = new TreeNode(16);
            var node5 = new TreeNode(58);
            var node6 = new TreeNode(810);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            return node1;
        }

        public static int Height(TreeNode root)
        {
            if (root == null) return 0;

            var left = Height(root.left);
            var right = Height(root.right);
            return 1 + Math.Max(left, right);
        }

        public static void PrintTree(TreeNode root)
        {
            if (root == null)
            {
                Console.Write("There are no elements in the tree.");
                return;
            }

            Console.WriteLine(root.data);

            PrintTree(root.left);
            PrintTree(root.right);
        }

        public static int FindLca(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root?.data ?? -1;

            var PathP = FindPath(root, p.data);
            var PathQ = FindPath(root, q.data);

            if (PathQ == null || PathP == null)
            {
                return -1;
            }

            var i = 0;
            for (i = 0; i < PathQ.Count && i < PathP.Count; i++)
            {
                if(PathQ[i].data != PathP[i].data)
                    break;
            }

            return PathP[i - 1].data;
        }

        public static List<TreeNode> FindPath(TreeNode root, int k)
        {
            var result = new List<TreeNode>();
            return PathUtil(root, k, result) ? result : null;
        }

        private static bool PathUtil(TreeNode root, int k, List<TreeNode> result)
        {
            if (root == null)
            {
                return false;
            }

            result.Add(root);

            if (root.data == k)
            {
                return true;
            }

            if (root.left != null && PathUtil(root.left, k, result))
            {
                return true;
            }

            if (root.right != null && PathUtil(root.right, k, result))
            {
                return true;
            }

            result.RemoveAt(result.Count - 1);

            return false;
        }

        public static bool IsSymmetric(TreeNode root)
        {
            // Iterative Approach.
            if (root == null)
                return true;

            return IsSymmetricHelper(root);
        }

        private static bool IsSymmetricHelper(TreeNode root)
        {

            var q = new Queue<TreeNode>();

            q.Enqueue(root.left);
            q.Enqueue(root.right);

            while (q.Count > 0)
            {
                var l = q.Dequeue();
                var r = q.Dequeue();

                if (l == null && r == null)
                    continue;

                if (l == null && r != null)
                    return false;

                if (l != null && r == null)
                    return false;

                if (l.data != r.data)
                    return false;

                q.Enqueue(l.left);
                q.Enqueue(r.right);
                q.Enqueue(l.right);
                q.Enqueue(r.left);
            }

            return true;
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            return HasPathSumHelper(root, sum);
        }

        private static bool HasPathSumHelper(TreeNode root, int sum)
        {
            if (root.left == null && root.right == null && root.data == sum)
                return true;
            return HasPathSumHelper(root.left, sum - root.data) && HasPathSumHelper(root.right, sum -root.data);
        }

        public static List<int> ComputeLeaves(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;
            ComputeLeavesHelper(root, result);
            return result;
        }

        private static void ComputeLeavesHelper(TreeNode root, IList<int> res)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                res.Add(root.data);
            }

            if (root.left != null)
            {
                ComputeLeavesHelper(root.left, res);
            }

            if (root.right != null)
            {
                ComputeLeavesHelper(root.right, res);
            }

            return;
        }
    }
    }
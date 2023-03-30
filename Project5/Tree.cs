﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////////////////////////////////////////
///
///
/// Used the Oreilly's book for this code
/// 
/////////////////////////////////////////
namespace Project5
{
    public class BinaryTree<T>
    {
        #region Attributes
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }
        #endregion

        #region TraversePreOrder()
        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }
        #endregion

        #region TraversInOrder()
        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }
        #endregion

        #region TraversePostOrder()
        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }
        #endregion

        #region Traverse()
        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root, nodes);
                    break;
            }
            return nodes;
        }
        #endregion

        #region GetHeight()
        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        }
        #endregion
    }
}

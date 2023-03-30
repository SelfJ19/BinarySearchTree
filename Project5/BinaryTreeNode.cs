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
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        #region Attributes
        public BinaryTreeNode() => Children = new List<TreeNode<T>>() { null, null };
        #endregion

        #region Left
        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }
        #endregion

        #region Right
        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }
        #endregion
    }
}

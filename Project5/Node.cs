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
    public class TreeNode<T>
    {
        #region Attributes
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }
        #endregion

        #region GetHeight()
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
        #endregion
    }
}
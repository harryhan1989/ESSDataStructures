using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Tree.BST
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode(T t)
        {
            Value = t;
        }
        public T Value { get; set; }
        public BinaryTreeNode<T> ParentNode { get; set; }
        public BinaryTreeNode<T> LefeNode { get; set; }
        public BinaryTreeNode<T> RightNode { get; set; }
        public int Hight { get; protected internal set; }
    }
}

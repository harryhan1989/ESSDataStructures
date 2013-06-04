using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Tree.BST
{
    public class BinarySearchNode<T>
    {
        public BinarySearchNode(T t)
        {
            Value = t;
        }
        public T Value { get; set; }
        public BinarySearchNode<T> ParentNode { get; set; }
        public BinarySearchNode<T> LefeNode { get; set; }
        public BinarySearchNode<T> RightNode { get; set; }
        public int Hight { get; protected internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESS_DataStructures.Core.Tree.BST;

namespace ESS_DataStructures.Core.Events
{
    public class BinaryTreeEventArgs<T> : EventArgs
    {
        public BinaryTreeNode<T> Type { get; set; }
    }
}

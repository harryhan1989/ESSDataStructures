using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Tree.BST
{
    public class BinarySearchTree<T>:IEnumerable<T> where T:IComparable<T>
    {
        #region Properties and fields

        private bool _isRefType;

        private IComparer<T> _comparer;

        public BinarySearchNode<T> Root { get; set; }

        public BinarySearchNode<T> StartNode { get; set; }

        public int Height { get; protected set; }

        #endregion

        #region Construction

        public BinarySearchTree()
        {
            _isRefType = typeof (T).IsClass;
        }

        public BinarySearchTree(IComparer<T> comparer )
        {
            _comparer = comparer;
        }

        #endregion

        #region Icomparable implementation

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Icomparable implementation

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESS_DataStructures.Core.Common;
using ESS_DataStructures.Core.Events;

namespace ESS_DataStructures.Core.Tree.BST
{
    public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable<T>, IDataStructureEvents
    {
        #region Properties and fields

        private bool _isRefType;

        private GenericCompare<T> _comparer;

        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTreeNode<T> StartNode { get; set; }

        public int Height { get; protected set; }

        #endregion

        #region Construction

        public BinarySearchTree()
        {
            _isRefType = typeof (T).IsClass;
            _comparer = new GenericCompare<T>();

        }

        public BinarySearchTree(IComparer<T> comparer)
        {
            _comparer = new GenericCompare<T>(comparer);
        }

        #endregion

        #region Events

        public event EventHandler ItemAdding;

        public event EventHandler ItemAdded;

        public event EventHandler ItemUpdating;

        public event EventHandler ItemUpdated;

        public event EventHandler ItemDeleting;

        public event EventHandler ItemDeleted;

        protected virtual void OnItemAdding(EventArgs e)
        {
            var handler = ItemAdding;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnItemAdded(EventArgs e)
        {
            var handler = ItemAdded;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnItemUpdating(EventArgs e)
        {
            var handler = ItemUpdating;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnItemUpdated(EventArgs e)
        {
            var handler = ItemUpdated;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnItemDeleting(EventArgs e)
        {
            var handler = ItemDeleting;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnItemDeleted(EventArgs e)
        {
            EventHandler handler = ItemDeleted;
            if (handler != null) handler(this, e);
        }

        #endregion

        #region Indexer

        public T this[int index]
        {
            get 
            {
                if (index > this.Count())
                {
                    throw new InvalidOperationException("");
                }

                //todo traver
                throw new InvalidOperationException("");
            }
        }

        #endregion

        #region Add



        #endregion

        #region Remove


        #endregion

        #region Search



        #endregion

        #region Traversal



        #endregion

        #region IEnumerable implementation

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

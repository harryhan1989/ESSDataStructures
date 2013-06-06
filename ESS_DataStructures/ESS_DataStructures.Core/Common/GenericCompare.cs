using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Common
{
    public static class GenericCompare
    {
        public static T Max<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) > 0) ? x : y;
        }

        public static bool IsLessThan<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) < 0) ? true : false;
        }

        public static bool IsEqual<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) == 0) ? true : false;
        }

        public static bool IsGreaterThanEqual<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) >= 0) ? true : false;
        }
    }

    public class GenericCompare<T>
    {
        private readonly IComparer<T> _comparer;

        public GenericCompare(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public GenericCompare()
        {
            _comparer = Comparer<T>.Default;
        }

        public T Max(T x, T y)
        {
            return _comparer.Compare(x, y) > 0 ? x : y;
        }

        public bool IsLessThan(T x, T y)
        {
            return _comparer.Compare(x, y) < 0 ? true : false;
        }

        public bool IsEqual(T x, T y)
        {
            return _comparer.Compare(x, y) == 0 ? true : false;
        }

        public bool IsGreaterThanEqual(T x, T y)
        {
            return _comparer.Compare(x, y) >= 0 ? true : false;
        }

        public int Compare(T x, T y)
        {
            return _comparer.Compare(x, y);
        }
    }
}
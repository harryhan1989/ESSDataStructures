using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Common.CustomCompares
{
    public class DateTimeCompare : IComparer<DateTime>
    {
        public int Compare(DateTime x, DateTime y)
        {
            return x.CompareTo(y);
        }
    }
}

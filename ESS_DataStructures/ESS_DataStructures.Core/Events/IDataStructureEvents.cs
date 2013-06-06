using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Events
{
    public interface IDataStructureEvents
    {
        event EventHandler ItemAdding;
        void OnItemAdding(EventArgs e);
        event EventHandler ItemAdded;
        void OnItemAdded(EventArgs e);

        event EventHandler ItemUpdating;
        void OnItemUpdating(EventArgs e);
        event EventHandler ItemUpdated;
        void OnItemUpdated(EventArgs e);

        event EventHandler ItemDeleting;
        void OnItemDeleting(EventArgs e);
        event EventHandler ItemDeleted;
        void OnItemDeleted(EventArgs e);
    }
}

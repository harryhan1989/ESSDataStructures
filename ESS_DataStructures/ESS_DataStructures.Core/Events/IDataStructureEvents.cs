using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS_DataStructures.Core.Events
{
    public interface IDataStructureEvents
    {
        event EventHandler OnItemAdding;
        void ItemAdding();
        event EventHandler OnItemAdded;
        void ItemAdded();

        event EventHandler OnItemUpdating;
        void ItemUpdating();
        event EventHandler OnItemUpdated;
        void ItemUpdated();

        event EventHandler OnItemDeleting;
        void ItemDeleting();
        event EventHandler OnItemDeleted;
        void ItemDeleted();
    }
}

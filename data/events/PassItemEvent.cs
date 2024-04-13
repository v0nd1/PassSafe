using PassSafe.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe.data.events
{
    public class PassItemEvent : EventArgs
    {
        public PassItemEvent(PassItem selectedPassItem)
        {
            SelectedPassItem = selectedPassItem;
        }

        public PassItem SelectedPassItem { get; } // Свойство, содержащее выбранный элемент PassItem
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe.data.events
{
    public class PassItemEvent : EventArgs
    {
        public PassItemEvent(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}

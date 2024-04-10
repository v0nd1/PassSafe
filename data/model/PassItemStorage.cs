using PassSafe.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe.data.model
{
    public class PassItemStorage
    {
        private Dictionary<string, ObservableCollection<PassItem>> storage;

        public PassItemStorage()
        {
            storage = new Dictionary<string, ObservableCollection<PassItem>>();
        }

        public void AddPassItem(string category, PassItem passItem)
        {
            if (!storage.ContainsKey(category))
            {
                storage[category] = new ObservableCollection<PassItem>();
            }

            storage[category].Add(passItem);
        }

        public void RemovePassItem(string category, PassItem passItem)
        {
            if (storage.ContainsKey(category))
            {
                storage[category].Remove(passItem);
            }
        }

        public IEnumerable<PassItem> GetPassItemsByCategory(string category)
        {
            if (storage.ContainsKey(category))
            {
                return storage[category];
            }

            return Enumerable.Empty<PassItem>();
        }

        public IEnumerable<string> GetAllCategories()
        {
            return storage.Keys;
        }

        public IEnumerable<PassItem> GetAllPassItems()
        {
            return storage.Values.SelectMany(items => items);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public static class ObservableCollectionExtensions
    {
        public static void AddRangeUnique<T>(this ObservableCollection<T> oCollection, IEnumerable<T> items)
        {
            if (oCollection != null && items != null)
            {
                foreach (var item in items)
                {
                    if (!oCollection.Contains(item))
                    {
                        oCollection.Add(item);
                    }
                }
            }
        }
    }
}
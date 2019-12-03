using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace PostBookApp.Util
{

    class PageEqualityComparer : IEqualityComparer<Page>
    {
        public bool Equals(Page x, Page y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Page obj)
        {
            throw new NotImplementedException();
        }
    }
}

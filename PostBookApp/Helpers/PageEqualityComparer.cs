using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System;

namespace PostBookApp.Helpers
{
    internal class PageEqualityComparer : IEqualityComparer<Page>
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
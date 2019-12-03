using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostBookApp.Util
{
    class MockPage : FacebookWrapper.ObjectModel.Page
    {
        private readonly string r_MockName;

        public new string Name { get { return this.r_MockName; } }

        public MockPage(string name)
        {
            this.r_MockName = name;
        }
    }
}

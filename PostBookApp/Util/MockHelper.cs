using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace PostBookApp.Util
{
    class MockHelper
    {
        public static FacebookObjectCollection<MockPage> getMockedPages(int i_howMany)
        {
            FacebookObjectCollection<MockPage> mockedPages = new FacebookObjectCollection<MockPage>();

            for (int i = 0; i < i_howMany; i++)
            {
                mockedPages.Add(new MockPage("mock page" + i));
            }

            return mockedPages;
        }
    }
}

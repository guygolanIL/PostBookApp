using System;
using FacebookWrapper.ObjectModel;

namespace PostBookApp.Helpers
{
    internal class MockHelper
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
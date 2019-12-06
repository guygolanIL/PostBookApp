namespace PostBookApp.Helpers
{
    internal class MockPage : FacebookWrapper.ObjectModel.Page
    {

        private string m_MockedName;

        internal MockPage(string i_Name)
        {
            this.m_MockedName = i_Name;
        }

        public new string Name { get { return this.m_MockedName; } }
    }
}
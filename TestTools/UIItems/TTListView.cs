using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTListView : TTBaseUIItem<ListView>
    {
        protected TTListView(ListView listView, string friendlyName) : base(listView, friendlyName) { }

        protected TTListView(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("list"), friendlyName, scope, timeoutInMillisecods)
        { }

        public IEnumerable<TTUIItem> Items => _uIItem.Rows.Select(item =>
            TTUIItem.Get(new UIItem(item.AutomationElement, new NullActionListener()), item.Name));

        public TTUIItem GetTTListItem(string name)
        {
            return Items.FirstOrDefault(item => item.UIItem.Name.Equals(name) || item.UIItem.HelpText.Equals(name));
        }

        public new static TTListView Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTListView(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTListView Get(ListView listView, string friendlyName)
        {
            return new TTListView(listView, friendlyName);
        }
    }
}

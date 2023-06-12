using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTGroupBox : TTBaseUIItem<GroupBox>
    {
        protected TTGroupBox(GroupBox groupBox, string friendlyName) : base(groupBox, friendlyName) { }

        protected TTGroupBox(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("group"), friendlyName, scope, timeoutInMillisecods) { }

        public IEnumerable<TTListItem> GetTTListItems => _uIItem.GetMultiple(SearchCriteria.ByControlType("list item"))
            .Select<UIItem>(item => TTListItem.Get(item, $"{item.Name} list item"));

        public TTListItem GetTTListItem(string name)
        {
            return GetTTListItems.FirstOrDefault(item => item.UIItem.Name.Equals(name) || item.UIItem.HelpText.Equals(name));
        }

        public new static TTGroupBox Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTGroupBox(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTGroupBox Get(GroupBox groupBox, string friendlyName)
        {
            return new TTGroupBox(groupBox, friendlyName);
        }
    }
}

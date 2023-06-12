using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;

namespace TestTools.UIItems
{
    public class TTListItem: TTBaseUIItem<ListItem>
    {
        protected TTListItem(ListItem listItem, string friendlyName) : base(listItem, friendlyName) { }

        protected TTListItem(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("list item"), friendlyName, scope, timeoutInMillisecods) { }

        public new static TTListItem Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTListItem(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }
    }
}

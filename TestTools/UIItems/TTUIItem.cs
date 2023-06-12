using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTUIItem : TTBaseUIItem<UIItem>
    {
        protected TTUIItem(UIItem uIItem, string friendlyName) : base(uIItem, friendlyName) { }

        protected TTUIItem(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria, friendlyName, scope, timeoutInMillisecods) { }

        public new static TTUIItem Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTUIItem(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTUIItem Get(UIItem uIItem, string friendlyName)
        {
            return new TTUIItem(uIItem, friendlyName);
        }
    }
}

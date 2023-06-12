using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTPanel : TTBaseUIItem<Panel>
    {
        protected TTPanel(Panel panel, string friendlyName) : base(panel, friendlyName) { }

        protected TTPanel(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("pane"), friendlyName, scope, timeoutInMillisecods) { }

        public new static TTPanel Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTPanel(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTPanel Get(Panel panel, string friendlyName)
        {
            return new TTPanel(panel, friendlyName);
        }
    }
}

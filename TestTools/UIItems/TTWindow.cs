using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestTools.UIItems
{
    public class TTWindow : TTBaseUIItem<Window>
    {
        protected TTWindow(Window window, string friendlyName) : base(window, friendlyName) { }

        protected TTWindow(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("window"), friendlyName, scope, timeoutInMillisecods) { }

        public new static TTWindow Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTWindow(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTWindow Get(Window window, string friendlyName)
        {
            return new TTWindow(window, friendlyName);
        }
    }
}

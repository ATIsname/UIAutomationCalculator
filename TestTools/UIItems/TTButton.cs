using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTButton : TTBaseUIItem<Button>
    {
        protected TTButton(Button button, string friendlyName) : base(button, friendlyName) { }

        protected TTButton(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("button"), friendlyName, scope, timeoutInMillisecods)
        { }

        public new static TTButton Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTButton(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTButton Get(Button button, string friendlyName)
        {
            return new TTButton(button, friendlyName);
        }
    }
}

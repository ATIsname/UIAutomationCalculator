using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTLabel : TTBaseUIItem<Label>
    {
        public string Text => _uIItem.Text;
        protected TTLabel(Label label, string friendlyName) : base(label, friendlyName) { }

        protected TTLabel(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("text"), friendlyName, scope, timeoutInMillisecods) { }

        public new static TTLabel Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTLabel(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTLabel Get(Label label, string friendlyName)
        {
            return new TTLabel(label, friendlyName);
        }
    }
}

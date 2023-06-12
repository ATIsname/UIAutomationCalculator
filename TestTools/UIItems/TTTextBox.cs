using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTTextBox : TTBaseUIItem<TextBox>
    {
        protected TTTextBox(TextBox textBox, string friendlyName) : base(textBox, friendlyName) { }

        protected TTTextBox(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria, friendlyName, scope, timeoutInMillisecods)
        { }

        public new static TTTextBox Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTTextBox(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTTextBox Get(TextBox textBox, string friendlyName)
        {
            return new TTTextBox(textBox, friendlyName);
        }
    }
}

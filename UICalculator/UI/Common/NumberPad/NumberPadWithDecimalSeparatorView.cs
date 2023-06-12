using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common.NumberPad
{
    public class NumberPadWithDecimalSeparatorView : NumberPadView
    {
        public NumberPadWithDecimalSeparatorView(UIItem parent) : base(parent)
        {
        }

        public TTButton DecimalSeparator => TTButton.Get(SearchCriteria.ByAutomationId("decimalSeparatorButton"),
            "Decimal Separator", _parent, Timeouts.Small);
    }
}

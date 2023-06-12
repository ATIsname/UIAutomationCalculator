using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common
{
    public class PositveNegativeView : BaseChildView
    {
        public PositveNegativeView(UIItem parent) : base(parent)
        {
        }

        public TTButton PositiveNegative => TTButton.Get(SearchCriteria.ByAutomationId("negateButton"),
            "Positive Negative", _parent, Timeouts.Small);
    }
}

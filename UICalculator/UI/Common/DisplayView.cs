using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common
{
    public class DisplayView : BaseChildView
    {
        public DisplayView(UIItem parent) : base(parent)
        {
        }

        public TTLabel Display => TTLabel.Get(SearchCriteria.ByAutomationId("CalculatorResults"),
            "Display", _parent, Timeouts.Small);
    }
}

using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI
{
    public abstract class CalculatorWindowView
    {
        public TTWindow CalculatorWindow => TTWindow.Get(SearchCriteria.ByClassName("Windows.UI.Core.CoreWindow")
            .AndByText("Calculator"), "Calculator", timeoutInMillisecods: Timeouts.Small);
    }
}

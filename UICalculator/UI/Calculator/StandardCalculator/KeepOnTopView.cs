using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Calculator.StandardCalculator
{
    public class KeepOnTopView : BaseChildView
    {
        public KeepOnTopView(UIItem parent) : base(parent)
        {
        }

        public TTButton KeepOnTop => TTButton.Get(SearchCriteria.ByAutomationId("NormalAlwaysOnTopButton"),
            "Keep On Top", _parent, Timeouts.Small);

        public MinimizedStandardCalculatorView OpenMinimizedStandardCalculator()
        {
            KeepOnTop.Click();
            return new MinimizedStandardCalculatorView();
        }

        public StandardCalculatorView CloseMinimizedStandardCalculator()
        {
            KeepOnTop.Click();
            return new StandardCalculatorView();
        }
    }
}

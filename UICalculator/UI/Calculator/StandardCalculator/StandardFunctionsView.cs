using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Calculator.StandardCalculator
{
    public class StandardFunctionsView : BaseChildView
    {
        public StandardFunctionsView(UIItem parent) : base(parent)
        {
        }

        public TTGroupBox StandardFunctions => TTGroupBox.Get(SearchCriteria.ByAutomationId("StandardFunctions"),
            "Standard Functions", _parent, Timeouts.Small);

        public TTButton Reciprocal => TTButton.Get(SearchCriteria.ByAutomationId("invertButton"),
            "Reciprocal", _parent, Timeouts.Small);

        public TTButton Square => TTButton.Get(SearchCriteria.ByAutomationId("xpower2Button"),
            "Square", _parent, Timeouts.Small);

        public TTButton SquareRoot => TTButton.Get(SearchCriteria.ByAutomationId("squareRootButton"),
            "Square Root", _parent, Timeouts.Small);
    }
}

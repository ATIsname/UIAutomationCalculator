using UICalculator.UI.Common;
using UICalculator.UI.Common.NumberPad;

namespace UICalculator.UI.Calculator.StandardCalculator
{
    public class MinimizedStandardCalculatorView : CalculatorWindowView
    {
        public KeepOnTopView KeepOnTopView =>
               new KeepOnTopView(CalculatorWindow.UIItem);

        public DisplayView ResultsView =>
            new DisplayView(CalculatorWindow.UIItem);

        public StandardDisplayControlsView StandardDisplayControlsView =>
            new StandardDisplayControlsView(CalculatorWindow.UIItem);

        public StandardFunctionsView StandardFunctionsView =>
            new StandardFunctionsView(CalculatorWindow.UIItem);

        public StandardOperatorsView StandardOperators =>
            new StandardOperatorsView(CalculatorWindow.UIItem);

        public NumberPadWithDecimalSeparatorView NumberPadWithDecimalSeparatorView =>
            new NumberPadWithDecimalSeparatorView(CalculatorWindow.UIItem);

        public PositveNegativeView PositveNegativeView =>
            new PositveNegativeView(CalculatorWindow.UIItem);
    }
}

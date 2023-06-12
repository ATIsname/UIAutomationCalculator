using UICalculator.UI.Calculator.StandardCalculator;
using UICalculator.UI.Common;
using UICalculator.UI.Common.NumberPad;

namespace UICalculator.UI.Calculator
{
    public class StandardCalculatorView : CalculatorBaseView
    {
        public KeepOnTopView KeepOnTopView =>
            new KeepOnTopView(CalculatorWindow.UIItem);

        public OpenCloseHistoryFlyoutView OpenCloseHistoryFlyoutView =>
            new OpenCloseHistoryFlyoutView(CalculatorWindow.UIItem);

        public DisplayView DisplayView =>
            new DisplayView(CalculatorWindow.UIItem);

        public MemoryControlsView MemoryControlsView =>
            new MemoryControlsView(CalculatorWindow.UIItem);

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

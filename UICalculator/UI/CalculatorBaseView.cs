using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;
using UICalculator.UI.Menu;

namespace UICalculator.UI
{
    public abstract class CalculatorBaseView : CalculatorWindowView
    {
        public TTImage CalculatorIcon => TTImage.Get(SearchCriteria.ByAutomationId("AppIcon"),
            "Calculator Icon", CalculatorWindow.UIItem, Timeouts.Small);

        public TTLabel CalculationTitle => TTLabel.Get(SearchCriteria.ByAutomationId("Header"),
            "Calculation Title", CalculatorWindow.UIItem, Timeouts.Small);

        public TTPanel MenuPanel => TTPanel.Get(SearchCriteria.ByAutomationId("TogglePaneButton"),
            "Menu", CalculatorWindow.UIItem, Timeouts.Small);

        public MenuView OpenMenu()
        {
            MenuPanel.Click();
            return new MenuView(CalculatorWindow.UIItem);
        }

        public void CloseMenu()
        {
            MenuPanel.Click();
        }
    }
}

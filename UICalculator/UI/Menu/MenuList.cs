using System.ComponentModel;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.Extensions;
using TestTools.UIItems;
using TestTools.Utils;
using UICalculator.UI.Calculator;

namespace UICalculator.UI.Menu
{
    public class MenuList : BaseChildView
    {
        public enum ECalculateMenuOptions
        {
            [Description("Standard")]
            Standard,
            [Description("Scientific")]
            Scientific,
            [Description("Graphing")]
            Graphing,
            [Description("Programmer")]
            Programmer,
            [Description("Date calculation")]
            DateCalculation,
            [Description("Currency")]
            Currency,
            [Description("Volume")]
            Volume,
            [Description("Length")]
            Length,
            [Description("Weight and mass")]
            WeightAndMass,
            [Description("Temperature")]
            Temperature,
            [Description("Energy")]
            Energy,
            [Description("Area")]
            Area,
            [Description("Speed")]
            Speed,
            [Description("Time")]
            Time,
            [Description("Power")]
            Power,
            [Description("Data")]
            Data,
            [Description("Pressure")]
            Pressure,
            [Description("Angle")]
            Angle
        }

        public MenuList(UIItem parent) : base(parent)
        {
        }

        public TTPanel MenuListScrollViewer => TTPanel.Get(SearchCriteria.ByClassName("MenuItemsScrollViewer"),
            "Footer View", _parent, Timeouts.Small);

        public TTGroupBox Menu => TTGroupBox.Get(SearchCriteria.ByAutomationId("MenuItemsHost"),
            "CFooter List", MenuListScrollViewer.UIItem, Timeouts.Small);

        public TTListItem GetCalculateOption(ECalculateMenuOptions menuOption)
        {
            return Menu.GetTTListItem(menuOption.GetDescription());
        }

        public CalculatorBaseView OpenCalculatorOrConverterView(ECalculateMenuOptions menuOption)
        {
            GetCalculateOption(menuOption).Click();
            switch (menuOption)
            {
                case ECalculateMenuOptions.Standard:
                    return new StandardCalculatorView();
                ///TO DO
                default:
                    throw new ArgumentNullException(menuOption.ToString(), nameof(menuOption));
            }
        }
    }
}

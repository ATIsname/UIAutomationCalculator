using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;
using UICalculator.DTO;
using static UICalculator.DTO.StandardOperatorsDto;

namespace UICalculator.UI.Common
{
    public class StandardOperatorsView : BaseChildView
    {
        private static List<StandardOperatorsDto> StandardOperatorsList = new List<StandardOperatorsDto>()
        {
            new StandardOperatorsDto(EStandardOperators.DevideBy, "Devide by", "/"),
            new StandardOperatorsDto(EStandardOperators.MultiplyBy, "Multiply by", "*"),
            new StandardOperatorsDto(EStandardOperators.Minus, "Minus", "-"),
            new StandardOperatorsDto(EStandardOperators.Plus, "Plus", "+"),
            new StandardOperatorsDto(EStandardOperators.Equals, "Equals", "="),
        };

        public StandardOperatorsView(UIItem parent) : base(parent)
        {
        }

        public TTGroupBox StandardOperators => TTGroupBox.Get(SearchCriteria.ByAutomationId("StandardOperators"),
            "Standard Operators", _parent, Timeouts.Small);

        public TTButton GetOperator(EStandardOperators eOperator)
        {
            return TTButton.Get(SearchCriteria.ByNativeProperty(AutomationElement.NameProperty, eOperator), StandardOperators.UIItem, Timeouts.Small);
        }

        public TTButton GetOperator(char chOperator)
        {
            return GetOperator(StandardOperatorsList.FirstOrDefault(operatorObj =>
                operatorObj.Value.Equals(chOperator)).EOperator);
        }

        public void Click(EStandardOperators eOperator)
        {
            GetOperator(eOperator).Click();
        }

        public void Click(char chOperator)
        {
            GetOperator(chOperator).Click();
        }
    }
}

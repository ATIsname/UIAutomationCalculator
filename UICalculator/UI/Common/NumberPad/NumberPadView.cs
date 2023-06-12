using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common.NumberPad
{
    public class NumberPadView : BaseChildView
    {
        public NumberPadView(UIItem parent) : base(parent)
        {
        }

        public enum ENumbers
        {
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9
        }

        public TTGroupBox NumberPad => TTGroupBox.Get(SearchCriteria.ByAutomationId("NumberPad"),
            "Number Pad", _parent, Timeouts.Small);

        protected TTButton GetNumber(int number)
        {
            return GetNumber((ENumbers)number);
        }

        public TTButton GetNumber(ENumbers number)
        {
            return TTButton.Get(SearchCriteria.ByText(number.ToString()),
            number.ToString(), NumberPad.UIItem, Timeouts.Small);
        }

        public void Click(ENumbers number)
        {
            GetNumber(number).Click();
        }

        public void ClickMultiple(int number)
        {
            var numberCharArray = number.ToString();
            foreach (var numberChar in numberCharArray)
            {
                GetNumber(numberChar).Click();
            }
        }
    }
}

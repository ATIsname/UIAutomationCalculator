using TestStack.White.UIItems;
using TestTools.UIItems;
using UICalculator.UI.Common;

namespace UICalculator.UI.Calculator.StandardCalculator
{
    public class StandardDisplayControlsView : BaseDisplayControlsView
    {
        public new TTButton Percent => base.Percent;

        public new TTButton ClearEntryButton => base.ClearEntryButton;

        public new TTButton ClearButton => base.ClearButton;

        public new TTButton BackSpaceButton => base.BackSpaceButton;

        public StandardDisplayControlsView(UIItem parent) : base(parent)
        {
        }
    }
}

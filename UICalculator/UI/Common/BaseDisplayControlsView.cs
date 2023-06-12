using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common
{
    public abstract class BaseDisplayControlsView : BaseChildView
    {
        protected BaseDisplayControlsView(UIItem parent) : base(parent)
        {
        }

        protected TTButton Percent => TTButton.Get(SearchCriteria.ByAutomationId("percentButton"),
            "Percent", DisplayControls.UIItem, Timeouts.Small);

        protected TTButton ClearEntryButton => TTButton.Get(SearchCriteria.ByAutomationId("clearEntryButton"),
            "Clear Entry", DisplayControls.UIItem, Timeouts.Small);

        protected TTButton ClearButton => TTButton.Get(SearchCriteria.ByAutomationId("clearButton"),
            "Clear", DisplayControls.UIItem, Timeouts.Small);

        protected TTButton BackSpaceButton => TTButton.Get(SearchCriteria.ByAutomationId("backSpaceButton"),
            "Back Space", DisplayControls.UIItem, Timeouts.Small);

        public TTGroupBox DisplayControls => TTGroupBox.Get(SearchCriteria.ByAutomationId("DisplayControls"),
            "Display Controls", _parent, Timeouts.Small);

    }
}

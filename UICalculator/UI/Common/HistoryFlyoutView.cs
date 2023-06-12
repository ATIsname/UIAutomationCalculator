using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common
{
    public class HistoryFlyoutView : BaseChildView
    {
        public HistoryFlyoutView(UIItem parent) : base(parent)
        {
        }

        public TTPanel History => TTPanel.Get(SearchCriteria.ByAutomationId("HistoryFlyout"),
            "History Flyout", _parent, Timeouts.Small);

        public TTListView HistoryList => TTListView.Get(SearchCriteria.ByAutomationId("HistoryListView"),
            "History List", History.UIItem, Timeouts.Small);

        public TTButton ClearAllHistory => TTButton.Get(SearchCriteria.ByAutomationId("ClearHistory"),
            "Clear History", History.UIItem, Timeouts.Small);
    }
}

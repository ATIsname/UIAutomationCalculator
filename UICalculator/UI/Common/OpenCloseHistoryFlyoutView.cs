using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Common
{
    public class OpenCloseHistoryFlyoutView : BaseChildView
    {
        private HistoryFlyoutView _flyoutView;

        public OpenCloseHistoryFlyoutView(UIItem parent) : base(parent)
        {
        }

        public TTButton OpenOrClose => TTButton.Get(SearchCriteria.ByAutomationId("HistoryButton"),
            "Open Or Close History", _parent, Timeouts.Small);

        public HistoryFlyoutView OpenMenu()
        {
            OpenOrClose.Click();
            _flyoutView = new HistoryFlyoutView(_parent);
            TTWait.Until(() => _flyoutView.History.Exists, Timeouts.Small);
            return _flyoutView;
        }

        public void CloseMenu()
        {
            OpenOrClose.Click();
            TTWait.Until(() => !_flyoutView.History.Exists, Timeouts.Small);
            _flyoutView = null;
        }
    }
}

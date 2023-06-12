using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Menu
{
    public class MenuFooter : BaseChildView
    {
        public MenuFooter(UIItem parent) : base(parent)
        {
        }

        public TTPanel FooterScrollViewer => TTPanel.Get(SearchCriteria.ByClassName("FooterItemsScrollViewer"),
            "Footer Scroll View", _parent, Timeouts.Small);

        public TTGroupBox FooterGroup => TTGroupBox.Get(SearchCriteria.ByAutomationId("FooterMenuItemsHost"),
            "Footer", FooterScrollViewer.UIItem, Timeouts.Small);

        public TTListItem Settings => FooterGroup.GetTTListItem("Settings");
    }
}

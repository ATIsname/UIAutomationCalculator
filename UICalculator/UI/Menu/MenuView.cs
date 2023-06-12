using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestTools.UIItems;
using TestTools.Utils;

namespace UICalculator.UI.Menu
{
    public class MenuView : BaseChildView
    {
        public MenuView(UIItem parent) : base(parent)
        {
        }

        public TTWindow MenuWindow => TTWindow.Get(SearchCriteria.ByClassName("PaneRoot"),
            "Calculator Main window", _parent, Timeouts.Small);

        public MenuList MenuList => new MenuList(MenuWindow.UIItem);

        public MenuFooter MenuFooter => new MenuFooter(MenuWindow.UIItem);
    }
}

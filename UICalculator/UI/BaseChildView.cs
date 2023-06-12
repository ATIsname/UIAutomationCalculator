using TestStack.White.UIItems;

namespace UICalculator.UI
{
    public class BaseChildView
    {
        protected UIItem _parent;

        public BaseChildView(UIItem parent)
        {
            _parent = parent;
        }
    }
}

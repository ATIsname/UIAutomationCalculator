using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestTools.UIItems
{
    public class TTImage : TTBaseUIItem<Image>
    {
        protected TTImage(Image image, string friendlyName) : base(image, friendlyName) { }

        protected TTImage(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0) :
            base(searchCriteria.AndControlType("image"), friendlyName, scope, timeoutInMillisecods) { }

        public new static TTImage Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return new TTImage(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public static TTImage Get(Image image, string friendlyName)
        {
            return new TTImage(image, friendlyName);
        }
    }
}

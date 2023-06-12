using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestTools.Loggers;
using TestTools.Utils;

namespace TestTools.UIItems
{
    public abstract class TTBaseUIItem<T> where T : UIItem
    {
        protected SearchCriteria _searchCriteria;

        protected T _uIItem;

        protected string _friendlyName;

        public bool Exists
        {
            get
            {
                try
                {
                    return _uIItem.Visible;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string GetInnerText => TTLabel.Get(SearchCriteria.ByControlType("text"),
            $"{_friendlyName} inner label", _uIItem, Timeouts.Small).Text;

        public TTLabel GetInnerLabel => TTLabel.Get(SearchCriteria.ByControlType("text"),
            $"{_friendlyName} inner label", _uIItem, Timeouts.Small);

        public UIItem UIItem { get => _uIItem; }

        public TTBaseUIItem(T uIItem, string friendlyName)
        {
            _uIItem = uIItem;
            _friendlyName = friendlyName;
        }

        protected TTBaseUIItem(SearchCriteria searchCriteria, string friendlyName,
            UIItem scope, int timeoutInMillisecods)
        {
            _searchCriteria = searchCriteria;
            scope = scope ?? ApplicationManger.CurrentApp.MainWindow.UIItem;
            var uIItem = TTWait.Until(() => (T)new UIItem(scope.GetElement(_searchCriteria),
                new NullActionListener()), timeoutInMillisecods);
            _uIItem = uIItem;
            _friendlyName = friendlyName;
        }

        protected static TTBaseUIItem<T> Get(SearchCriteria searchCriteria, string friendlyName,
            UIItem? scope = null, int timeoutInMillisecods = 0)
        {
            return Get(searchCriteria, friendlyName, scope, timeoutInMillisecods);
        }

        public virtual void Click()
        {
            Report.Output(Level.Debug, $"Click on {_friendlyName} {nameof(T)} is performed");
            _uIItem.Click();
        }

        public virtual void Focus()
        {
            Report.Output(Level.Debug, $"Focus on {_friendlyName} {nameof(T)} is performed");
            _uIItem.Focus();
        }

        public virtual void DoubleClick()
        {
            Report.Output(Level.Debug, $"DoubleClick on {_friendlyName} {nameof(T)} is performed");
            _uIItem.Focus();
        }

        public virtual void RightClick()
        {
            Report.Output(Level.Debug, $"RightClick on {_friendlyName} {nameof(T)} is performed");
            _uIItem.Focus();
        }
    }
}

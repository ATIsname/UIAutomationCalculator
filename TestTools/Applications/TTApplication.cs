using TestStack.White;
using TestTools.UIItems;

namespace TestTools.Applications
{
    public class TTApplication
    {
        private Application application;
        private TTWindow mainWindow;

        public Application Application { get => application; }

        public TTWindow MainWindow { get => mainWindow; }

        public TTApplication(Application application, TTWindow mainWindow)
        {
            this.application = application;
            this.mainWindow = mainWindow;
        }
    }
}

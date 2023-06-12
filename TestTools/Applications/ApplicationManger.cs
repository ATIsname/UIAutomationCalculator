using System.Diagnostics;
using TestStack.White;
using TestTools.Applications;
using TestTools.Loggers;
using TestTools.UIItems;
using TestTools.Utils;

public static class ApplicationManger
{
    private static TTApplication? _currentApp;
    private static List<TTApplication> _usedApps;

    public static TTApplication CurrentApp => _currentApp;

    public static TTApplication Launch(string applicationPath, string mainWindow)
    {
        var app = Application.Launch(applicationPath);
        _currentApp = new TTApplication(app, TTWindow.Get(app.GetWindow(mainWindow), mainWindow));
        _usedApps.Add(_currentApp);
        Report.Output(Level.Information, "Application is launched");
        return _currentApp;
    }

    public static void Attach(Process process, string mainWindow)
    {
        var app = Application.Attach(process);
        _usedApps.Add(new TTApplication(app, TTWindow.Get(app.GetWindow(mainWindow), mainWindow)));
        Report.Output(Level.Information, $"Application {app.Name} is attached");
    }

    public static void Attach(string processName, string mainWindow)
    {
        var app = Application.Attach(processName);
        _usedApps.Add(new TTApplication(app, TTWindow.Get(app.GetWindow(mainWindow), mainWindow)));
        Report.Output(Level.Information, $"Application {app.Name} is attached");
    }

    public static void Attach(int processId, string mainWindow)
    {
        var app = Application.Attach(processId);
        _usedApps.Add(new TTApplication(app, TTWindow.Get(app.GetWindow(mainWindow), mainWindow)));
        Report.Output(Level.Information, $"Application {app.Name} is attached");
    }

    public static void Close()
    {
        if (_currentApp is null)
        {
            Report.Output(Level.Warning, "There are no started applications");
            return;
        }
        Close(_currentApp, Timeouts.Small);
    }

    public static void Close(string name)
    {
        Close(_usedApps.First(app => app.Application.Name.Equals(name)), Timeouts.Small);
    }

    public static void CloseAll()
    {
        _usedApps.ForEach(app => Close());
    }

    public static void Close(TTApplication app, int timeoutMilliseconds = 0)
    {
        Report.Output(Level.Information, $"Application {app.Application.Name} closure is started");
        app?.Application.Kill();
        app?.Application.Dispose();
        TTWait.Until(() => app.Application.Process.HasExited
            && app.Application.GetWindows().Count.Equals(0), timeoutMilliseconds);
        _usedApps.Remove(app);
        if (_currentApp.Equals(app))
        {
            _currentApp = _usedApps.LastOrDefault();
        }
        Report.Output(Level.Information, $"Application {app.Application.Name} is closed");
    }
}
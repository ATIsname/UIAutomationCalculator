using NLog;
using TestTools.Loggers;

public static class Report
{
    private static Logger logger = LogManager.GetCurrentClassLogger();

    public static void Output(Level level, string message)
    {
        switch (level)
        {
            case Level.Debug:
                logger.Debug(message);
                break;
            case Level.Information:
                logger.Info(message);
                break;
            case Level.Warning:
                logger.Warn(message);
                break;
            case Level.Error:
                logger.Error(message);
                break;
            default:
                throw new ArgumentException("Report level is not supported", level.ToString());
        }
    }
}
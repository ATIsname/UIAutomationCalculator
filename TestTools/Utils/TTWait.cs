using TestStack.White.Utility;

namespace TestTools.Utils
{
    public static class TTWait
    {
        public static bool Until(Func<bool> getMethod, int timeoutInMilliseconds)
        {
            return Retry.For(getMethod, TimeSpan.FromMilliseconds(timeoutInMilliseconds));
        }

        public static T Until<T>(Func<T> getMethod, int timeoutInMilliseconds)
        {
            return Retry.For(getMethod, TimeSpan.FromMilliseconds(timeoutInMilliseconds));
        }

        public static void Until(Action action, int timeoutInMilliseconds)
        {
            Retry.For(action, TimeSpan.FromMilliseconds(timeoutInMilliseconds));
        }

        public static void Sleep(int timeoutInMilliseconds)
        {
            Thread.Sleep(timeoutInMilliseconds);
        }
    }
}

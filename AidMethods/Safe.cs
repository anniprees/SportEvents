using System;

namespace AidMethods
{
    public static class Safe
    {
        private static readonly object key = new object();
        
        public static void Run(Action action, bool useLock = false)
        {
            if (useLock) lockedRun(action);
            else run(action);
        }

        private static void lockedRun(Action action)
        {
            lock (key)
            {
                run(action);
            }
        }

        private static void run(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }

    }

}
using System;
using System.Reflection;
using log4net;
using log4net.Config;

namespace Writter
{
    internal class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            Log.Debug("Start");

            Log.Info("The writter is running ...");

            try
            {
                throw new Exception("Fatal exceptio");
            }
            catch (Exception e)
            {
                Log.Fatal("Fatal message", e);
            }


            Log.Debug("End");
        }
    }
}
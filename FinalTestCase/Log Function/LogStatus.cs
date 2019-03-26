using System;
using System.IO;

namespace FinalTestCase
{
    public static class LogStatus
    {
        public static void LogError(string stepName, string testName, string datum, string errorMessage)
        {
            string basePath = @"C:\";
            string logPath = basePath + datum;
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            using (StreamWriter writer = new StreamWriter(logPath + @"\" + "LogStatusError.txt", true))
            {
                writer.WriteLine("Exception - " + DateTime.Now);
                writer.WriteLine(" {0} - {1} - ERROR : {2}", testName, stepName, errorMessage);
            }
        }

        public static void LogSuccess(string stepName, string testName, string datum)
        {
            string basePath = @"C:\";
            string logPath = basePath + datum;
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            using (StreamWriter writer = new StreamWriter(logPath + @"\" + "LogStatusSuccess.txt", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(" {0} - {1} - SUCCESS", testName, stepName);
                writer.WriteLine();
            }
        }
    }
}


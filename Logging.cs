// Logging.cs

using System;
using System.IO;

namespace bot_APP_
{
    public static class Logging
    {
        // 日志文件夹路径
        private static readonly string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");

        public static void Log(string message, string fileName)
        {
            try
            {
                // 确保日志文件夹存在,如果不存在则创建
                if (!Directory.Exists(LogFolderPath))
                {
                    Directory.CreateDirectory(LogFolderPath);
                }

                // 生成日志文件路径
                string logFilePath = Path.Combine(LogFolderPath, fileName);

                // 将日志消息写入文件,并附加时间戳
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                // 如果日志记录失败,我们在控制台输出错误信息
                Console.Error.WriteLine($"Error writing log: {ex.Message}");
            }
        }

        public static void LogInfo(string message, string fileName = "info.log")
        {
            Log($"INFO: {message}", fileName);
        }

        public static void LogWarning(string message, string fileName = "warning.log")
        {
            Log($"WARNING: {message}", fileName);
        }

        public static void LogError(string message, string fileName = "error.log")
        {
            Log($"ERROR: {message}", fileName);
        }
    }
}
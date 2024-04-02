// ProcessSave.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace crawer
{
#pragma warning disable S1118 // Utility classes should not have public constructors

    public class ProcessSave
    {
        public static void SaveProcessedText(string text, string outputFolder = "process_Output")
        {
            string v = $"Output_{DateTime.Now:yyyyMMdd_HHmmss}.text";
            SaveProcessedText(text, v: v, outputFolder);
        }

        public static void SaveProcessedText(string text, string v, string outputFolder = "process_Output")
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, outputFolder);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = v;
                string filePath = Path.Combine(folderPath, fileName);

                File.WriteAllText(filePath, text);
                MessageBox.Show($"文件已保存至: {filePath}", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存文件时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void SaveProcessedText(object value)
        {
            throw new NotImplementedException();
        }

        // 这里您可以添加处理文本的其他方法
    }
}
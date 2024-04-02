// FilePath: ProcessWords.cs
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bot_APP_
{
    public static class ProcessWords
    {
        public static string ProcessText(string text, string prefix, string suffix)
        {
            var splitRegex = new Regex(@"\r\n|\n|\r", RegexOptions.Compiled);

            var processedLines = splitRegex.Split(text)
                                           .Select(line => string.IsNullOrWhiteSpace(line)
                                                           ? line
                                                           : $"{prefix} {line.Trim()} {suffix}");

            return string.Join(Environment.NewLine, processedLines);
        }

        public static void ProcessWordsMethod(RichTextBox inputBox, RichTextBox resultBox, TextBox prefixBox, TextBox suffixBox)
        {
            try
            {
                Logging.LogInfo("Starting to process words...");

                string inputText = GetInputText(inputBox);

                // Check if input is empty and show message if it is
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("当前输入内容为空，请输入内容后再执行操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop further processing
                }

                string prefix = prefixBox.Text;
                string suffix = suffixBox.Text;

                string formattedOutput = ProcessText(inputText, prefix, suffix);

                if (string.IsNullOrEmpty(formattedOutput))
                {
                    MessageBox.Show("Formatted output is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                resultBox.Text = formattedOutput;

                ProcessSave.SaveProcessedText(formattedOutput, "process_Output/ProcessWords_Output");

                Logging.LogInfo("Words processed successfully.");
            }
            catch (Exception ex)
            {
                Logging.LogError($"Error processing words: {ex.Message}");
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetInputText(RichTextBox inputBox)
        {
            return inputBox.Text.Trim();
        }
    }
}
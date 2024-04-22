// FilePath: ProcessEmojis.cs

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bot_APP_
{
    public static class ProcessEmojis
    {
        public static void ProcessEmojisMethod (RichTextBox input, RichTextBox output, TextBox prefixBox, TextBox suffixBox)
        {
            try
            {
                string inputText = input.Text;

                // Check if input text is empty
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show(@"当前输入内容为空，请输入内容后再执行操作", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop further processing
                }

                string prefix = prefixBox.Text;
                string suffix = suffixBox.Text;

                var emojiPattern = new Regex(@"([\uD800-\uDBFF][\uDC00-\uDFFF])([\uFE0F\u200D][\u200D\uFE0F]*[\uD800-\uDBFF][\uDC00-\uDFFF])*");

                // Check if the input contains any emojis
                if (!emojiPattern.IsMatch(inputText))
                {
                    MessageBox.Show(@"当前输入内容非图像emoji，不做任何操作，请更换内容后执行", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Logging.LogInfo("Start processing emojis");

                string result = emojiPattern.Replace(inputText, match => $"{prefix}{match.Value}{suffix}\n");

                output.Text = result;

                ProcessSave.SaveProcessedText(result, "process_Output/ProcessEmojis_Output");

                Logging.LogInfo("Completed processing emojis");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"An error occurred: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logging.LogError($"Error processing emojis: {ex.Message}");
            }
        }
    }
}
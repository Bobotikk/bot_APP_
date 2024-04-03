using System;
using System.Windows.Forms;

namespace bot_APP_
{
    public static class ProcessSymbols
    {
        // 由于 ProcessAndFormatText 已经做好了处理文本的工作，这里直接调用即可。
        public static void Process(RichTextBox inputBox, RichTextBox resultBox, TextBox prefixBox, TextBox suffixBox)
        {
            if (prefixBox is null || suffixBox is null)
            {
                throw new ArgumentNullException(nameof(prefixBox), "PrefixBox or SuffixBox is null.");
            }

            try
            {
                Logging.LogInfo("Starting to process symbols...");

                // 调用 TextProcessor 中的方法处理和格式化文本
                TextProcessor.ProcessAndFormatText(inputBox, resultBox);

                // 由于 ProcessAndFormatText 方法已经处理了输入文本并更新了 resultBox，
                // 这里不需要再次设置 resultBox 的文本。

                // 假定 ProcessSave.SaveProcessedText 和 Logging 类已实现
                // 这里仅仅是为了展示，具体实现可能需要调整
                Logging.LogInfo("Symbols processed successfully.");
            }
            catch (Exception ex)
            {
                Logging.LogError("Error processing symbols: " + ex.Message);
                MessageBox.Show("An error occurred while processing symbols: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
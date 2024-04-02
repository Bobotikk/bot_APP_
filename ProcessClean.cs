// FilePath: ProcessClean.cs
using System;
using System.Windows.Forms;

namespace bot_APP_
{
    public static class ProcessClean
    {
        // 清理输入和输出文本框的内容
        public static void CleanTxtINandOut(RichTextBox inputBox, RichTextBox outputBox)
        {
            inputBox.Clear();
            outputBox.Clear();
        }

        // 清理前缀和后缀文本框的内容
        public static void CleanPrefixandSuffix(TextBox prefixBox, TextBox suffixBox)
        {
            prefixBox.Clear();
            suffixBox.Clear();
        }

        // 新增方法：清理所有文本框的内容
        public static void CleanAllText(RichTextBox inputBox, RichTextBox outputBox, TextBox prefixBox, TextBox suffixBox)
        {
            inputBox.Clear();
            outputBox.Clear();
            prefixBox.Clear();
            suffixBox.Clear();
        }

        internal static void CleanAllText()
        {
            throw new NotImplementedException();
        }

        internal static void CleanAllText(RichTextBox richTextBoxOutput)
        {
            throw new NotImplementedException();
        }
    }
}
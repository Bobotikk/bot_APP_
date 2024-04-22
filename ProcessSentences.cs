// ProcessSentences.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bot_APP_
{
    public static class ProcessSentences
    {
        private static readonly Regex SentenceEndPattern = new Regex(@"(?<=[.!?。！？])\s+", RegexOptions.Compiled);

        public static void Process (RichTextBox inputBox, RichTextBox resultBox, TextBox prefixEntry, TextBox suffixEntry)
        {
            try
            {
                Logging.LogInfo("Starting to process sentences...");

                string inputText = inputBox.Text;
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show(@"当前输入内容为空，请输入内容后再执行操作", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // 终止进一步处理
                }

                // 新增检查：验证是否包含句子结束符
                if (!ContainsSentenceEndSymbols(inputText))
                {
                    MessageBox.Show(@"当前输入内容非句符内容，请输入正确文本以后进行操作", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // 终止进一步处理
                }

                string prefix = prefixEntry?.Text ?? "";
                string suffix = suffixEntry?.Text ?? "";

                var sentenceList = SplitSentences(inputText);
                string formattedOutput = string.Join(Environment.NewLine,
                    sentenceList.Select(sentence => $"{prefix}{sentence.Trim()}{suffix}"));

                resultBox.Clear();
                resultBox.Text = formattedOutput.Trim();

                // 使用 ProcessSave 来保存文件
                ProcessSave.SaveProcessedText(formattedOutput.Trim(), "process_Output/ProcessSentences_Output");

                Logging.LogInfo("Sentences processed successfully.");
            }
            catch (Exception ex)
            {
                Logging.LogError("Error processing sentences: " + ex.Message);
                MessageBox.Show("An error occurred while processing sentences: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string[] SplitSentences (string text)
        {
            Logging.LogInfo("Splitting sentences...");

            string[] sentences = SentenceEndPattern.Split(text)
                .Where(sentence => !string.IsNullOrWhiteSpace(sentence))
                .ToArray();

            Logging.LogInfo($"Found {sentences.Length} sentences.");

            return sentences;
        }

        private static bool ContainsSentenceEndSymbols (string text)
        {
            // 英文和中文句子结束符
            var endSymbolsPattern = new Regex(@"[.!?。！？]");
            return endSymbolsPattern.IsMatch(text);
        }
    }
}
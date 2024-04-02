using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace bot_APP_
{
    public static class ProcessSymbols
    {
        private static readonly Regex SymbolPattern = new Regex(@"[\u4e00-\u9fff\p{P}\p{S}\d]+", RegexOptions.Compiled);
        private static readonly Regex CJKUnifiedIdeographsPattern = new Regex(@"[\u4e00-\u9fff]", RegexOptions.Compiled);

        public static void Process(RichTextBox inputBox, RichTextBox resultBox, TextBox prefixBox, TextBox suffixBox)
        {
            if (prefixBox is null || suffixBox is null)
            {
                throw new ArgumentNullException(nameof(prefixBox), "PrefixBox or SuffixBox is null.");
            }

            try
            {
                Logging.LogInfo("Starting to process symbols...");

                string inputText = inputBox.Text;

                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("当前输入内容为空,请输入内容后再执行操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 直接对 JSON 文本进行格式化处理
                string formattedText = FormatJsonText(inputText);

                resultBox.Clear();
                resultBox.Text = formattedText;

                ProcessSave.SaveProcessedText(formattedText, "process_Output/ProcessSymbols_Output");

                Logging.LogInfo("Symbols processed successfully.");
            }
            catch (Exception ex)
            {
                Logging.LogError("Error processing symbols: " + ex.Message);
                MessageBox.Show("An error occurred while processing symbols: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FormatJsonText(string jsonText)
        {
            var jsonObject = JsonConvert.DeserializeObject<JToken>(jsonText);
            var sb = new System.Text.StringBuilder();

            void ProcessToken(JToken token)
            {
                switch (token.Type)
                {
                    case JTokenType.Object:
                        foreach (var child in token.Children<JProperty>())
                        {
                            ProcessToken(child.Value);
                        }
                        break;

                    case JTokenType.Array:
                        foreach (var child in token.Children())
                        {
                            ProcessToken(child);
                        }
                        break;

                    case JTokenType.Property:
                        ProcessToken(((JProperty)token).Value);
                        break;

                    default:
                        var value = token.ToString();
                        ProcessValue(value);
                        break;
                }
            }

            void ProcessValue(string value)
            {
                // 第一次移除所有符号和中文字符
                string processedValue = SymbolPattern.Replace(value, "");

                // 对于那些长字符串，我们基于逗号进一步分割它们
                var parts = processedValue.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {
                    var trimmedPart = part.Trim();
                    if (!string.IsNullOrEmpty(trimmedPart))
                    {
                        sb.AppendLine($"__{trimmedPart}__");
                    }
                }
            }

            ProcessToken(jsonObject);
            return sb.ToString().Trim();
        }
    }
}
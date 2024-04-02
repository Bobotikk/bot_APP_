// ProcessSymbols.cs

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using System.Web;
using System.IO;

namespace bot_APP_
{
    public static class ProcessSymbols
    {
        private static readonly Regex SymbolPattern = new Regex(@"[\u4e00-\u9fff\p{P}\p{S}\d]+", RegexOptions.Compiled);

        public static void Process(RichTextBox inputBox, RichTextBox resultBox, TextBox prefixBox, TextBox suffixBox)
        {
            if (prefixBox is null)
            {
                throw new ArgumentNullException(nameof(prefixBox));
            }

            if (suffixBox is null)
            {
                throw new ArgumentNullException(nameof(suffixBox));
            }

            try
            {
                Logging.LogInfo("Starting to process symbols...");

                string inputText = inputBox.Text;

                // Check if the input text is empty
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("当前输入内容为空，请输入内容后再执行操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop further processing
                }

                string processedText = ProcessText(inputText);

                // Further processing for different formats
                string formattedText = FormatTextAsJsonHtml(processedText);

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

        private static string ProcessText(string text)
        {
            Logging.LogInfo("Processing text...");

            string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var processedLines = lines.Select(line =>
            {
                return SymbolPattern.Replace(line, " ").Trim();
            });

            string processedText = string.Join(Environment.NewLine, processedLines);

            Logging.LogInfo("Text processed.");
            return processedText;
        }

        private static string FormatTextAsJsonHtml(string text)
        {
            try
            {
                // 尝试将文本格式化为 JSON
                var jsonObject = JsonConvert.DeserializeObject(text);
                return JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
            }
            catch (JsonException)
            {
                try
                {
                    // 如果不是 JSON，尝试格式化为 HTML
                    return FormatHtml(text);
                }
                catch (XmlException)
                {
                    // 如果既不是有效的 JSON 也不是有效的 HTML，返回原始文本
                    return text;
                }
            }
        }

        private static string FormatHtml(string html)
        {
            var document = new XmlDocument();
            document.LoadXml(html);
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw)
            {
                Formatting = System.Xml.Formatting.Indented // Specify the full namespace for System.Xml.Formatting
            };
            document.WriteTo(xw);
            return System.Net.WebUtility.HtmlDecode(sw.ToString());
        }
    }
}
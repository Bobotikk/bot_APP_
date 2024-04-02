using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace crawer
{
    public static class ProcessNumbers
    {
        private static readonly Regex NumRegex = new Regex(@"(\d+)");

        public static void Process(IButtonControl acceptButton, TextBox textBoxMidjourneyArgument, TextBox richTextBoxTxtOut, NumericUpDown numericUpDownNuberSet, NumericUpDown numericUpDownNumberAdd)
        {
            if (acceptButton is null)
            {
                throw new ArgumentNullException(nameof(acceptButton));
            }

            string inputText = textBoxMidjourneyArgument.Text;
            int increment = (int)numericUpDownNumberAdd.Value;
            int count = (int)numericUpDownNuberSet.Value;

            string processedText = ProcessText(inputText, count, increment);
            richTextBoxTxtOut.Text = processedText;
        }

        private static string ProcessText(string inputText, int count, int increment)
        {
            var outputLines = new List<string>();
            foreach (string line in inputText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
            {
                string processedLine = line;
                for (int i = 0; i < count; i++)
                {
                    processedLine = NumRegex.Replace(processedLine, match =>
                    {
                        if (int.TryParse(match.Groups[1].Value, out int number))
                        {
                            return (number + increment).ToString();
                        }
                        return match.Value;
                    });
                    outputLines.Add(processedLine);
                }
            }
            return string.Join(Environment.NewLine, outputLines);
        }
    }
}
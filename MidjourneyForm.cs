using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bot_APP_
{
    public partial class MidjourneyForm : Form
    {
        private MainForm mainForm;

        public MidjourneyForm (MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click (object sender, EventArgs e)
        {
            // 检查文本输入框是否有内容
            if (!string.IsNullOrWhiteSpace(textBoxMJForm.Text))
            {
                // 清除文本输入框的内容
                textBoxMJForm.Clear();
            }

            // 检查富文本框是否有内容
            if (!string.IsNullOrWhiteSpace(richTextBoxOutput.Text))
            {
                // 清除富文本框的内容
                richTextBoxOutput.Clear();
            }

            // 将增量和结果数量设置为0
            numericUpDownaADD.Value = 0;
            numericUpDownResult.Value = 0;
        }

        private void buttonMidjourney_Click (object sender, EventArgs e)
        {
            // 检查输入内容是否为空
            if (string.IsNullOrWhiteSpace(textBoxMJForm.Text))
            {
                MessageBox.Show(@"当前输入内容为空,请输入内容后再执行操作", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 停止进一步处理
            }

            // 检查增量和结果数量是否小于0
            if (numericUpDownaADD.Value < 0 || numericUpDownResult.Value < 0)
            {
                MessageBox.Show(@"输入参数有误,增量和结果数量只能为大于等于0的值", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 停止进一步处理
            }

            // 提取所有数字,并记录其在原字符串中的位置
            var matches = Regex.Matches(textBoxMJForm.Text, @"(.*?)(\d+)");
            if (matches.Count > 0)
            {
                // 获取增量和结果数量
                int increment = (int)numericUpDownaADD.Value;
                int numberOfResults = (int)numericUpDownResult.Value;

                StringBuilder sb = new StringBuilder();

                // 逐行生成每组数字的结果
                for (int i = 0; i < numberOfResults; i++)
                {
                    StringBuilder lineBuilder = new StringBuilder();

                    foreach (Match match in matches)
                    {
                        string prefix = match.Groups[1].Value;
                        if (int.TryParse(match.Groups[2].Value, out int startValue))
                        {
                            // 计算增量后的新值
                            int newValue = startValue + i * increment;
                            lineBuilder.Append($"{prefix}{newValue}");
                        }
                    }

                    // 添加该行到结果中
                    sb.AppendLine(lineBuilder.ToString());
                }

                // 显示结果
                richTextBoxOutput.Text = sb.ToString();
            }
            else
            {
                // 输入无效时的处理
                richTextBoxOutput.Text = "未找到有效数字,请输入包含数字的文本!";
            }
        }

        private void BtnMJSendToMainFormTex_Click (object sender, EventArgs e)
        {
            // 获取 richTextBoxOutput 的文本内容
            string outputText = richTextBoxOutput.Text;

            // 将内容设置到 mainForm 的 richTextBoxTxtIn
            mainForm.richTextBoxTxtIn.Text = outputText;
        }
    }
}
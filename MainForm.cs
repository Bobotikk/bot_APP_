using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using bot_APP_;


namespace bot_APP_
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> presets = new Dictionary<string, string>();
        public MainForm ()
        {
            InitializeComponent();
            // 示例：在 MainForm 构造函数中记录一条信息
            Logging.LogInfo("MainForm 初始化");
        }

        public void SetRichTextBoxTxtInContent (string content)
        {
            richTextBoxTxtIn.Text = content;
        }

        private void BtnEmoji_Click (object sender, EventArgs e)
        {
            ProcessEmojis.ProcessEmojisMethod(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnImportFile_Click (object sender, EventArgs e)
        {
            ImportFile.ImportFileToTextBox(richTextBoxTxtIn);
        }

        private void BtnWords_Click (object sender, EventArgs e)
        {
            // 调用 ProcessWordsMethod 方法
            // richTextBoxTxtIn 是输入框，richTextBoxTxtOut 是结果框
            // textBoxPrefix 和 textBoxSuffix 是前缀和后缀输入框
            ProcessWords.ProcessWordsMethod(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnSentence_Click (object sender, EventArgs e)
        {
            ProcessSentences.Process(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnChinese_Click (object sender, EventArgs e)
        {
            ProcessSymbols.Process(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            MidjourneyForm midjourneyForm = new MidjourneyForm(this); // 创建 MidjourneyForm 窗体,MidjourneyForm 是一个类的名称,表示一个窗体。midjourneyForm 是该类的一个实例变量。new MidjourneyForm(this) 是创建该类实例的构造函数调用。this 表示当前的 MainForm 实例,它被作为参数传递给 MidjourneyForm 的构造函数。
            midjourneyForm.Show(); // 显示 MidjourneyForm 窗体
        }

        private void BtnSendToInput_Click (object sender, EventArgs e)
        {
            // 将 richTextBoxTxtOut 的内容复制到 richTextBoxTxtIn
            richTextBoxTxtIn.Text = richTextBoxTxtOut.Text;
        }

        private void BtnCleanTxtINandOut_Click (object sender, EventArgs e)
        {
            // 调用 ProcessClean 类的 CleanTxtINandOut 方法
            ProcessClean.CleanTxtINandOut(richTextBoxTxtIn, richTextBoxTxtOut);
        }

        private void BtnAllClean_Click (object sender, EventArgs e)
        {
            // 调用 ProcessClean 类的 CleanAllText 方法，清理所有文本框
            ProcessClean.CleanAllText(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnCleanPrefixandSuffix_Click (object sender, EventArgs e)
        {
            // 调用 ProcessClean 类的 CleanPrefixandSuffix 方法
            ProcessClean.CleanPrefixandSuffix(textBoxPrefix, textBoxSuffix);
        }

  

        private void BtnSendMidjourney_Click (object sender, EventArgs e)
        {
            string url = txBoxMidjourney.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("请输入有效的链接。", "无效链接", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSendMidjourney_Click_1 (object sender, EventArgs e)
        {
            try
            {
                // 获取 txBoxMidjourney 文本框中的链接
                string url = txBoxMidjourney.Text;

                // 验证 URL 是否为空
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show(@"链接不能为空", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 验证 URL 格式
                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    MessageBox.Show(@"链接格式不正确", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 使用默认浏览器打开链接
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"无法打开链接: " + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnPreset_Click_1 (object sender, EventArgs e)
        {
            PresetForm presetForm = new PresetForm(presets);
            presetForm.Owner = this;
            presetForm.ShowDialog();
        }

        public void SetPreset (string preset)
        {
            textBoxSuffix.Text = preset;
        }

        private void BtnOneKey_Click (object sender, EventArgs e)
        {
            try
            {
                // 获取当前应用程序的启动目录
                string appPath = Application.StartupPath;

                // 构建要启动的.exe应用程序的完整路径
                string exePath = System.IO.Path.Combine(appPath, "oneKey_v5.exe");

                // 验证文件是否存在
                if (!System.IO.File.Exists(exePath))
                {
                    MessageBox.Show(@"无法找到文件: " + exePath, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 使用Process类启动.exe应用程序
                Process.Start(exePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"无法启动应用程序: " + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImage_Click (object sender, EventArgs e)
        {

            try
            {
                // 获取当前应用程序的启动目录
                string appPath = Application.StartupPath;

                // 构建要启动的.exe应用程序的完整路径
                string exePath = System.IO.Path.Combine(appPath, "SDPrompt.exe");

                // 验证文件是否存在
                if (!System.IO.File.Exists(exePath))
                {
                    MessageBox.Show(@"无法找到文件: " + exePath, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 使用Process类启动.exe应用程序
                Process.Start(exePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"无法启动应用程序: " + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using crawer;

namespace bot_APP_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // 示例：在 MainForm 构造函数中记录一条信息
            Logging.LogInfo("MainForm 初始化");
        }

        public void SetRichTextBoxTxtInContent(string content)
        {
            richTextBoxTxtIn.Text = content;
        }

        private void BtnEmoji_Click(object sender, EventArgs e)
        {
            ProcessEmojis.ProcessEmojisMethod(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnImportFile_Click(object sender, EventArgs e)
        {
            ImportFile.ImportFileToTextBox(richTextBoxTxtIn);
        }

        private void BtnWords_Click(object sender, EventArgs e)
        {
            // 调用 ProcessWordsMethod 方法
            // richTextBoxTxtIn 是输入框，richTextBoxTxtOut 是结果框
            // textBoxPrefix 和 textBoxSuffix 是前缀和后缀输入框
            ProcessWords.ProcessWordsMethod(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnSentence_Click(object sender, EventArgs e)
        {
            ProcessSentences.Process(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        private void BtnChinese_Click(object sender, EventArgs e)
        {
            ProcessSymbols.Process(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }

        // private 是一个访问修饰符,表示该方法只能在当前类内部访问。void 表示该方法没有返回值。button1_Click 是该方法的名称,用于响应按钮的点击事件。object sender 和 EventArgs e 是该方法的参数,用于传递事件的相关信息。在本例中,sender 表示触发该事件的对象,即按钮本身,而 e 包含了事件相关的其他数据。
        private void button1_Click(object sender, EventArgs e)
        {
            MidjourneyForm midjourneyForm = new MidjourneyForm(this); //   创建 MidjourneyForm 窗体,MidjourneyForm 是一个类的名称,表示一个窗体。midjourneyForm 是该类的一个实例变量。new MidjourneyForm(this) 是创建该类实例的构造函数调用。this 表示当前的 MainForm 实例,它被作为参数传递给 MidjourneyForm 的构造函数。
            midjourneyForm.Show();         // 显示 MidjourneyForm 窗体
        }
    }
}
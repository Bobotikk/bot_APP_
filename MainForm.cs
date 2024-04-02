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

        private void BtnEmoji_Click(object sender, EventArgs e)
        {
            ProcessEmojis.ProcessEmojisMethod(richTextBoxTxtIn, richTextBoxTxtOut, textBoxPrefix, textBoxSuffix);
        }
    }
}
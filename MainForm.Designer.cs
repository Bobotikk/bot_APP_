using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bot_APP_
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
         
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
     

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxTxtIn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTxtOut = new System.Windows.Forms.RichTextBox();
            this.BtnPreset = new System.Windows.Forms.Button();
            this.BtnImportFile = new System.Windows.Forms.Button();
            this.BtnEmoji = new System.Windows.Forms.Button();
            this.BtnWords = new System.Windows.Forms.Button();
            this.BtnSentence = new System.Windows.Forms.Button();
            this.BtnChinese = new System.Windows.Forms.Button();
            this.BtnCleanPrefixandSuffix = new System.Windows.Forms.Button();
            this.BtnCleanTxtINandOut = new System.Windows.Forms.Button();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSendToInput = new System.Windows.Forms.Button();
            this.BtnSendMidjourney = new System.Windows.Forms.Button();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.BtnAllClean = new System.Windows.Forms.Button();
            this.BtnOneKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxTxtIn
            // 
            this.richTextBoxTxtIn.Location = new System.Drawing.Point(49, 83);
            this.richTextBoxTxtIn.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTxtIn.Name = "richTextBoxTxtIn";
            this.richTextBoxTxtIn.Size = new System.Drawing.Size(338, 166);
            this.richTextBoxTxtIn.TabIndex = 1;
            this.richTextBoxTxtIn.Text = "";
            // 
            // richTextBoxTxtOut
            // 
            this.richTextBoxTxtOut.Location = new System.Drawing.Point(41, 409);
            this.richTextBoxTxtOut.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTxtOut.Name = "richTextBoxTxtOut";
            this.richTextBoxTxtOut.ReadOnly = true;
            this.richTextBoxTxtOut.Size = new System.Drawing.Size(459, 167);
            this.richTextBoxTxtOut.TabIndex = 0;
            this.richTextBoxTxtOut.Text = "";
            // 
            // BtnPreset
            // 
            this.BtnPreset.Location = new System.Drawing.Point(412, 82);
            this.BtnPreset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPreset.Name = "BtnPreset";
            this.BtnPreset.Size = new System.Drawing.Size(88, 33);
            this.BtnPreset.TabIndex = 2;
            this.BtnPreset.Text = "预设参数";
            this.BtnPreset.UseVisualStyleBackColor = true;
            // 
            // BtnImportFile
            // 
            this.BtnImportFile.Location = new System.Drawing.Point(412, 123);
            this.BtnImportFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportFile.Name = "BtnImportFile";
            this.BtnImportFile.Size = new System.Drawing.Size(88, 33);
            this.BtnImportFile.TabIndex = 3;
            this.BtnImportFile.Text = "文件导入";
            this.BtnImportFile.UseVisualStyleBackColor = true;
            this.BtnImportFile.Click += new System.EventHandler(this.BtnImportFile_Click);
            // 
            // BtnEmoji
            // 
            this.BtnEmoji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmoji.Location = new System.Drawing.Point(46, 310);
            this.BtnEmoji.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmoji.Name = "BtnEmoji";
            this.BtnEmoji.Size = new System.Drawing.Size(115, 30);
            this.BtnEmoji.TabIndex = 11;
            this.BtnEmoji.Text = "Emoji格式化";
            this.BtnEmoji.UseVisualStyleBackColor = true;
            this.BtnEmoji.Click += new System.EventHandler(this.BtnEmoji_Click);
            // 
            // BtnWords
            // 
            this.BtnWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWords.Location = new System.Drawing.Point(158, 310);
            this.BtnWords.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWords.Name = "BtnWords";
            this.BtnWords.Size = new System.Drawing.Size(115, 30);
            this.BtnWords.TabIndex = 12;
            this.BtnWords.Text = "字符格式化";
            this.BtnWords.UseVisualStyleBackColor = true;
            this.BtnWords.Click += new System.EventHandler(this.BtnWords_Click);
            // 
            // BtnSentence
            // 
            this.BtnSentence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSentence.Location = new System.Drawing.Point(272, 310);
            this.BtnSentence.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSentence.Name = "BtnSentence";
            this.BtnSentence.Size = new System.Drawing.Size(115, 30);
            this.BtnSentence.TabIndex = 13;
            this.BtnSentence.Text = "句符格式化";
            this.BtnSentence.UseVisualStyleBackColor = true;
            this.BtnSentence.Click += new System.EventHandler(this.BtnSentence_Click);
            // 
            // BtnChinese
            // 
            this.BtnChinese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChinese.Location = new System.Drawing.Point(385, 310);
            this.BtnChinese.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChinese.Name = "BtnChinese";
            this.BtnChinese.Size = new System.Drawing.Size(115, 30);
            this.BtnChinese.TabIndex = 14;
            this.BtnChinese.Text = "中文字符处理";
            this.BtnChinese.UseVisualStyleBackColor = true;
            this.BtnChinese.Click += new System.EventHandler(this.BtnChinese_Click);
            // 
            // BtnCleanPrefixandSuffix
            // 
            this.BtnCleanPrefixandSuffix.Location = new System.Drawing.Point(412, 254);
            this.BtnCleanPrefixandSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCleanPrefixandSuffix.Name = "BtnCleanPrefixandSuffix";
            this.BtnCleanPrefixandSuffix.Size = new System.Drawing.Size(88, 33);
            this.BtnCleanPrefixandSuffix.TabIndex = 10;
            this.BtnCleanPrefixandSuffix.Text = "清理前后缀";
            this.BtnCleanPrefixandSuffix.UseVisualStyleBackColor = true;
            this.BtnCleanPrefixandSuffix.Click += new System.EventHandler(this.BtnCleanPrefixandSuffix_Click);
            // 
            // BtnCleanTxtINandOut
            // 
            this.BtnCleanTxtINandOut.Location = new System.Drawing.Point(412, 164);
            this.BtnCleanTxtINandOut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCleanTxtINandOut.Name = "BtnCleanTxtINandOut";
            this.BtnCleanTxtINandOut.Size = new System.Drawing.Size(88, 33);
            this.BtnCleanTxtINandOut.TabIndex = 4;
            this.BtnCleanTxtINandOut.Text = "清理文本";
            this.BtnCleanTxtINandOut.UseVisualStyleBackColor = true;
            this.BtnCleanTxtINandOut.Click += new System.EventHandler(this.BtnCleanTxtINandOut_Click);
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(46, 263);
            this.labelPrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(61, 17);
            this.labelPrefix.TabIndex = 6;
            this.labelPrefix.Text = "前缀参数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "文本输入:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "结果输出:";
            // 
            // BtnSendToInput
            // 
            this.BtnSendToInput.Location = new System.Drawing.Point(40, 599);
            this.BtnSendToInput.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSendToInput.Name = "BtnSendToInput";
            this.BtnSendToInput.Size = new System.Drawing.Size(121, 33);
            this.BtnSendToInput.TabIndex = 22;
            this.BtnSendToInput.Text = "发送到文本输入";
            this.BtnSendToInput.UseVisualStyleBackColor = true;
            this.BtnSendToInput.Click += new System.EventHandler(this.BtnSendToInput_Click);
            // 
            // BtnSendMidjourney
            // 
            this.BtnSendMidjourney.Location = new System.Drawing.Point(169, 599);
            this.BtnSendMidjourney.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSendMidjourney.Name = "BtnSendMidjourney";
            this.BtnSendMidjourney.Size = new System.Drawing.Size(127, 33);
            this.BtnSendMidjourney.TabIndex = 23;
            this.BtnSendMidjourney.Text = "发送到Midjourney";
            this.BtnSendMidjourney.UseVisualStyleBackColor = true;
            this.BtnSendMidjourney.Click += new System.EventHandler(this.BtnSendMidjourney_Click);
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(114, 259);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(99, 24);
            this.textBoxPrefix.TabIndex = 7;
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(220, 263);
            this.labelSuffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(61, 17);
            this.labelSuffix.TabIndex = 8;
            this.labelSuffix.Text = "后缀参数:";
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Location = new System.Drawing.Point(288, 259);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(99, 24);
            this.textBoxSuffix.TabIndex = 9;
            // 
            // BtnAllClean
            // 
            this.BtnAllClean.Location = new System.Drawing.Point(412, 204);
            this.BtnAllClean.Name = "BtnAllClean";
            this.BtnAllClean.Size = new System.Drawing.Size(88, 33);
            this.BtnAllClean.TabIndex = 5;
            this.BtnAllClean.Text = "全部清理";
            this.BtnAllClean.UseVisualStyleBackColor = true;
            this.BtnAllClean.Click += new System.EventHandler(this.BtnAllClean_Click);
            // 
            // BtnOneKey
            // 
            this.BtnOneKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOneKey.Location = new System.Drawing.Point(272, 347);
            this.BtnOneKey.Name = "BtnOneKey";
            this.BtnOneKey.Size = new System.Drawing.Size(228, 30);
            this.BtnOneKey.TabIndex = 18;
            this.BtnOneKey.Text = "一键多开";
            this.BtnOneKey.UseVisualStyleBackColor = true;
            this.BtnOneKey.Click += new System.EventHandler(this.BtnOneKey_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(46, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Midjourney参数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 773);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnOneKey);
            this.Controls.Add(this.BtnAllClean);
            this.Controls.Add(this.textBoxSuffix);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.labelSuffix);
            this.Controls.Add(this.BtnSendMidjourney);
            this.Controls.Add(this.BtnSendToInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCleanTxtINandOut);
            this.Controls.Add(this.BtnCleanPrefixandSuffix);
            this.Controls.Add(this.BtnChinese);
            this.Controls.Add(this.BtnSentence);
            this.Controls.Add(this.BtnWords);
            this.Controls.Add(this.BtnEmoji);
            this.Controls.Add(this.BtnImportFile);
            this.Controls.Add(this.BtnPreset);
            this.Controls.Add(this.richTextBoxTxtOut);
            this.Controls.Add(this.richTextBoxTxtIn);
            this.Font = new System.Drawing.Font("阿里巴巴普惠体 2.0 55 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "AI_小霸王";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxTxtIn;
        private System.Windows.Forms.RichTextBox richTextBoxTxtOut;
        private System.Windows.Forms.Button BtnPreset;
        private System.Windows.Forms.Button BtnImportFile;
        private System.Windows.Forms.Button BtnEmoji;
        private System.Windows.Forms.Button BtnWords;
        private System.Windows.Forms.Button BtnSentence;
        private System.Windows.Forms.Button BtnChinese;
        private System.Windows.Forms.Button BtnCleanPrefixandSuffix;
        private System.Windows.Forms.Button BtnCleanTxtINandOut;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSendToInput;
        private System.Windows.Forms.Button BtnSendMidjourney;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Button BtnAllClean;
        private System.Windows.Forms.Button BtnOneKey;
        private Button button1;
    }
}


using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Diagnostics;
using Newtonsoft.Json.Linq; // 需要安装 Newtonsoft.Json 包

#pragma warning disable CS0414 // Field is assigned but its value is never used

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
        private void InitializeComponent ()
        {
            System.Windows.Forms.Button BtnPP;
            System.Windows.Forms.Button BtnCleanPrefixandSuffix;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxTxtIn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTxtOut = new System.Windows.Forms.RichTextBox();
            this.BtnImportFile = new System.Windows.Forms.Button();
            this.BtnEmoji = new System.Windows.Forms.Button();
            this.BtnWords = new System.Windows.Forms.Button();
            this.BtnSentence = new System.Windows.Forms.Button();
            this.BtnChinese = new System.Windows.Forms.Button();
            this.BtnCleanTxtINandOut = new System.Windows.Forms.Button();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.BtnSendToInput = new System.Windows.Forms.Button();
            this.BtnSendMidjourney = new System.Windows.Forms.Button();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.BtnAllClean = new System.Windows.Forms.Button();
            this.BtnOneKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txBoxMidjourney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPreset = new System.Windows.Forms.Button();
            this.BtnImage = new System.Windows.Forms.Button();
            BtnPP = new System.Windows.Forms.Button();
            BtnCleanPrefixandSuffix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxTxtIn
            // 
            this.richTextBoxTxtIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBoxTxtIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTxtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTxtIn.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBoxTxtIn.Location = new System.Drawing.Point(41, 117);
            this.richTextBoxTxtIn.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTxtIn.Name = "richTextBoxTxtIn";
            this.richTextBoxTxtIn.Size = new System.Drawing.Size(338, 127);
            this.richTextBoxTxtIn.TabIndex = 1;
            this.richTextBoxTxtIn.Text = "输入描述词";
            // 
            // richTextBoxTxtOut
            // 
            this.richTextBoxTxtOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBoxTxtOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTxtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxTxtOut.Location = new System.Drawing.Point(33, 391);
            this.richTextBoxTxtOut.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTxtOut.Name = "richTextBoxTxtOut";
            this.richTextBoxTxtOut.ReadOnly = true;
            this.richTextBoxTxtOut.Size = new System.Drawing.Size(459, 141);
            this.richTextBoxTxtOut.TabIndex = 0;
            this.richTextBoxTxtOut.Text = "";
            // 
            // BtnPP
            // 
            BtnPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnPP.Location = new System.Drawing.Point(404, 116);
            BtnPP.Margin = new System.Windows.Forms.Padding(4);
            BtnPP.Name = "BtnPP";
            BtnPP.Size = new System.Drawing.Size(88, 33);
            BtnPP.TabIndex = 2;
            BtnPP.Text = "预设参数";
            BtnPP.UseVisualStyleBackColor = true;
            // 
            // BtnImportFile
            // 
            this.BtnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportFile.Location = new System.Drawing.Point(404, 148);
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
            this.BtnEmoji.Location = new System.Drawing.Point(38, 344);
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
            this.BtnWords.Location = new System.Drawing.Point(150, 344);
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
            this.BtnSentence.Location = new System.Drawing.Point(264, 344);
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
            this.BtnChinese.Location = new System.Drawing.Point(377, 344);
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
            BtnCleanPrefixandSuffix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            BtnCleanPrefixandSuffix.Location = new System.Drawing.Point(404, 293);
            BtnCleanPrefixandSuffix.Margin = new System.Windows.Forms.Padding(4);
            BtnCleanPrefixandSuffix.Name = "BtnCleanPrefixandSuffix";
            BtnCleanPrefixandSuffix.Size = new System.Drawing.Size(88, 33);
            BtnCleanPrefixandSuffix.TabIndex = 10;
            BtnCleanPrefixandSuffix.Text = "清理前后缀";
            BtnCleanPrefixandSuffix.UseVisualStyleBackColor = true;
            BtnCleanPrefixandSuffix.Click += new System.EventHandler(this.BtnCleanPrefixandSuffix_Click);
            // 
            // BtnCleanTxtINandOut
            // 
            this.BtnCleanTxtINandOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCleanTxtINandOut.Location = new System.Drawing.Point(404, 180);
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
            this.labelPrefix.Location = new System.Drawing.Point(38, 297);
            this.labelPrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(58, 15);
            this.labelPrefix.TabIndex = 6;
            this.labelPrefix.Text = "前缀参数:";
            // 
            // BtnSendToInput
            // 
            this.BtnSendToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendToInput.Location = new System.Drawing.Point(28, 540);
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
            this.BtnSendMidjourney.Location = new System.Drawing.Point(33, 622);
            this.BtnSendMidjourney.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSendMidjourney.Name = "BtnSendMidjourney";
            this.BtnSendMidjourney.Size = new System.Drawing.Size(58, 33);
            this.BtnSendMidjourney.TabIndex = 23;
            this.BtnSendMidjourney.Text = "打开";
            this.BtnSendMidjourney.UseVisualStyleBackColor = true;
            this.BtnSendMidjourney.Click += new System.EventHandler(this.BtnSendMidjourney_Click_1);
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrefix.Location = new System.Drawing.Point(103, 297);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(99, 23);
            this.textBoxPrefix.TabIndex = 7;
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(212, 297);
            this.labelSuffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(58, 15);
            this.labelSuffix.TabIndex = 8;
            this.labelSuffix.Text = "后缀参数:";
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuffix.Location = new System.Drawing.Point(277, 297);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(99, 23);
            this.textBoxSuffix.TabIndex = 9;
            // 
            // BtnAllClean
            // 
            this.BtnAllClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllClean.Location = new System.Drawing.Point(404, 211);
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
            this.BtnOneKey.Location = new System.Drawing.Point(209, 61);
            this.BtnOneKey.Name = "BtnOneKey";
            this.BtnOneKey.Size = new System.Drawing.Size(83, 30);
            this.BtnOneKey.TabIndex = 18;
            this.BtnOneKey.Text = "一键多开";
            this.BtnOneKey.UseVisualStyleBackColor = true;
            this.BtnOneKey.Click += new System.EventHandler(this.BtnOneKey_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(43, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "参数批量";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txBoxMidjourney
            // 
            this.txBoxMidjourney.Location = new System.Drawing.Point(94, 581);
            this.txBoxMidjourney.Name = "txBoxMidjourney";
            this.txBoxMidjourney.Size = new System.Drawing.Size(393, 21);
            this.txBoxMidjourney.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "频道链接:";
            // 
            // BtnPreset
            // 
            this.BtnPreset.Location = new System.Drawing.Point(101, 622);
            this.BtnPreset.Name = "BtnPreset";
            this.BtnPreset.Size = new System.Drawing.Size(58, 33);
            this.BtnPreset.TabIndex = 27;
            this.BtnPreset.Text = "预设";
            this.BtnPreset.UseVisualStyleBackColor = true;
            this.BtnPreset.Click += new System.EventHandler(this.BtnPreset_Click_1);
            // 
            // BtnImage
            // 
            this.BtnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImage.Location = new System.Drawing.Point(126, 61);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(83, 30);
            this.BtnImage.TabIndex = 28;
            this.BtnImage.Text = "图片信息";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(533, 669);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.BtnPreset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBoxMidjourney);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnOneKey);
            this.Controls.Add(this.BtnAllClean);
            this.Controls.Add(this.textBoxSuffix);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.labelSuffix);
            this.Controls.Add(this.BtnSendMidjourney);
            this.Controls.Add(this.BtnSendToInput);
            this.Controls.Add(this.BtnCleanTxtINandOut);
            this.Controls.Add(BtnCleanPrefixandSuffix);
            this.Controls.Add(this.BtnChinese);
            this.Controls.Add(this.BtnSentence);
            this.Controls.Add(this.BtnWords);
            this.Controls.Add(this.BtnEmoji);
            this.Controls.Add(this.BtnImportFile);
            this.Controls.Add(BtnPP);
            this.Controls.Add(this.richTextBoxTxtOut);
            this.Controls.Add(this.richTextBoxTxtIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
        private System.Windows.Forms.Button BtnImportFile;
        private System.Windows.Forms.Button BtnEmoji;
        private System.Windows.Forms.Button BtnWords;
        private System.Windows.Forms.Button BtnSentence;
        private System.Windows.Forms.Button BtnChinese;
        private System.Windows.Forms.Button BtnCleanTxtINandOut;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Button BtnSendToInput;
        private System.Windows.Forms.Button BtnSendMidjourney;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Button BtnAllClean;
        private System.Windows.Forms.Button BtnOneKey;
        private Button button1;
        private TextBox txBoxMidjourney;
        private Label label1;
        private Button BtnPreset;
        private Button BtnImage;
    }
}


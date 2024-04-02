// MidjourneyForm.Designer.cs

using System.Windows.Forms;
using System.Xml.Linq;

namespace bot_APP_
{
    partial class MidjourneyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMJForm = new System.Windows.Forms.TextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownResult = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownaADD = new System.Windows.Forms.NumericUpDown();
            this.buttonMidjourney = new System.Windows.Forms.Button();
            this.BtnMJSendToMainFormTex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownaADD)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "文本输入:";
            // 
            // textBoxMJForm
            // 
            this.textBoxMJForm.Location = new System.Drawing.Point(129, 90);
            this.textBoxMJForm.Multiline = true;
            this.textBoxMJForm.Name = "textBoxMJForm";
            this.textBoxMJForm.Size = new System.Drawing.Size(348, 21);
            this.textBoxMJForm.TabIndex = 1;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(129, 193);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(348, 118);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "结果输出:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(130, 136);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 12);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "增量:";
            // 
            // numericUpDownResult
            // 
            this.numericUpDownResult.Location = new System.Drawing.Point(171, 134);
            this.numericUpDownResult.Name = "numericUpDownResult";
            this.numericUpDownResult.Size = new System.Drawing.Size(40, 21);
            this.numericUpDownResult.TabIndex = 3;
            this.numericUpDownResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownaADD
            // 
            this.numericUpDownaADD.Location = new System.Drawing.Point(342, 134);
            this.numericUpDownaADD.Name = "numericUpDownaADD";
            this.numericUpDownaADD.Size = new System.Drawing.Size(40, 21);
            this.numericUpDownaADD.TabIndex = 3;
            this.numericUpDownaADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonMidjourney
            // 
            this.buttonMidjourney.Location = new System.Drawing.Point(130, 366);
            this.buttonMidjourney.Name = "buttonMidjourney";
            this.buttonMidjourney.Size = new System.Drawing.Size(348, 39);
            this.buttonMidjourney.TabIndex = 4;
            this.buttonMidjourney.Text = "运行";
            this.buttonMidjourney.UseVisualStyleBackColor = true;
            this.buttonMidjourney.Click += new System.EventHandler(this.buttonMidjourney_Click);
            // 
            // BtnMJSendToMainFormTex
            // 
            this.BtnMJSendToMainFormTex.Location = new System.Drawing.Point(129, 327);
            this.BtnMJSendToMainFormTex.Name = "BtnMJSendToMainFormTex";
            this.BtnMJSendToMainFormTex.Size = new System.Drawing.Size(67, 23);
            this.BtnMJSendToMainFormTex.TabIndex = 5;
            this.BtnMJSendToMainFormTex.Text = "发送";
            this.BtnMJSendToMainFormTex.UseVisualStyleBackColor = true;
            this.BtnMJSendToMainFormTex.Click += new System.EventHandler(this.BtnMJSendToMainFormTex_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "清理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MidjourneyForm
            // 
            this.ClientSize = new System.Drawing.Size(645, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnMJSendToMainFormTex);
            this.Controls.Add(this.buttonMidjourney);
            this.Controls.Add(this.numericUpDownaADD);
            this.Controls.Add(this.numericUpDownResult);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.textBoxMJForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Name = "MidjourneyForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownaADD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMJForm;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownResult;
        private System.Windows.Forms.NumericUpDown numericUpDownaADD;
        private System.Windows.Forms.Button buttonMidjourney;
        private System.Windows.Forms.Button BtnMJSendToMainFormTex;
        private System.Windows.Forms.Button button1;
    }
}
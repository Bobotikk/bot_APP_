namespace bot_APP_
{
    partial class PresetForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPresetName;
        private System.Windows.Forms.TextBox txtPresetValue;
        private System.Windows.Forms.Button btnAddPreset;
        private System.Windows.Forms.Button btnDeletePreset;
        private System.Windows.Forms.Button btnApplyPreset;

        private void InitializeComponent ()
        {
            this.txtPresetName = new System.Windows.Forms.TextBox();
            this.txtPresetValue = new System.Windows.Forms.TextBox();
            this.btnAddPreset = new System.Windows.Forms.Button();
            this.btnDeletePreset = new System.Windows.Forms.Button();
            this.btnApplyPreset = new System.Windows.Forms.Button();
            this.dataGridViewPresets = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresets)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPresetName
            // 
            this.txtPresetName.Location = new System.Drawing.Point(12, 157);
            this.txtPresetName.Name = "txtPresetName";
            this.txtPresetName.Size = new System.Drawing.Size(100, 21);
            this.txtPresetName.TabIndex = 1;
            // 
            // txtPresetValue
            // 
            this.txtPresetValue.Location = new System.Drawing.Point(118, 157);
            this.txtPresetValue.Name = "txtPresetValue";
            this.txtPresetValue.Size = new System.Drawing.Size(254, 21);
            this.txtPresetValue.TabIndex = 2;
            // 
            // btnAddPreset
            // 
            this.btnAddPreset.Location = new System.Drawing.Point(12, 185);
            this.btnAddPreset.Name = "btnAddPreset";
            this.btnAddPreset.Size = new System.Drawing.Size(75, 21);
            this.btnAddPreset.TabIndex = 3;
            this.btnAddPreset.Text = "添加";
            this.btnAddPreset.UseVisualStyleBackColor = true;
            this.btnAddPreset.Click += new System.EventHandler(this.BtnAddPreset_Click);
            // 
            // btnDeletePreset
            // 
            this.btnDeletePreset.Location = new System.Drawing.Point(93, 185);
            this.btnDeletePreset.Name = "btnDeletePreset";
            this.btnDeletePreset.Size = new System.Drawing.Size(75, 21);
            this.btnDeletePreset.TabIndex = 4;
            this.btnDeletePreset.Text = "删除";
            this.btnDeletePreset.UseVisualStyleBackColor = true;
            this.btnDeletePreset.Click += new System.EventHandler(this.BtnDeletePreset_Click);
            // 
            // btnApplyPreset
            // 
            this.btnApplyPreset.Location = new System.Drawing.Point(297, 185);
            this.btnApplyPreset.Name = "btnApplyPreset";
            this.btnApplyPreset.Size = new System.Drawing.Size(75, 21);
            this.btnApplyPreset.TabIndex = 5;
            this.btnApplyPreset.Text = "应用";
            this.btnApplyPreset.UseVisualStyleBackColor = true;
            this.btnApplyPreset.Click += new System.EventHandler(this.BtnApplyPreset_Click);
            // 
            // dataGridViewPresets
            // 
            this.dataGridViewPresets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewPresets.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewPresets.Name = "dataGridViewPresets";
            this.dataGridViewPresets.Size = new System.Drawing.Size(360, 140);
            this.dataGridViewPresets.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 411);
            this.Controls.Add(this.btnApplyPreset);
            this.Controls.Add(this.btnDeletePreset);
            this.Controls.Add(this.btnAddPreset);
            this.Controls.Add(this.txtPresetValue);
            this.Controls.Add(this.txtPresetName);
            this.Controls.Add(this.dataGridViewPresets);
            this.Name = "PresetForm";
            this.Text = "Preset Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewPresets;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}

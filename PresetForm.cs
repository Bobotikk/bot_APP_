using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bot_APP_
{
    public partial class PresetForm : Form
    {
        public Dictionary<string, string> Presets { get; set; }

        public PresetForm (Dictionary<string, string> presets)
        {
            InitializeComponent();
            Presets = presets;
            LoadPresets();
        }

        private void LoadPresets ()
        {
            dataGridViewPresets.Rows.Clear();
            foreach (var preset in Presets)
            {
                dataGridViewPresets.Rows.Add(preset.Key, preset.Value);
            }
        }

        private void BtnAddPreset_Click (object sender, EventArgs e)
        {
            var key = txtPresetName.Text.Trim();
            var value = txtPresetValue.Text.Trim();

            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                if (Presets.ContainsKey(key))
                {
                    MessageBox.Show("Preset with this name already exists.");
                }
                else
                {
                    Presets[key] = value;
                    LoadPresets();
                }
            }
        }

        private void BtnDeletePreset_Click (object sender, EventArgs e)
        {
            if (dataGridViewPresets.SelectedRows.Count > 0)
            {
                var key = dataGridViewPresets.SelectedRows[0].Cells[0].Value.ToString();
                Presets.Remove(key);
                LoadPresets();
            }
        }

        private void BtnApplyPreset_Click (object sender, EventArgs e)
        {
            if (dataGridViewPresets.SelectedRows.Count > 0)
            {
                var key = dataGridViewPresets.SelectedRows[0].Cells[0].Value.ToString();
                var value = Presets[key];
                ((MainForm)this.Owner).SetPreset(value);
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mouse_Bounder
{
    public partial class OptionsForm : Form
    {
        private bool m_isRegisteringBoundKey = false;
        private int m_keyValueBuffer = MainForm.DEFAULT_BOUND_TOGGLE_KEY;

        private void UpdateComponents()
        {
            bindWhenFocusedCheckBox.Checked = MainForm.BoundWhenFocused;
            rememberProcessesCheckBox.Checked = MainForm.RememberLastProcess;
            borderOffsetTextBox.Text = MainForm.BorderOffset.ToString();
            KeysConverter kc = new KeysConverter();
            boundToggleBtn.Text = kc.ConvertToString(MainForm.BoundKey);
        }

        private void ApplySettings()
        {
            MainForm.BoundWhenFocused = bindWhenFocusedCheckBox.Checked;
            MainForm.RememberLastProcess = rememberProcessesCheckBox.Checked;
            MainForm.BorderOffset = int.Parse(borderOffsetTextBox.Text);
            MainForm.BoundKeyEnabled = (boundToggleBtn.Text != "None");
            MainForm.LastProcess = MainForm.DEFAULT_LAST_PROCESS;
            MainForm.BoundKey = this.m_keyValueBuffer;
        }

        private void SaveSettings()
        {
            Settings.Default.BOUND_WHEN_FOCUSED = MainForm.BoundWhenFocused;
            Settings.Default.REMEMBER_LAST_PROCESS = MainForm.RememberLastProcess;
            Settings.Default.BORDER_OFFSET = MainForm.BorderOffset;
            Settings.Default.BOUND_TOGGLE_KEY_ENABLED = MainForm.BoundKeyEnabled;
            Settings.Default.BOUND_TOGGLE_KEY = MainForm.BoundKey;
            Settings.Default.LAST_PROCESS = MainForm.LastProcess;
            Settings.Default.Save();
        }

        public OptionsForm()
        {
            InitializeComponent();
            this.UpdateComponents();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
        }

        private void borderOffsetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !
            (
                Char.IsNumber(e.KeyChar) || 
                Char.IsControl(e.KeyChar)
            );
        }

        private void boundToggleBtn_Click(object sender, EventArgs e)
        {
            if (this.m_isRegisteringBoundKey) { return; }
            this.m_isRegisteringBoundKey = true;
        }

        private void OptionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.m_isRegisteringBoundKey)
            {
                this.m_keyValueBuffer = e.KeyValue;
                KeysConverter kc = new KeysConverter();
                boundToggleBtn.Text = kc.ConvertToString(e.KeyCode);
                this.m_isRegisteringBoundKey = false;
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            this.ApplySettings();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.ApplySettings();
            this.SaveSettings();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MainForm.BoundWhenFocused = MainForm.DEFAULT_BOUND_WHEN_FOCUSED;
            MainForm.RememberLastProcess = MainForm.DEFAULT_REMEMBER_LAST_PROCESS;
            MainForm.BorderOffset = MainForm.DEFAULT_BORDER_OFFSET;
            MainForm.BoundKeyEnabled = MainForm.DEFAULT_BOUND_TOGGLE_KEY_ENABLED;
            MainForm.BoundKey = MainForm.DEFAULT_BOUND_TOGGLE_KEY;
            MainForm.LastProcess = MainForm.DEFAULT_LAST_PROCESS;
            this.UpdateComponents();
            this.SaveSettings();
        }
    }
}

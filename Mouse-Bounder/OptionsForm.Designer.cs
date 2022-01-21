
using System.Windows.Forms;

namespace Mouse_Bounder
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.bindWhenFocusedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.rememberProcessesCheckBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.borderOffsetTextBox = new System.Windows.Forms.TextBox();
            this.boundToggleBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bindWhenFocusedCheckBox
            // 
            this.bindWhenFocusedCheckBox.AutoSize = true;
            this.bindWhenFocusedCheckBox.Location = new System.Drawing.Point(12, 12);
            this.bindWhenFocusedCheckBox.Name = "bindWhenFocusedCheckBox";
            this.bindWhenFocusedCheckBox.Size = new System.Drawing.Size(234, 19);
            this.bindWhenFocusedCheckBox.TabIndex = 0;
            this.bindWhenFocusedCheckBox.Text = "Bind Only When Application Is Focused";
            this.toolTip1.SetToolTip(this.bindWhenFocusedCheckBox, "Automatically unbind and bind when the program loses and regains focus.");
            this.bindWhenFocusedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Border Offest";
            this.toolTip1.SetToolTip(this.label1, "When bounded to an application, the cursor can leave the window bounds by a sligh" +
        "t amount. To fix this, we push the cursor back to the boundary + the boundary of" +
        "fset.");
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(12, 235);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(105, 23);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bound Toggle Key";
            this.toolTip1.SetToolTip(this.label3, "The key to press to bind and unbind from a process.");
            this.label3.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(234, 235);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(105, 23);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "Reset to Default";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // rememberProcessesCheckBox
            // 
            this.rememberProcessesCheckBox.AutoSize = true;
            this.rememberProcessesCheckBox.Location = new System.Drawing.Point(12, 40);
            this.rememberProcessesCheckBox.Name = "rememberProcessesCheckBox";
            this.rememberProcessesCheckBox.Size = new System.Drawing.Size(175, 19);
            this.rememberProcessesCheckBox.TabIndex = 12;
            this.rememberProcessesCheckBox.Text = "Remember Previous Process";
            this.toolTip1.SetToolTip(this.rememberProcessesCheckBox, "Remember the last typed process between sessions.");
            this.rememberProcessesCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(123, 235);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save Settings";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // borderOffsetTextBox
            // 
            this.borderOffsetTextBox.Location = new System.Drawing.Point(137, 115);
            this.borderOffsetTextBox.MaxLength = 4;
            this.borderOffsetTextBox.Name = "borderOffsetTextBox";
            this.borderOffsetTextBox.Size = new System.Drawing.Size(75, 23);
            this.borderOffsetTextBox.TabIndex = 10;
            this.borderOffsetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.borderOffsetTextBox_KeyPress);
            // 
            // boundToggleBtn
            // 
            this.boundToggleBtn.Enabled = false;
            this.boundToggleBtn.Location = new System.Drawing.Point(137, 145);
            this.boundToggleBtn.Name = "boundToggleBtn";
            this.boundToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.boundToggleBtn.TabIndex = 14;
            this.boundToggleBtn.Text = "None";
            this.boundToggleBtn.UseVisualStyleBackColor = true;
            this.boundToggleBtn.Visible = false;
            this.boundToggleBtn.Click += new System.EventHandler(this.boundToggleBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Always on Top";
            this.toolTip1.SetToolTip(this.checkBox1, "Sets Mouse Bounder to be displayed on top of other applications.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(223, 19);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Auto-Bind to Remembered Processes";
            this.toolTip1.SetToolTip(this.checkBox3, "Automatically bind to the last process Mouse Bounder remembers.");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 368);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.boundToggleBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.rememberProcessesCheckBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.borderOffsetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindWhenFocusedCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Mouse Bounder [Options]";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bindWhenFocusedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.CheckBox rememberProcessesCheckBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox borderOffsetTextBox;
        private System.Windows.Forms.Button boundToggleBtn;
        private ToolTip toolTip1;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
    }
}
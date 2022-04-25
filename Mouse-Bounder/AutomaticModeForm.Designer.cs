namespace Mouse_Bounder
{
    partial class AutomaticModeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticModeForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyBindWhenAppIsFocusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rememberPreviousProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBindToRememberedProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpBtn = new System.Windows.Forms.ToolStripButton();
            this.aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.processListLbl = new System.Windows.Forms.Label();
            this.processListComboBox = new System.Windows.Forms.ComboBox();
            this.boundBtn = new System.Windows.Forms.Button();
            this.unboundBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.boundLbl = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.helpBtn,
            this.aboutBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(264, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.onlyBindWhenAppIsFocusedToolStripMenuItem,
            this.rememberPreviousProcessesToolStripMenuItem,
            this.autoBindToRememberedProcessesToolStripMenuItem,
            this.resetToDefaultToolStripMenuItem,
            this.switchToManualToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // onlyBindWhenAppIsFocusedToolStripMenuItem
            // 
            this.onlyBindWhenAppIsFocusedToolStripMenuItem.Name = "onlyBindWhenAppIsFocusedToolStripMenuItem";
            this.onlyBindWhenAppIsFocusedToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.onlyBindWhenAppIsFocusedToolStripMenuItem.Text = "Only Bind When App is Focused";
            this.onlyBindWhenAppIsFocusedToolStripMenuItem.Click += new System.EventHandler(this.onlyBindWhenAppIsFocusedToolStripMenuItem_Click);
            // 
            // rememberPreviousProcessesToolStripMenuItem
            // 
            this.rememberPreviousProcessesToolStripMenuItem.Name = "rememberPreviousProcessesToolStripMenuItem";
            this.rememberPreviousProcessesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.rememberPreviousProcessesToolStripMenuItem.Text = "Remember Previous Process";
            this.rememberPreviousProcessesToolStripMenuItem.Click += new System.EventHandler(this.rememberPreviousProcessesToolStripMenuItem_Click);
            // 
            // autoBindToRememberedProcessesToolStripMenuItem
            // 
            this.autoBindToRememberedProcessesToolStripMenuItem.Name = "autoBindToRememberedProcessesToolStripMenuItem";
            this.autoBindToRememberedProcessesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.autoBindToRememberedProcessesToolStripMenuItem.Text = "Auto-Bind to Remembered Process";
            this.autoBindToRememberedProcessesToolStripMenuItem.Click += new System.EventHandler(this.autoBindToRememberedProcessesToolStripMenuItem_Click);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            this.resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            this.resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.resetToDefaultToolStripMenuItem.Text = "Reset to Default";
            this.resetToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // switchToManualToolStripMenuItem
            // 
            this.switchToManualToolStripMenuItem.Name = "switchToManualToolStripMenuItem";
            this.switchToManualToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.switchToManualToolStripMenuItem.Text = "Switch to Manual";
            this.switchToManualToolStripMenuItem.Click += new System.EventHandler(this.switchToManualToolStripMenuItem_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpBtn.Image = ((System.Drawing.Image)(resources.GetObject("helpBtn.Image")));
            this.helpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(36, 22);
            this.helpBtn.Text = "Help";
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(44, 22);
            this.aboutBtn.Text = "About";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // processListLbl
            // 
            this.processListLbl.AutoSize = true;
            this.processListLbl.Location = new System.Drawing.Point(12, 25);
            this.processListLbl.Name = "processListLbl";
            this.processListLbl.Size = new System.Drawing.Size(68, 15);
            this.processListLbl.TabIndex = 1;
            this.processListLbl.Text = "Process List";
            // 
            // processListComboBox
            // 
            this.processListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.processListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.processListComboBox.FormattingEnabled = true;
            this.processListComboBox.Location = new System.Drawing.Point(12, 43);
            this.processListComboBox.Name = "processListComboBox";
            this.processListComboBox.Size = new System.Drawing.Size(237, 23);
            this.processListComboBox.TabIndex = 2;
            // 
            // boundBtn
            // 
            this.boundBtn.Location = new System.Drawing.Point(12, 76);
            this.boundBtn.Name = "boundBtn";
            this.boundBtn.Size = new System.Drawing.Size(75, 23);
            this.boundBtn.TabIndex = 3;
            this.boundBtn.Text = "Bound";
            this.boundBtn.UseVisualStyleBackColor = true;
            this.boundBtn.Click += new System.EventHandler(this.boundBtn_Click);
            // 
            // unboundBtn
            // 
            this.unboundBtn.Location = new System.Drawing.Point(93, 76);
            this.unboundBtn.Name = "unboundBtn";
            this.unboundBtn.Size = new System.Drawing.Size(75, 23);
            this.unboundBtn.TabIndex = 4;
            this.unboundBtn.Text = "Unbound";
            this.unboundBtn.UseVisualStyleBackColor = true;
            this.unboundBtn.Click += new System.EventHandler(this.unboundBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(174, 76);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // boundLbl
            // 
            this.boundLbl.Location = new System.Drawing.Point(12, 104);
            this.boundLbl.Name = "boundLbl";
            this.boundLbl.Size = new System.Drawing.Size(237, 15);
            this.boundLbl.TabIndex = 6;
            this.boundLbl.Text = "Bound to: None";
            this.boundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutomaticModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 128);
            this.Controls.Add(this.boundLbl);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.unboundBtn);
            this.Controls.Add(this.boundBtn);
            this.Controls.Add(this.processListComboBox);
            this.Controls.Add(this.processListLbl);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutomaticModeForm";
            this.Text = "Mouse Bounder";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label processListLbl;
        private System.Windows.Forms.ComboBox processListComboBox;
        private System.Windows.Forms.Button boundBtn;
        private System.Windows.Forms.Button unboundBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label boundLbl;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyBindWhenAppIsFocusedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rememberPreviousProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoBindToRememberedProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton helpBtn;
        private System.Windows.Forms.ToolStripButton aboutBtn;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultToolStripMenuItem;
    }
}

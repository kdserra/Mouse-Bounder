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
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            onlyBindWhenAppIsFocusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rememberPreviousProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            autoBindToRememberedProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            boundTypeMouseEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpBtn = new System.Windows.Forms.ToolStripButton();
            aboutBtn = new System.Windows.Forms.ToolStripButton();
            processListLbl = new System.Windows.Forms.Label();
            processListComboBox = new System.Windows.Forms.ComboBox();
            boundBtn = new System.Windows.Forms.Button();
            unboundBtn = new System.Windows.Forms.Button();
            refreshBtn = new System.Windows.Forms.Button();
            boundLbl = new System.Windows.Forms.Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripDropDownButton1, helpBtn, aboutBtn });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new System.Drawing.Size(264, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { alwaysOnTopToolStripMenuItem, onlyBindWhenAppIsFocusedToolStripMenuItem, rememberPreviousProcessesToolStripMenuItem, autoBindToRememberedProcessesToolStripMenuItem, resetToDefaultToolStripMenuItem, boundTypeMouseEventToolStripMenuItem });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            toolStripDropDownButton1.Text = "Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // onlyBindWhenAppIsFocusedToolStripMenuItem
            // 
            onlyBindWhenAppIsFocusedToolStripMenuItem.Name = "onlyBindWhenAppIsFocusedToolStripMenuItem";
            onlyBindWhenAppIsFocusedToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            onlyBindWhenAppIsFocusedToolStripMenuItem.Text = "Only Bound When Focused";
            onlyBindWhenAppIsFocusedToolStripMenuItem.Click += onlyBindWhenAppIsFocusedToolStripMenuItem_Click;
            // 
            // rememberPreviousProcessesToolStripMenuItem
            // 
            rememberPreviousProcessesToolStripMenuItem.Name = "rememberPreviousProcessesToolStripMenuItem";
            rememberPreviousProcessesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            rememberPreviousProcessesToolStripMenuItem.Text = "Remember Previous Process";
            rememberPreviousProcessesToolStripMenuItem.Click += rememberPreviousProcessesToolStripMenuItem_Click;
            // 
            // autoBindToRememberedProcessesToolStripMenuItem
            // 
            autoBindToRememberedProcessesToolStripMenuItem.Name = "autoBindToRememberedProcessesToolStripMenuItem";
            autoBindToRememberedProcessesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            autoBindToRememberedProcessesToolStripMenuItem.Text = "Auto-Bind to Remembered Process";
            autoBindToRememberedProcessesToolStripMenuItem.Click += autoBindToRememberedProcessesToolStripMenuItem_Click;
            // 
            // resetToDefaultToolStripMenuItem
            // 
            resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            resetToDefaultToolStripMenuItem.Text = "Reset to Default";
            resetToDefaultToolStripMenuItem.Click += resetToDefaultToolStripMenuItem_Click;
            // 
            // boundTypeMouseEventToolStripMenuItem
            // 
            boundTypeMouseEventToolStripMenuItem.Name = "boundTypeMouseEventToolStripMenuItem";
            boundTypeMouseEventToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            boundTypeMouseEventToolStripMenuItem.Text = "Bound Trigger: Mouse Event";
            boundTypeMouseEventToolStripMenuItem.Click += boundTypeMouseEventToolStripMenuItem_Click;
            // 
            // helpBtn
            // 
            helpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            helpBtn.Image = (System.Drawing.Image)resources.GetObject("helpBtn.Image");
            helpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(36, 22);
            helpBtn.Text = "Help";
            helpBtn.Click += helpBtn_Click;
            // 
            // aboutBtn
            // 
            aboutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            aboutBtn.Image = (System.Drawing.Image)resources.GetObject("aboutBtn.Image");
            aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new System.Drawing.Size(44, 22);
            aboutBtn.Text = "About";
            aboutBtn.Click += aboutBtn_Click;
            // 
            // processListLbl
            // 
            processListLbl.AutoSize = true;
            processListLbl.Location = new System.Drawing.Point(12, 25);
            processListLbl.Name = "processListLbl";
            processListLbl.Size = new System.Drawing.Size(68, 15);
            processListLbl.TabIndex = 1;
            processListLbl.Text = "Process List";
            // 
            // processListComboBox
            // 
            processListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            processListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            processListComboBox.FormattingEnabled = true;
            processListComboBox.Location = new System.Drawing.Point(12, 43);
            processListComboBox.Name = "processListComboBox";
            processListComboBox.Size = new System.Drawing.Size(237, 23);
            processListComboBox.TabIndex = 2;
            // 
            // boundBtn
            // 
            boundBtn.Location = new System.Drawing.Point(12, 76);
            boundBtn.Name = "boundBtn";
            boundBtn.Size = new System.Drawing.Size(75, 23);
            boundBtn.TabIndex = 3;
            boundBtn.Text = "Bound";
            boundBtn.UseVisualStyleBackColor = true;
            boundBtn.Click += boundBtn_Click;
            // 
            // unboundBtn
            // 
            unboundBtn.Location = new System.Drawing.Point(93, 76);
            unboundBtn.Name = "unboundBtn";
            unboundBtn.Size = new System.Drawing.Size(75, 23);
            unboundBtn.TabIndex = 4;
            unboundBtn.Text = "Unbound";
            unboundBtn.UseVisualStyleBackColor = true;
            unboundBtn.Click += unboundBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new System.Drawing.Point(174, 76);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new System.Drawing.Size(75, 23);
            refreshBtn.TabIndex = 5;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // boundLbl
            // 
            boundLbl.Location = new System.Drawing.Point(12, 104);
            boundLbl.Name = "boundLbl";
            boundLbl.Size = new System.Drawing.Size(237, 15);
            boundLbl.TabIndex = 6;
            boundLbl.Text = "Bound to: None";
            boundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutomaticModeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(264, 128);
            Controls.Add(boundLbl);
            Controls.Add(refreshBtn);
            Controls.Add(unboundBtn);
            Controls.Add(boundBtn);
            Controls.Add(processListComboBox);
            Controls.Add(processListLbl);
            Controls.Add(toolStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AutomaticModeForm";
            Text = "Mouse Bounder";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripButton helpBtn;
        private System.Windows.Forms.ToolStripButton aboutBtn;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundTypeMouseEventToolStripMenuItem;
    }
}

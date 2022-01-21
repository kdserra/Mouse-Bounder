
namespace Mouse_Bounder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.processListLbl = new System.Windows.Forms.Label();
            this.processComboBox = new System.Windows.Forms.ComboBox();
            this.boundBtn = new System.Windows.Forms.Button();
            this.unboundBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.switchModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.boundProcessLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.xPosTextBox = new System.Windows.Forms.TextBox();
            this.xLbl = new System.Windows.Forms.Label();
            this.yPosTextBox = new System.Windows.Forms.TextBox();
            this.yPos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.processModePanel = new System.Windows.Forms.Panel();
            this.manualModePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.processModePanel.SuspendLayout();
            this.manualModePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // processListLbl
            // 
            this.processListLbl.AutoSize = true;
            this.processListLbl.Location = new System.Drawing.Point(4, 6);
            this.processListLbl.Name = "processListLbl";
            this.processListLbl.Size = new System.Drawing.Size(68, 15);
            this.processListLbl.TabIndex = 0;
            this.processListLbl.Text = "Process List";
            // 
            // processComboBox
            // 
            this.processComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.processComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(4, 24);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(237, 23);
            this.processComboBox.TabIndex = 1;
            // 
            // boundBtn
            // 
            this.boundBtn.Location = new System.Drawing.Point(12, 76);
            this.boundBtn.Name = "boundBtn";
            this.boundBtn.Size = new System.Drawing.Size(75, 23);
            this.boundBtn.TabIndex = 2;
            this.boundBtn.Text = "Bound";
            this.boundBtn.UseVisualStyleBackColor = true;
            this.boundBtn.Click += new System.EventHandler(this.boundBtn_Click);
            // 
            // unboundBtn
            // 
            this.unboundBtn.Location = new System.Drawing.Point(93, 76);
            this.unboundBtn.Name = "unboundBtn";
            this.unboundBtn.Size = new System.Drawing.Size(75, 23);
            this.unboundBtn.TabIndex = 3;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(279, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchModeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButton1.Text = "App";
            // 
            // switchModeToolStripMenuItem
            // 
            this.switchModeToolStripMenuItem.Name = "switchModeToolStripMenuItem";
            this.switchModeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.switchModeToolStripMenuItem.Text = "Switch to Manual";
            this.switchModeToolStripMenuItem.Click += new System.EventHandler(this.switchToManualToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "Help";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // boundProcessLbl
            // 
            this.boundProcessLbl.Location = new System.Drawing.Point(12, 105);
            this.boundProcessLbl.Name = "boundProcessLbl";
            this.boundProcessLbl.Size = new System.Drawing.Size(237, 15);
            this.boundProcessLbl.TabIndex = 8;
            this.boundProcessLbl.Text = "Bound to: None";
            this.boundProcessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "H";
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(230, 28);
            this.heightTextbox.MaxLength = 5;
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(38, 23);
            this.heightTextbox.TabIndex = 17;
            this.heightTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextbox_KeyPress);
            // 
            // xPosTextBox
            // 
            this.xPosTextBox.Location = new System.Drawing.Point(32, 28);
            this.xPosTextBox.MaxLength = 5;
            this.xPosTextBox.Name = "xPosTextBox";
            this.xPosTextBox.Size = new System.Drawing.Size(38, 23);
            this.xPosTextBox.TabIndex = 11;
            this.xPosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xPosTextBox_KeyPress);
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Location = new System.Drawing.Point(12, 31);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(14, 15);
            this.xLbl.TabIndex = 12;
            this.xLbl.Text = "X";
            // 
            // yPosTextBox
            // 
            this.yPosTextBox.Location = new System.Drawing.Point(96, 28);
            this.yPosTextBox.MaxLength = 5;
            this.yPosTextBox.Name = "yPosTextBox";
            this.yPosTextBox.Size = new System.Drawing.Size(38, 23);
            this.yPosTextBox.TabIndex = 13;
            this.yPosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yPosTextBox_KeyPress);
            // 
            // yPos
            // 
            this.yPos.AutoSize = true;
            this.yPos.Location = new System.Drawing.Point(76, 31);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(14, 15);
            this.yPos.TabIndex = 14;
            this.yPos.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "W";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(164, 28);
            this.widthTextBox.MaxLength = 5;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(38, 23);
            this.widthTextBox.TabIndex = 15;
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthTextBox_KeyPress);
            // 
            // processModePanel
            // 
            this.processModePanel.Controls.Add(this.processListLbl);
            this.processModePanel.Controls.Add(this.processComboBox);
            this.processModePanel.Location = new System.Drawing.Point(8, 25);
            this.processModePanel.Name = "processModePanel";
            this.processModePanel.Size = new System.Drawing.Size(259, 53);
            this.processModePanel.TabIndex = 11;
            // 
            // manualModePanel
            // 
            this.manualModePanel.Controls.Add(this.label3);
            this.manualModePanel.Controls.Add(this.label1);
            this.manualModePanel.Controls.Add(this.heightTextbox);
            this.manualModePanel.Controls.Add(this.widthTextBox);
            this.manualModePanel.Controls.Add(this.label2);
            this.manualModePanel.Controls.Add(this.xPosTextBox);
            this.manualModePanel.Controls.Add(this.yPos);
            this.manualModePanel.Controls.Add(this.yPosTextBox);
            this.manualModePanel.Controls.Add(this.xLbl);
            this.manualModePanel.Enabled = false;
            this.manualModePanel.Location = new System.Drawing.Point(-4, 19);
            this.manualModePanel.Name = "manualModePanel";
            this.manualModePanel.Size = new System.Drawing.Size(282, 71);
            this.manualModePanel.TabIndex = 12;
            this.manualModePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Manual Mode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 128);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.boundBtn);
            this.Controls.Add(this.unboundBtn);
            this.Controls.Add(this.boundProcessLbl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.processModePanel);
            this.Controls.Add(this.manualModePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mouse Bounder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.processModePanel.ResumeLayout(false);
            this.processModePanel.PerformLayout();
            this.manualModePanel.ResumeLayout(false);
            this.manualModePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processListLbl;
        private System.Windows.Forms.ComboBox processComboBox;
        private System.Windows.Forms.Button boundBtn;
        private System.Windows.Forms.Button unboundBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem switchModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label boundProcessLbl;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox xPosTextBox;
        private System.Windows.Forms.Label xLbl;
        private System.Windows.Forms.Label yPos;
        private System.Windows.Forms.TextBox yPosTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Panel processModePanel;
        private System.Windows.Forms.Panel manualModePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}


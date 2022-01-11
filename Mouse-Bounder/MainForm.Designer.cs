
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processListLbl
            // 
            this.processListLbl.AutoSize = true;
            this.processListLbl.Location = new System.Drawing.Point(12, 9);
            this.processListLbl.Name = "processListLbl";
            this.processListLbl.Size = new System.Drawing.Size(68, 15);
            this.processListLbl.TabIndex = 0;
            this.processListLbl.Text = "Process List";
            // 
            // processComboBox
            // 
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(12, 27);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(237, 23);
            this.processComboBox.TabIndex = 1;
            // 
            // boundBtn
            // 
            this.boundBtn.Location = new System.Drawing.Point(12, 56);
            this.boundBtn.Name = "boundBtn";
            this.boundBtn.Size = new System.Drawing.Size(75, 23);
            this.boundBtn.TabIndex = 2;
            this.boundBtn.Text = "Bound";
            this.boundBtn.UseVisualStyleBackColor = true;
            this.boundBtn.Click += new System.EventHandler(this.boundBtn_Click);
            // 
            // unboundBtn
            // 
            this.unboundBtn.Location = new System.Drawing.Point(93, 56);
            this.unboundBtn.Name = "unboundBtn";
            this.unboundBtn.Size = new System.Drawing.Size(75, 23);
            this.unboundBtn.TabIndex = 3;
            this.unboundBtn.Text = "Unbound";
            this.unboundBtn.UseVisualStyleBackColor = true;
            this.unboundBtn.Click += new System.EventHandler(this.unboundBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(174, 56);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "v1.0.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.unboundBtn);
            this.Controls.Add(this.boundBtn);
            this.Controls.Add(this.processComboBox);
            this.Controls.Add(this.processListLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mouse Bounder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processListLbl;
        private System.Windows.Forms.ComboBox processComboBox;
        private System.Windows.Forms.Button boundBtn;
        private System.Windows.Forms.Button unboundBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
    }
}


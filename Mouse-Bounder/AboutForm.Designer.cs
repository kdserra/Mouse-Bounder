namespace Mouse_Bounder
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            titleLbl = new System.Windows.Forms.Label();
            versionLbl = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            titleLbl.Location = new System.Drawing.Point(12, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new System.Drawing.Size(204, 37);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Mouse Bounder";
            // 
            // versionLbl
            // 
            versionLbl.AutoSize = true;
            versionLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            versionLbl.Location = new System.Drawing.Point(12, 57);
            versionLbl.Name = "versionLbl";
            versionLbl.Size = new System.Drawing.Size(118, 25);
            versionLbl.TabIndex = 0;
            versionLbl.Text = "Version 2.1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Stay up to date:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(12, 108);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(243, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/kdserra/Mouse-Bounder";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(322, 148);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(versionLbl);
            Controls.Add(titleLbl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Text = "Mouse Bounder [About]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
﻿namespace MultiWiiWinGUI
{
    partial class frmAbout
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
            this.button1 = new System.Windows.Forms.Button();
            this.l_version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_mwver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_version
            // 
            this.l_version.BackColor = System.Drawing.Color.Transparent;
            this.l_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_version.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l_version.Location = new System.Drawing.Point(365, 90);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(132, 18);
            this.l_version.TabIndex = 1;
            this.l_version.Text = "Version 2.3 - 2.4";
            this.l_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_version.Click += new System.EventHandler(this.l_version_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(388, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.0.0000.0000";
            // 
            // l_mwver
            // 
            this.l_mwver.BackColor = System.Drawing.Color.Transparent;
            this.l_mwver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mwver.ForeColor = System.Drawing.Color.Maroon;
            this.l_mwver.Location = new System.Drawing.Point(296, 118);
            this.l_mwver.Name = "l_mwver";
            this.l_mwver.Size = new System.Drawing.Size(202, 44);
            this.l_mwver.TabIndex = 6;
            this.l_mwver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "EOSBandi SynerFlight Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.splash;
            this.ClientSize = new System.Drawing.Size(587, 271);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_mwver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_mwver;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace ApplicationFrameVersionChanger
{
    partial class Frm_MainForm
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
            this.frtxtSlnPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.frtxtOutputDirectory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnChangeVersion = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtOutputDirectory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // frtxtSlnPath
            // 
            this.frtxtSlnPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtSlnPath.EditValue = "D:\\Praca\\inSolutions\\Projekty\\SzkieletAplikacji\\ApplicationFrame-Evaluation\\Appli" +
    "cationFrame.sln";
            this.frtxtSlnPath.Location = new System.Drawing.Point(108, 9);
            this.frtxtSlnPath.Name = "frtxtSlnPath";
            this.frtxtSlnPath.Size = new System.Drawing.Size(566, 20);
            this.frtxtSlnPath.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Solucja wejściowa:";
            // 
            // frtxtOutputDirectory
            // 
            this.frtxtOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtOutputDirectory.EditValue = "";
            this.frtxtOutputDirectory.Location = new System.Drawing.Point(108, 44);
            this.frtxtOutputDirectory.Name = "frtxtOutputDirectory";
            this.frtxtOutputDirectory.Size = new System.Drawing.Size(566, 20);
            this.frtxtOutputDirectory.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Wersja:";
            // 
            // btnChangeVersion
            // 
            this.btnChangeVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeVersion.Location = new System.Drawing.Point(560, 70);
            this.btnChangeVersion.Name = "btnChangeVersion";
            this.btnChangeVersion.Size = new System.Drawing.Size(114, 23);
            this.btnChangeVersion.TabIndex = 6;
            this.btnChangeVersion.Text = "Zmień wersję";
            // 
            // Frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 108);
            this.Controls.Add(this.frtxtSlnPath);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.frtxtOutputDirectory);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnChangeVersion);
            this.Name = "Frm_MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtOutputDirectory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit frtxtSlnPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit frtxtOutputDirectory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChangeVersion;

    }
}


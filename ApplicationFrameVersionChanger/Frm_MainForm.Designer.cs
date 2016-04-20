namespace ApplicationFrameVersionChanger
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
            this.frtxtVersion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnChangeVersion = new DevExpress.XtraEditors.SimpleButton();
            this.frbitTfs = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitTfs.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // frtxtSlnPath
            // 
            this.frtxtSlnPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtSlnPath.EditValue = "D:\\Praca\\inSolutions\\Projekty\\ApplicationFrame\\ApplicationFrame-Evaluation\\Applic" +
    "ationFrame.sln";
            this.frtxtSlnPath.Location = new System.Drawing.Point(108, 9);
            this.frtxtSlnPath.Name = "frtxtSlnPath";
            this.frtxtSlnPath.Size = new System.Drawing.Size(566, 20);
            this.frtxtSlnPath.TabIndex = 10;
            this.frtxtSlnPath.EditValueChanged += new System.EventHandler(this.frtxtSlnPath_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Solucja wejściowa:";
            // 
            // frtxtVersion
            // 
            this.frtxtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frtxtVersion.EditValue = "";
            this.frtxtVersion.Location = new System.Drawing.Point(108, 44);
            this.frtxtVersion.Name = "frtxtVersion";
            this.frtxtVersion.Size = new System.Drawing.Size(566, 20);
            this.frtxtVersion.TabIndex = 8;
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
            this.btnChangeVersion.Click += new System.EventHandler(this.btnChangeVersion_Click);
            // 
            // frbitTfs
            // 
            this.frbitTfs.Enabled = false;
            this.frbitTfs.Location = new System.Drawing.Point(24, 77);
            this.frbitTfs.Name = "frbitTfs";
            this.frbitTfs.Properties.Caption = "Checkout plików w TFS";
            this.frbitTfs.Size = new System.Drawing.Size(137, 19);
            this.frbitTfs.TabIndex = 11;
            // 
            // Frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 108);
            this.Controls.Add(this.frbitTfs);
            this.Controls.Add(this.frtxtSlnPath);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.frtxtVersion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnChangeVersion);
            this.Name = "Frm_MainForm";
            this.Text = "Zmiana wersji szkieletu";
            ((System.ComponentModel.ISupportInitialize)(this.frtxtSlnPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtxtVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frbitTfs.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit frtxtSlnPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit frtxtVersion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChangeVersion;
        private DevExpress.XtraEditors.CheckEdit frbitTfs;

    }
}


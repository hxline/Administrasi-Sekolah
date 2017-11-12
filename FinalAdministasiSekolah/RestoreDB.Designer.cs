namespace FinalAdministasiSekolah
{
    partial class RestoreDB
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
            this.radTextLokasiRestore = new Telerik.WinControls.UI.RadTextBox();
            this.radButtonBrowse = new Telerik.WinControls.UI.RadButton();
            this.radButtonRestore = new Telerik.WinControls.UI.RadButton();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            this.radCheckEnkripsi = new Telerik.WinControls.UI.RadCheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radTextPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radTextLokasiRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnkripsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextLokasiRestore
            // 
            this.radTextLokasiRestore.Location = new System.Drawing.Point(12, 12);
            this.radTextLokasiRestore.Name = "radTextLokasiRestore";
            this.radTextLokasiRestore.Size = new System.Drawing.Size(173, 20);
            this.radTextLokasiRestore.TabIndex = 0;
            this.radTextLokasiRestore.TabStop = false;
            // 
            // radButtonBrowse
            // 
            this.radButtonBrowse.Location = new System.Drawing.Point(191, 12);
            this.radButtonBrowse.Name = "radButtonBrowse";
            this.radButtonBrowse.Size = new System.Drawing.Size(69, 20);
            this.radButtonBrowse.TabIndex = 1;
            this.radButtonBrowse.Text = "Telusuri";
            this.radButtonBrowse.Click += new System.EventHandler(this.radButtonBrowse_Click);
            // 
            // radButtonRestore
            // 
            this.radButtonRestore.Location = new System.Drawing.Point(123, 125);
            this.radButtonRestore.Name = "radButtonRestore";
            this.radButtonRestore.Size = new System.Drawing.Size(62, 24);
            this.radButtonRestore.TabIndex = 2;
            this.radButtonRestore.Text = "Restore";
            this.radButtonRestore.Click += new System.EventHandler(this.radButtonRestore_Click);
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(191, 125);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(69, 24);
            this.radButtonBatal.TabIndex = 2;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // radCheckEnkripsi
            // 
            this.radCheckEnkripsi.Location = new System.Drawing.Point(12, 88);
            this.radCheckEnkripsi.Name = "radCheckEnkripsi";
            this.radCheckEnkripsi.Size = new System.Drawing.Size(110, 18);
            this.radCheckEnkripsi.TabIndex = 3;
            this.radCheckEnkripsi.Text = "Dekripsi Database";
            this.radCheckEnkripsi.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckEnkripsi_ToggleStateChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radTextPassword
            // 
            this.radTextPassword.Enabled = false;
            this.radTextPassword.Location = new System.Drawing.Point(12, 62);
            this.radTextPassword.Name = "radTextPassword";
            this.radTextPassword.PasswordChar = '*';
            this.radTextPassword.Size = new System.Drawing.Size(173, 20);
            this.radTextPassword.TabIndex = 4;
            this.radTextPassword.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(102, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Password Deskripsi";
            // 
            // RestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 155);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTextPassword);
            this.Controls.Add(this.radCheckEnkripsi);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.radButtonRestore);
            this.Controls.Add(this.radTextLokasiRestore);
            this.Controls.Add(this.radButtonBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestoreDB";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RestoreDB";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radTextLokasiRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnkripsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextLokasiRestore;
        private Telerik.WinControls.UI.RadButton radButtonBrowse;
        private Telerik.WinControls.UI.RadButton radButtonRestore;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private Telerik.WinControls.UI.RadCheckBox radCheckEnkripsi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadTextBox radTextPassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}

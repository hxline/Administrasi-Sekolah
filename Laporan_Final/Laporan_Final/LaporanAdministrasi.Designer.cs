namespace Laporan_Final
{
    partial class LaporanAdministrasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanAdministrasi));
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(858, 36);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "PEMBAYARAN";
            this.radMenuItem1.AccessibleName = "PEMBAYARAN";
            this.radMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem1.Image")));
            this.radMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "PEMBAYARAN";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "TABUNGAN";
            this.radMenuItem2.AccessibleName = "TABUNGAN";
            this.radMenuItem2.ClipDrawing = false;
            this.radMenuItem2.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.radMenuItem2.FlipText = false;
            this.radMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem2.Image")));
            this.radMenuItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "TABUNGAN";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "SURAT";
            this.radMenuItem3.AccessibleName = "SURAT";
            this.radMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem3.Image")));
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "SURAT";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "PENDAFTARAN";
            this.radMenuItem4.AccessibleName = "PENDAFTARAN";
            this.radMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem4.Image")));
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "PENDAFTARAN";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // LaporanAdministrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 577);
            this.Controls.Add(this.radMenu1);
            this.Name = "LaporanAdministrasi";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanAdministrasi";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
    }
}

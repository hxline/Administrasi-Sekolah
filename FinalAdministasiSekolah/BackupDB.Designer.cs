namespace FinalAdministasiSekolah
{
    partial class BackupDB
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radButtonSimpan = new Telerik.WinControls.UI.RadButton();
            this.radButtonBrowse = new Telerik.WinControls.UI.RadButton();
            this.radTextFileLokasi = new Telerik.WinControls.UI.RadTextBox();
            this.radCheckEnkripsi = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            this.radTextPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radButtonSemua = new Telerik.WinControls.UI.RadButton();
            this.radButtonKosong = new Telerik.WinControls.UI.RadButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextFileLokasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnkripsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSemua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonKosong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonSimpan
            // 
            this.radButtonSimpan.Location = new System.Drawing.Point(136, 107);
            this.radButtonSimpan.Name = "radButtonSimpan";
            this.radButtonSimpan.Size = new System.Drawing.Size(58, 24);
            this.radButtonSimpan.TabIndex = 0;
            this.radButtonSimpan.Text = "Simpan";
            this.radButtonSimpan.Click += new System.EventHandler(this.radButtonSimpan_Click);
            // 
            // radButtonBrowse
            // 
            this.radButtonBrowse.Location = new System.Drawing.Point(200, 11);
            this.radButtonBrowse.Name = "radButtonBrowse";
            this.radButtonBrowse.Size = new System.Drawing.Size(61, 20);
            this.radButtonBrowse.TabIndex = 1;
            this.radButtonBrowse.Text = "Browse";
            this.radButtonBrowse.Click += new System.EventHandler(this.radButtonBrowse_Click);
            // 
            // radTextFileLokasi
            // 
            this.radTextFileLokasi.Location = new System.Drawing.Point(12, 12);
            this.radTextFileLokasi.Name = "radTextFileLokasi";
            this.radTextFileLokasi.Size = new System.Drawing.Size(182, 20);
            this.radTextFileLokasi.TabIndex = 0;
            this.radTextFileLokasi.TabStop = false;
            // 
            // radCheckEnkripsi
            // 
            this.radCheckEnkripsi.Location = new System.Drawing.Point(12, 87);
            this.radCheckEnkripsi.Name = "radCheckEnkripsi";
            this.radCheckEnkripsi.Size = new System.Drawing.Size(108, 18);
            this.radCheckEnkripsi.TabIndex = 2;
            this.radCheckEnkripsi.Text = "Enkripsi Database";
            this.radCheckEnkripsi.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckEnkripsi_ToggleStateChanged);
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(200, 107);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(61, 24);
            this.radButtonBatal.TabIndex = 1;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // radTextPassword
            // 
            this.radTextPassword.Enabled = false;
            this.radTextPassword.Location = new System.Drawing.Point(12, 61);
            this.radTextPassword.Name = "radTextPassword";
            this.radTextPassword.PasswordChar = '*';
            this.radTextPassword.Size = new System.Drawing.Size(173, 20);
            this.radTextPassword.TabIndex = 6;
            this.radTextPassword.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(90, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Pasword Enkripsi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnSelect,
            this.colntable});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(153, 162);
            this.dataGridView1.TabIndex = 7;
            // 
            // radButtonSemua
            // 
            this.radButtonSemua.Location = new System.Drawing.Point(165, 19);
            this.radButtonSemua.Name = "radButtonSemua";
            this.radButtonSemua.Size = new System.Drawing.Size(58, 24);
            this.radButtonSemua.TabIndex = 8;
            this.radButtonSemua.Text = "Semua";
            this.radButtonSemua.Click += new System.EventHandler(this.radButtonSemua_Click);
            // 
            // radButtonKosong
            // 
            this.radButtonKosong.Location = new System.Drawing.Point(165, 49);
            this.radButtonKosong.Name = "radButtonKosong";
            this.radButtonKosong.Size = new System.Drawing.Size(58, 24);
            this.radButtonKosong.TabIndex = 9;
            this.radButtonKosong.Text = "Kosong";
            this.radButtonKosong.Click += new System.EventHandler(this.radButtonKosong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.radButtonKosong);
            this.groupBox1.Controls.Add(this.radButtonSemua);
            this.groupBox1.Location = new System.Drawing.Point(267, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel";
            // 
            // colnSelect
            // 
            this.colnSelect.FillWeight = 40.60914F;
            this.colnSelect.HeaderText = "";
            this.colnSelect.Name = "colnSelect";
            this.colnSelect.ReadOnly = true;
            // 
            // colntable
            // 
            this.colntable.FillWeight = 159.3909F;
            this.colntable.HeaderText = "Tabel";
            this.colntable.Name = "colntable";
            this.colntable.ReadOnly = true;
            // 
            // BackupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radTextPassword);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.radCheckEnkripsi);
            this.Controls.Add(this.radTextFileLokasi);
            this.Controls.Add(this.radButtonBrowse);
            this.Controls.Add(this.radButtonSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupDB";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BackupDB";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextFileLokasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnkripsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSemua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonKosong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Telerik.WinControls.UI.RadButton radButtonSimpan;
        private Telerik.WinControls.UI.RadButton radButtonBrowse;
        private Telerik.WinControls.UI.RadTextBox radTextFileLokasi;
        private Telerik.WinControls.UI.RadCheckBox radCheckEnkripsi;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private Telerik.WinControls.UI.RadTextBox radTextPassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Telerik.WinControls.UI.RadButton radButtonSemua;
        private Telerik.WinControls.UI.RadButton radButtonKosong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colntable;
    }
}

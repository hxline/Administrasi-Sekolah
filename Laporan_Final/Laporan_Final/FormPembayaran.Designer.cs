﻿namespace Laporan_Final
{
    partial class FormPembayaran
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
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radCheckBox3 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 169);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(858, 408);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Location = new System.Drawing.Point(92, 72);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.radDateTimePicker1.TabIndex = 3;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Saturday, December 28, 2013";
            this.radDateTimePicker1.Value = new System.DateTime(2013, 12, 28, 5, 13, 54, 180);
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.Location = new System.Drawing.Point(245, 72);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker2.TabIndex = 4;
            this.radDateTimePicker2.TabStop = false;
            this.radDateTimePicker2.Text = "Saturday, December 28, 2013";
            this.radDateTimePicker2.Value = new System.DateTime(2013, 12, 28, 5, 14, 8, 217);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(9, 45);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(58, 18);
            this.radCheckBox1.TabIndex = 6;
            this.radCheckBox1.Text = "Kelas   :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(92, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.Location = new System.Drawing.Point(9, 72);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(60, 18);
            this.radCheckBox2.TabIndex = 8;
            this.radCheckBox2.Text = "Tanggal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radCheckBox3);
            this.groupBox1.Controls.Add(this.radCheckBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radDateTimePicker2);
            this.groupBox1.Controls.Add(this.radCheckBox2);
            this.groupBox1.Controls.Add(this.radDateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laporan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 9;
            // 
            // radCheckBox3
            // 
            this.radCheckBox3.Location = new System.Drawing.Point(9, 21);
            this.radCheckBox3.Name = "radCheckBox3";
            this.radCheckBox3.Size = new System.Drawing.Size(59, 18);
            this.radCheckBox3.TabIndex = 7;
            this.radCheckBox3.Text = "Nama  :";
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPembayaran";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPembayaran";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox3;

    }
}

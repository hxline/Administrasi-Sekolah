using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class RestoreDB : Telerik.WinControls.UI.RadForm
    {
        public RestoreDB()
        {
            InitializeComponent();
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lokasi Restore";
            openFileDialog1.Filter = "SQL (*.sql) | *.sql";
            DialogResult lokasi = openFileDialog1.ShowDialog();

            if (lokasi == DialogResult.OK)
            {
                radTextLokasiRestore.Text = openFileDialog1.FileName;
            }
        }

        private void radButtonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (radCheckEnkripsi.Checked == true)
                {
                    try
                    {
                        string file = openFileDialog1.FileName;
                        string conn = "server=localhost;user=root;database=administrasi;";
                        MySqlBackup mb = new MySqlBackup(conn);
                        mb.ImportInfo.FileName = file;
                        mb.ImportInfo.EnableEncryption = true;
                        mb.ImportInfo.EncryptionKey = radTextPassword.Text;
                        mb.Import();
                        MessageBox.Show("Berhasil Restore Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        string file = openFileDialog1.FileName;
                        string conn = "server=localhost;user=root;database=administrasi;";
                        MySqlBackup mb = new MySqlBackup(conn);
                        mb.ImportInfo.FileName = file;
                        mb.Import();
                        MessageBox.Show("Berhasil Restore Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Database ter-Enkripsi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Masukkan lokasi simpan database", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radCheckEnkripsi_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radCheckEnkripsi.Checked == true)
            {
                radTextPassword.Enabled = true;
            }
            else
            {
                radTextPassword.Enabled = false;
            }
        }
    }
}

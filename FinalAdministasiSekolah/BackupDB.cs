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
    public partial class BackupDB : Telerik.WinControls.UI.RadForm
    {
        string conn = "server=localhost;user=root;database=administrasi";

        public BackupDB()
        {
            InitializeComponent();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            LoadTables();
        }

        private void radButtonBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "SQL (*.sql) | *.sql";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                radTextFileLokasi.Text = saveFileDialog1.FileName;
            }
        }

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == colnSelect.Index || e.ColumnIndex == colntable.Index)
            {
                dataGridView1.Rows[e.RowIndex].Cells[colnSelect.Index].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[colnSelect.Index].Value);
                dataGridView1.EndEdit();
                dataGridView1.ClearSelection();
            }
        }

        private void radButtonSemua_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                dgvr.Cells[colnSelect.Index].Value = true;
            }
            dataGridView1.ClearSelection();
        }

        private void radButtonKosong_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                dgvr.Cells[colnSelect.Index].Value = false;
            }
            dataGridView1.ClearSelection();
        }

        private void LoadTables()
        {
            MySqlBackup mb = new MySqlBackup(conn);
            string[] tables = mb.DatabaseInfo.TableNames;
            dataGridView1.Rows.Clear();
            foreach (string s in tables)
            {
                dataGridView1.Rows[dataGridView1.Rows.Add()].Cells[colntable.Index].Value = s;
            }
            dataGridView1.ClearSelection();
        }

        private void BackupTables()
        {
            string file = radTextFileLokasi.Text;
            
            MySqlBackup mb = new MySqlBackup(conn);
            mb.ExportInfo.FileName = file;
            mb.ExportInfo.TableCustomSql = GetTableSql();
            mb.Export();
            MessageBox.Show("Berhasil Backup Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        Dictionary<string, string> GetTableSql()
        {
            Dictionary<string, string> dicTableSql = new Dictionary<string, string>();
            foreach (DataGridViewRow dgvr in dataGridView1.Rows) 
            {
                if (Convert.ToBoolean(dgvr.Cells[colnSelect.Index].Value))
                {
                    string tablename = dgvr.Cells[colntable.Index].Value + "";
                    string sql = "";
                    if (sql == "")
                    {
                        sql = string.Format("SELECT * FROM `{0}`;", tablename);
                    }
                    dicTableSql.Add(tablename, sql);
                }
            }
            if (dicTableSql.Count == 0)
                return null;
            return dicTableSql;
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonSimpan_Click(object sender, EventArgs e)
        {
                try
                {
                    saveFileDialog1.Filter = "SQL (*.sql) | *.sql";
                    if (radCheckEnkripsi.Checked == true)
                    {
                        string file = radTextFileLokasi.Text;
                        string conn = "server=localhost;user=root;database=administrasi";
                        MySqlBackup mb = new MySqlBackup(conn);
                        mb.ExportInfo.FileName = file;
                        mb.ExportInfo.TableCustomSql = GetTableSql();
                        mb.ExportInfo.EnableEncryption = true;
                        mb.ExportInfo.EncryptionKey = radTextPassword.Text;
                        mb.Export();
                        MessageBox.Show("Berhasil Backup Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        string file = radTextFileLokasi.Text;

                        MySqlBackup mb = new MySqlBackup(conn);
                        mb.ExportInfo.FileName = file;
                        mb.ExportInfo.TableCustomSql = GetTableSql();
                        mb.Export();
                        MessageBox.Show("Berhasil Backup Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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

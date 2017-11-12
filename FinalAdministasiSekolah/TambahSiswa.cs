using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class TambahSiswa : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string nis;

        public TambahSiswa()
        {
            InitializeComponent();
        }

        private Boolean statusNIS(string nis)
        {
            nis = nis.ToUpper();

            //SqlConnection connection = new SqlConnection(strConnection);
            //connection.Open();
            koneksi = new Koneksi();
            koneksi.koneksiDB.Open();
            string select = "SELECT nis from tsiswa";
            MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0).ToString().ToUpper() == nis))
                {
                    return true;
                }
            }
            koneksi.koneksiDB.Close();
            return false;
        }

        private void radButtonSimpan_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string nis = textBoxNIS.Text;
            string nama = textBoxNama.Text;
            string kelas = comboBoxKelas.Text;

            if (statusNIS(textBoxNIS.Text) == true)
            {
                MessageBox.Show("NIS " + nis + " sudah ada","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string insert = "insert into tsiswa (nis,nama,kelas,tanggal) values (@nis, @nama, @kelas, @tanggal)";

                    MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", nis);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@kelas", kelas);
                    cmd.Parameters.AddWithValue("@tanggal", date);

                    int inserResult = cmd.ExecuteNonQuery();

                    if (inserResult == 1)
                    {
                        MessageBox.Show("Sukses");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal");
                    }

                    koneksi.koneksiDB.Close();
                }
            }
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class EditTabungan : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nis { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string jumlah { get; set; }

        public EditTabungan()
        {
            InitializeComponent();
        }

        private void EditTabungan_Load(object sender, EventArgs e)
        {
            labelNIS.Text = nis;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
            textJumlah.Text = jumlah;
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonUbah_Click(object sender, EventArgs e)
        {
            string jumlahUbah = textJumlah.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update ttabungan set jumlah = @jumlahUbah where id_tabung = @id";
                string update = "update ttotal set total = (total - @jumlah) + @jumlahUbah where nis = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);
                MySqlCommand cmd1 = new MySqlCommand(update, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@jumlahUbah", int.Parse(jumlahUbah));
                cmd1.Parameters.AddWithValue("@id", int.Parse(nis));
                cmd1.Parameters.AddWithValue("@jumlahUbah", int.Parse(jumlahUbah));
                cmd1.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));

                int insertResult = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                koneksi.koneksiDB.Close();
            }
        }

        
    }
}

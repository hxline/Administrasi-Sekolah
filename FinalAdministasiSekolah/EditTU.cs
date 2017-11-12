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
using System.Security.Cryptography;

namespace FinalAdministasiSekolah
{
    public partial class EditTU : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nama { get; set; }

        public EditTU()
        {
            InitializeComponent();
        }

        private void EditTU_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = nama;
        }

        public static string md5_enkripsi(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void radButtonSimpan_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string password = textBoxPassword.Text;
            string passwordmd5 = md5_enkripsi(password);

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update ttu set nama = @nama, password = @password where id_tu = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@password", passwordmd5);

                int insertResult = cmd.ExecuteNonQuery();

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

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

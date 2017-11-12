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
    public partial class TambahTU : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;

        public TambahTU()
        {
            InitializeComponent();
        }

        private Boolean statusID(string id)
        {
            id = id.ToUpper();

            //SqlConnection connection = new SqlConnection(strConnection);
            //connection.Open();
            koneksi = new Koneksi();
            koneksi.koneksiDB.Open();
            string select = "SELECT id_tu from ttu";
            MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0).ToString().ToUpper() == id))
                {
                    return true;
                }
            }
            koneksi.koneksiDB.Close();
            return false;
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

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string id = textBoxID.Text;
            string nama = textBoxNama.Text;
            string password = textBoxPassword.Text;
            string passwordmd5 = md5_enkripsi(password);
            
            if (statusID(textBoxID.Text) == true)
            {
                MessageBox.Show("ID " + id + " sudah ada","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string insert = "insert into ttu (id_tu,nama,password,tanggal) values (@id, @nama, @password, @tanggal)";

                    MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@password", passwordmd5);
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

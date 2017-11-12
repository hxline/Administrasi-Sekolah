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
    public partial class FormTotal : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        DataTable table;
        public string nis { get; set; }
        public string button { get; set; }


        public FormTotal()
        {
            InitializeComponent();
        }

        private void BindDataTotalTabungan()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(jumlah) as Total from ttabungan where nis = @nis";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                cmd.Parameters.AddWithValue("@nis", nis);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void BindDataTotalTabunganKeluar()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(jumlah) as Total from ttabungankeluar where nis = @nis";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                cmd.Parameters.AddWithValue("@nis", nis);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void BindDataTotalPembayaran()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(total) as 'Total Pembayaran' from tpembayaran";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void BindDataTotalPendaftaran()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(jumlah) as 'Total Uang Pendaftaran' from tdaftar";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void FormTotal_Load(object sender, EventArgs e)
        {
            if (button == "pembayaran")
            {
                BindDataTotalPembayaran();
            }
            else if (button == "tabungan")
            {
                BindDataTotalTabungan();
            }
            else if (button == "pendaftaran")
            {
                BindDataTotalPendaftaran();
            }
            else if (button == "tabungankeluar")
            {
                BindDataTotalTabunganKeluar();
            }
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

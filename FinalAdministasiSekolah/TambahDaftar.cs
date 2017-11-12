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
    public partial class TambahDaftar : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string idTU { get; set; }

        public TambahDaftar()
        {
            InitializeComponent();
        }

        private void TambahDaftar_Load(object sender, EventArgs e)
        {
            labelNIS.Text = id;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
            if (kelas == "6")
            {
                comboJenis.Enabled = false;
                comboBoxKelas.Enabled = false;
                radCheckAuto.Enabled = false;
                radButtonTambah.Enabled = false;
            }
            else
            {
                comboJenis.Enabled = true;
                comboBoxKelas.Enabled = true;
                radCheckAuto.Enabled = true;
                radButtonTambah.Enabled = true;
            }
            comboBoxKelas.Text = kelas;
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboJenis.Text == "Daftar Ulang")
            {
                labelJumlah.Text = "500000";
                radCheckAuto.Visible = true;
                labelKelasAuto.Visible = true;
                comboBoxKelas.Visible = true;
            }
            else if (comboJenis.Text == "Daftar Baru")
            {
                labelJumlah.Text = "1000000";
                radCheckAuto.Visible = false;
                labelKelasAuto.Visible = false;
                comboBoxKelas.Visible = false;
            }
        }

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string jenis = comboJenis.Text;
            string jumlah = labelJumlah.Text;

            if (comboJenis.Text == "Daftar Baru" && (kelas=="2" || kelas=="3" || kelas=="4" || kelas=="5" || kelas=="6"))
            {
                        MessageBox.Show("Kelas "+ kelas + " tidak bisa daftar baru","Pesan Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (comboJenis.Text == "Daftar Baru")
            {
                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string insert = "insert into tdaftar(nis,jenis,jumlah,tanggal,id_tu) values (@nis,@jenis,@jumlah,@tanggal,@id_tu)";

                    MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", int.Parse(id));
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));
                    cmd.Parameters.AddWithValue("@tanggal", date);
                    cmd.Parameters.AddWithValue("@id_tu", int.Parse(idTU));

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
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
            else if (comboJenis.Text == "Daftar Ulang" && radCheckAuto.Checked == true)
            {
                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string insert = "insert into tdaftar(nis,jenis,jumlah,tanggal,id_tu) values (@nis,@jenis,@jumlah,@tanggal,@id_tu)";
                    string update = "update tsiswa set kelas = kelas + 1 where nis = @nis";

                    MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);
                    MySqlCommand cmdi = new MySqlCommand(update, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", int.Parse(id));
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));
                    cmd.Parameters.AddWithValue("@tanggal", date);
                    cmd.Parameters.AddWithValue("@id_tu", int.Parse(idTU));
                    cmdi.Parameters.AddWithValue("@nis", int.Parse(id));

                    int insertResult = cmd.ExecuteNonQuery();
                    cmdi.ExecuteNonQuery();

                    if (insertResult == 1)
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
            else if (comboJenis.Text == "Daftar Ulang" && radCheckAuto.Checked == false)
            {
                //SqlConnection connection = new SqlConnection(strConnection);

                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string insert = "insert into tdaftar(nis,jenis,jumlah,tanggal,id_tu) values (@nis,@jenis,@jumlah,@tanggal,@id_tu)";
                    string update = "update tsiswa set kelas = @kelas where nis = @nis";

                    MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);
                    MySqlCommand cmdi = new MySqlCommand(update, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", int.Parse(id));
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));
                    cmd.Parameters.AddWithValue("@tanggal", date);
                    cmd.Parameters.AddWithValue("@id_tu", int.Parse(idTU));
                    cmdi.Parameters.AddWithValue("@nis", int.Parse(id));
                    cmdi.Parameters.AddWithValue("@kelas", int.Parse(comboBoxKelas.Text));

                    int insertResult = cmd.ExecuteNonQuery();
                    cmdi.ExecuteNonQuery();

                    if (insertResult == 1)
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

        private void radCheckAuto_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radCheckAuto.Checked == true)
            {
                comboBoxKelas.Visible = false;
            }
            else if (radCheckAuto.Checked == false)
            {
                comboBoxKelas.Visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class AmbilTabungan : Telerik.WinControls.UI.RadForm
    {
        Koneksi koneksi;
        public string nis { get; set; }
        public string idTU { get; set; }
        public string saldo { get; set; }


        public AmbilTabungan()
        {
            InitializeComponent();
        }

        private void ButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAmbil_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string jumlah = TextJumlah.Text;

            if (int.Parse(saldo) < int.Parse(jumlah))
            {
                MessageBox.Show("Saldo Anda Tidak Cukup","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                koneksi = new Koneksi();

                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string ubah = "update ttotal set total = (total - @jumlah) where nis = @id";
                    string insert = "insert into ttabungankeluar (nis,jumlah,tanggal,id_tu) values (@nis,@jumlah,@tanggal,@id_tu)";

                    MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);
                    MySqlCommand cmdi = new MySqlCommand(insert, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", int.Parse(nis));
                    cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));
                    cmdi.Parameters.AddWithValue("@nis", nis);
                    cmdi.Parameters.AddWithValue("@jumlah", jumlah);
                    cmdi.Parameters.AddWithValue("@tanggal", date);
                    cmdi.Parameters.AddWithValue("@id_tu", idTU);

                    int insertResult = cmd.ExecuteNonQuery();
                    cmdi.ExecuteNonQuery();

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

        private void AmbilTabungan_Load(object sender, EventArgs e)
        {
            LabelNIS.Text = nis;
        }
    }
}

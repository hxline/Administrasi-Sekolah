using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Laporan_Final
{
    public partial class LaporanAdministrasi : Telerik.WinControls.UI.RadForm
    {
        public LaporanAdministrasi()
        {
            InitializeComponent();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            FormPembayaran bayar = new FormPembayaran();
            bayar.ShowDialog();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            FormPendaftaran daftar = new FormPendaftaran();
            daftar.ShowDialog();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            FormSurat surat = new FormSurat();
            surat.ShowDialog();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            FormTabungan tabung = new FormTabungan();
            tabung.ShowDialog();
        }
    }
}

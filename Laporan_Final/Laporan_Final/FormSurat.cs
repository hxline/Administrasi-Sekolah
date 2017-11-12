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
    public partial class FormSurat : Telerik.WinControls.UI.RadForm
    {
        public FormSurat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radCheckBox3.Checked == true && radCheckBox2.Checked == true && radCheckBox4.Checked==true)
            {
                ReportSurat pembayaran = new ReportSurat();
                Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();
                Telerik.Reporting.Filter filter2 = new Telerik.Reporting.Filter();
                Telerik.Reporting.Filter filter3 = new Telerik.Reporting.Filter();
                Telerik.Reporting.Filter filter4 = new Telerik.Reporting.Filter();

                filter1.Expression = "=Fields.tanggal";
                filter1.Operator = Telerik.Reporting.FilterOperator.GreaterOrEqual;
                filter1.Value = "" + radDateTimePicker1.Value.Date + "";
                filter2.Expression = "=Fields.tanggal";
                filter2.Operator = Telerik.Reporting.FilterOperator.LessOrEqual;
                filter2.Value = "" + radDateTimePicker2.Value.Date + "";
                filter3.Expression = "=Fields.pengirim";
                filter3.Operator = Telerik.Reporting.FilterOperator.Like;
                filter3.Value = "%" + textBox1.Text + "%";
                filter4.Expression = "=Fields.jenis";
                filter4.Operator = Telerik.Reporting.FilterOperator.Equal;
                filter4.Value = "" + comboBox1.Text + "";

                pembayaran.Filters.Add(filter1);
                pembayaran.Filters.Add(filter2);
                pembayaran.Filters.Add(filter3);
                pembayaran.Filters.Add(filter4);
                reportViewer1.ReportSource = pembayaran;
                reportViewer1.RefreshReport();
            }
            else if (radCheckBox3.Checked == true)
            {
                ReportSurat pembayaran = new ReportSurat();
                Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();

                filter1.Expression = "=Fields.pengirim";
                filter1.Operator = Telerik.Reporting.FilterOperator.Like;
                filter1.Value = "%" + textBox1.Text + "%";

                pembayaran.Filters.Add(filter1);
                reportViewer1.ReportSource = pembayaran;
                reportViewer1.RefreshReport();

            }
            else if (radCheckBox4.Checked == true)
            {
                ReportSurat pembayaran = new ReportSurat();
                Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();

                filter1.Expression = "=Fields.jenis";
                filter1.Operator = Telerik.Reporting.FilterOperator.Equal;
                filter1.Value = "" + comboBox1.Text + "";

                pembayaran.Filters.Add(filter1);
                reportViewer1.ReportSource = pembayaran;
                reportViewer1.RefreshReport();

            }
            else if (radCheckBox2.Checked == true)
            {
                ReportSurat pembayaran = new ReportSurat();
                Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();
                Telerik.Reporting.Filter filter2 = new Telerik.Reporting.Filter();


                filter1.Expression = "=Fields.tanggal";
                filter1.Operator = Telerik.Reporting.FilterOperator.GreaterOrEqual;
                filter1.Value = "" + radDateTimePicker1.Value.Date + "";
                filter2.Expression = "=Fields.tanggal";
                filter2.Operator = Telerik.Reporting.FilterOperator.LessOrEqual;
                filter2.Value = "" + radDateTimePicker2.Value.Date + "";


                pembayaran.Filters.Add(filter1);
                pembayaran.Filters.Add(filter2);


                reportViewer1.ReportSource = pembayaran;
                reportViewer1.RefreshReport();

            }

            else
            {
                ReportSurat pembayaran = new ReportSurat();
                reportViewer1.ReportSource = pembayaran;
                reportViewer1.RefreshReport();
            }
        }
    }
}

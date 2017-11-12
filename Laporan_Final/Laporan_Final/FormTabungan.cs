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
    public partial class FormTabungan : Telerik.WinControls.UI.RadForm
    {
        public FormTabungan()
        {
            InitializeComponent();
        }

        private void FormTabungan_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (radCheckBox1.Checked == true && radCheckBox2.Checked == true)
                {
                    ReportTabungan pembayaran = new ReportTabungan();
                    Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();
                    Telerik.Reporting.Filter filter2 = new Telerik.Reporting.Filter();
                    Telerik.Reporting.Filter filter3 = new Telerik.Reporting.Filter();

                    filter1.Expression = "=Fields.tanggal";
                    filter1.Operator = Telerik.Reporting.FilterOperator.GreaterOrEqual;
                    filter1.Value = "" + radDateTimePicker1.Value.Date + "";
                    filter2.Expression = "=Fields.tanggal";
                    filter2.Operator = Telerik.Reporting.FilterOperator.LessOrEqual;
                    filter2.Value = "" + radDateTimePicker2.Value.Date + "";
                    filter3.Expression = "=Fields.kelas";
                    filter3.Operator = Telerik.Reporting.FilterOperator.Equal;
                    filter3.Value = "" + comboBox1.Text + "";

                    pembayaran.Filters.Add(filter1);
                    pembayaran.Filters.Add(filter2);
                    pembayaran.Filters.Add(filter3);
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();
                }
                else if (radCheckBox1.Checked == true)
                {
                    ReportTabungan pembayaran = new ReportTabungan();
                    Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();

                    filter1.Expression = "=Fields.kelas";
                    filter1.Operator = Telerik.Reporting.FilterOperator.Equal;
                    filter1.Value = "" + comboBox1.Text + "";

                    pembayaran.Filters.Add(filter1);
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();

                }
                else if (radCheckBox3.Checked == true)
                {
                    ReportTabungan pembayaran = new ReportTabungan();
                    Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();

                    filter1.Expression = "=Fields.nama";
                    filter1.Operator = Telerik.Reporting.FilterOperator.Like;
                    filter1.Value = "%" + textBox1.Text + "%";

                    pembayaran.Filters.Add(filter1);
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();

                }
                else if (radCheckBox2.Checked == true)
                {
                    ReportTabungan pembayaran = new ReportTabungan();
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
                    ReportTabungan pembayaran = new ReportTabungan();
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();
                }
            }
            else
            {
                if (radCheckBox1.Checked == true && radCheckBox2.Checked == true)
                {
                    ReportTabunganKeluar pembayaran = new ReportTabunganKeluar();
                    Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();
                    Telerik.Reporting.Filter filter2 = new Telerik.Reporting.Filter();
                    Telerik.Reporting.Filter filter3 = new Telerik.Reporting.Filter();

                    filter1.Expression = "=Fields.tanggal";
                    filter1.Operator = Telerik.Reporting.FilterOperator.GreaterOrEqual;
                    filter1.Value = "" + radDateTimePicker1.Value.Date + "";
                    filter2.Expression = "=Fields.tanggal";
                    filter2.Operator = Telerik.Reporting.FilterOperator.LessOrEqual;
                    filter2.Value = "" + radDateTimePicker2.Value.Date + "";
                    filter3.Expression = "=Fields.kelas";
                    filter3.Operator = Telerik.Reporting.FilterOperator.Equal;
                    filter3.Value = "" + comboBox1.Text + "";

                    pembayaran.Filters.Add(filter1);
                    pembayaran.Filters.Add(filter2);
                    pembayaran.Filters.Add(filter3);
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();
                }
                else if (radCheckBox1.Checked == true)
                {
                    ReportTabunganKeluar pembayaran = new ReportTabunganKeluar();
                    Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();

                    filter1.Expression = "=Fields.kelas";
                    filter1.Operator = Telerik.Reporting.FilterOperator.Equal;
                    filter1.Value = "" + comboBox1.Text + "";

                    pembayaran.Filters.Add(filter1);
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();

                }
                else if (radCheckBox3.Checked == true)
                {
                    ReportTabunganKeluar pembayaran = new ReportTabunganKeluar();
                    Telerik.Reporting.Filter filter1 = new Telerik.Reporting.Filter();

                    filter1.Expression = "=Fields.nama";
                    filter1.Operator = Telerik.Reporting.FilterOperator.Like;
                    filter1.Value = "%" + textBox1.Text + "%";

                    pembayaran.Filters.Add(filter1);
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();

                }
                else if (radCheckBox2.Checked == true)
                {
                    ReportTabunganKeluar pembayaran = new ReportTabunganKeluar();
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
                    ReportTabunganKeluar pembayaran = new ReportTabunganKeluar();
                    reportViewer1.ReportSource = pembayaran;
                    reportViewer1.RefreshReport();
                }
            }
        }
    }
}

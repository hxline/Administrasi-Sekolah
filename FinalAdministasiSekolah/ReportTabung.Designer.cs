namespace FinalAdministasiSekolah
{
    partial class ReportTabung
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTabung));
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.tanggalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.jumlahCaptionTextBox = new Telerik.Reporting.TextBox();
            this.expr1CaptionTextBox = new Telerik.Reporting.TextBox();
            this.expr2CaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.nisCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nisDataTextBox = new Telerik.Reporting.TextBox();
            this.namaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.namaDataTextBox = new Telerik.Reporting.TextBox();
            this.kelasCaptionTextBox = new Telerik.Reporting.TextBox();
            this.kelasDataTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.tanggalDataTextBox = new Telerik.Reporting.TextBox();
            this.jumlahDataTextBox = new Telerik.Reporting.TextBox();
            this.expr1DataTextBox = new Telerik.Reporting.TextBox();
            this.expr2DataTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Dsn=mysql;uid=root";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.ProviderName = "System.Data.Odbc";
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.tanggalCaptionTextBox,
            this.jumlahCaptionTextBox,
            this.expr1CaptionTextBox,
            this.expr2CaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // tanggalCaptionTextBox
            // 
            this.tanggalCaptionTextBox.CanGrow = true;
            this.tanggalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.tanggalCaptionTextBox.Name = "tanggalCaptionTextBox";
            this.tanggalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.tanggalCaptionTextBox.StyleName = "Caption";
            this.tanggalCaptionTextBox.Value = "Tanggal";
            // 
            // jumlahCaptionTextBox
            // 
            this.jumlahCaptionTextBox.CanGrow = true;
            this.jumlahCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.jumlahCaptionTextBox.Name = "jumlahCaptionTextBox";
            this.jumlahCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.jumlahCaptionTextBox.StyleName = "Caption";
            this.jumlahCaptionTextBox.Value = "Tabungan Masuk";
            // 
            // expr1CaptionTextBox
            // 
            this.expr1CaptionTextBox.CanGrow = true;
            this.expr1CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.expr1CaptionTextBox.Name = "expr1CaptionTextBox";
            this.expr1CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.expr1CaptionTextBox.StyleName = "Caption";
            this.expr1CaptionTextBox.Value = "Tanggal";
            // 
            // expr2CaptionTextBox
            // 
            this.expr2CaptionTextBox.CanGrow = true;
            this.expr2CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.expr2CaptionTextBox.Name = "expr2CaptionTextBox";
            this.expr2CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.expr2CaptionTextBox.StyleName = "Caption";
            this.expr2CaptionTextBox.Value = "Tabungan Keluar";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4166665077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "ReportTabung";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2290682792663574D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.nisCaptionTextBox,
            this.nisDataTextBox,
            this.namaCaptionTextBox,
            this.namaDataTextBox,
            this.kelasCaptionTextBox,
            this.kelasDataTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.78740161657333374D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Report Tabung Siswa";
            // 
            // nisCaptionTextBox
            // 
            this.nisCaptionTextBox.CanGrow = true;
            this.nisCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.nisCaptionTextBox.Name = "nisCaptionTextBox";
            this.nisCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.nisCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.nisCaptionTextBox.StyleName = "Caption";
            this.nisCaptionTextBox.Value = "Nis:";
            // 
            // nisDataTextBox
            // 
            this.nisDataTextBox.CanGrow = true;
            this.nisDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.09375D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.nisDataTextBox.Name = "nisDataTextBox";
            this.nisDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.nisDataTextBox.StyleName = "Data";
            this.nisDataTextBox.Value = "=Fields.nis";
            // 
            // namaCaptionTextBox
            // 
            this.namaCaptionTextBox.CanGrow = true;
            this.namaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1666667461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.namaCaptionTextBox.Name = "namaCaptionTextBox";
            this.namaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.namaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.namaCaptionTextBox.StyleName = "Caption";
            this.namaCaptionTextBox.Value = "Nama:";
            // 
            // namaDataTextBox
            // 
            this.namaDataTextBox.CanGrow = true;
            this.namaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.namaDataTextBox.Name = "namaDataTextBox";
            this.namaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.namaDataTextBox.StyleName = "Data";
            this.namaDataTextBox.Value = "=Fields.nama";
            // 
            // kelasCaptionTextBox
            // 
            this.kelasCaptionTextBox.CanGrow = true;
            this.kelasCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.kelasCaptionTextBox.Name = "kelasCaptionTextBox";
            this.kelasCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.kelasCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.kelasCaptionTextBox.StyleName = "Caption";
            this.kelasCaptionTextBox.Value = "Kelas:";
            // 
            // kelasDataTextBox
            // 
            this.kelasDataTextBox.CanGrow = true;
            this.kelasDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3854165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.kelasDataTextBox.Name = "kelasDataTextBox";
            this.kelasDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.kelasDataTextBox.StyleName = "Data";
            this.kelasDataTextBox.Value = "=Fields.kelas";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.42075443267822266D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.tanggalDataTextBox,
            this.jumlahDataTextBox,
            this.expr1DataTextBox,
            this.expr2DataTextBox});
            this.detail.Name = "detail";
            // 
            // tanggalDataTextBox
            // 
            this.tanggalDataTextBox.CanGrow = true;
            formattingRule1.Filters.Add(new Telerik.Reporting.Filter("=Fields.nama", Telerik.Reporting.FilterOperator.Equal, "fahri"));
            this.tanggalDataTextBox.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.tanggalDataTextBox.Format = "{0:d}";
            this.tanggalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.tanggalDataTextBox.Name = "tanggalDataTextBox";
            this.tanggalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.tanggalDataTextBox.StyleName = "Data";
            this.tanggalDataTextBox.Value = "=Fields.tanggal";
            // 
            // jumlahDataTextBox
            // 
            this.jumlahDataTextBox.CanGrow = true;
            this.jumlahDataTextBox.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.jumlahDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.jumlahDataTextBox.Name = "jumlahDataTextBox";
            this.jumlahDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.jumlahDataTextBox.StyleName = "Data";
            this.jumlahDataTextBox.Value = "=Fields.jumlah";
            // 
            // expr1DataTextBox
            // 
            this.expr1DataTextBox.CanGrow = true;
            this.expr1DataTextBox.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.expr1DataTextBox.Format = "{0:d}";
            this.expr1DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.expr1DataTextBox.Name = "expr1DataTextBox";
            this.expr1DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.expr1DataTextBox.StyleName = "Data";
            this.expr1DataTextBox.Value = "=Fields.Expr1";
            // 
            // expr2DataTextBox
            // 
            this.expr2DataTextBox.CanGrow = true;
            this.expr2DataTextBox.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.expr2DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.expr2DataTextBox.Name = "expr2DataTextBox";
            this.expr2DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.expr2DataTextBox.StyleName = "Data";
            this.expr2DataTextBox.Value = "=Fields.Expr2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            this.textBox1.Value = "= Sum(Fields.jumlah)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.020754178985953331D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000024437904358D));
            this.textBox2.Value = "= Sum(Fields.Expr2)";
            // 
            // ReportTabung
            // 
            this.DataSource = this.sqlDataSource1;
            this.Filters.Add(new Telerik.Reporting.Filter("=Fields.nis", Telerik.Reporting.FilterOperator.Equal, "10115"));
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "ReportTabung";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(103)))), ((int)(((byte)(109)))));
            styleRule1.Style.Font.Name = "Book Antiqua";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(103)))), ((int)(((byte)(109)))));
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(102)))));
            styleRule2.Style.Font.Name = "Book Antiqua";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Book Antiqua";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            styleRule4.Style.Font.Name = "Book Antiqua";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox tanggalCaptionTextBox;
        private Telerik.Reporting.TextBox jumlahCaptionTextBox;
        private Telerik.Reporting.TextBox expr1CaptionTextBox;
        private Telerik.Reporting.TextBox expr2CaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox nisCaptionTextBox;
        private Telerik.Reporting.TextBox nisDataTextBox;
        private Telerik.Reporting.TextBox namaCaptionTextBox;
        private Telerik.Reporting.TextBox namaDataTextBox;
        private Telerik.Reporting.TextBox kelasCaptionTextBox;
        private Telerik.Reporting.TextBox kelasDataTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox tanggalDataTextBox;
        private Telerik.Reporting.TextBox jumlahDataTextBox;
        private Telerik.Reporting.TextBox expr1DataTextBox;
        private Telerik.Reporting.TextBox expr2DataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;

    }
}
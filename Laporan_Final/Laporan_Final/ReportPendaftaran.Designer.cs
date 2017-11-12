namespace Laporan_Final
{
    partial class ReportPendaftaran
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPendaftaran));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.nisCaptionTextBox = new Telerik.Reporting.TextBox();
            this.namaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.kelasCaptionTextBox = new Telerik.Reporting.TextBox();
            this.tanggalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.jenisCaptionTextBox = new Telerik.Reporting.TextBox();
            this.jumlahCaptionTextBox = new Telerik.Reporting.TextBox();
            this.petugasCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.nisDataTextBox = new Telerik.Reporting.TextBox();
            this.namaDataTextBox = new Telerik.Reporting.TextBox();
            this.kelasDataTextBox = new Telerik.Reporting.TextBox();
            this.tanggalDataTextBox = new Telerik.Reporting.TextBox();
            this.jenisDataTextBox = new Telerik.Reporting.TextBox();
            this.jumlahDataTextBox = new Telerik.Reporting.TextBox();
            this.petugasDataTextBox = new Telerik.Reporting.TextBox();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "DATABASE=administrasi;DSN=mysql;OPTION=0;PORT=3306;SERVER=localhost;UID=root;";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.ProviderName = "System.Data.Odbc";
            this.sqlDataSource1.SelectCommand = "SELECT        tsiswa.nis, tsiswa.nama, tsiswa.kelas, tdaftar.jenis, tdaftar.jumla" +
    "h, tdaftar.tanggal, ttu.nama AS Petugas\r\nFROM            tdaftar\r\njoin ttu using" +
    "(id_tu)\r\njoin tsiswa using(nis)";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nisCaptionTextBox,
            this.namaCaptionTextBox,
            this.kelasCaptionTextBox,
            this.tanggalCaptionTextBox,
            this.jenisCaptionTextBox,
            this.jumlahCaptionTextBox,
            this.petugasCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // nisCaptionTextBox
            // 
            this.nisCaptionTextBox.CanGrow = true;
            this.nisCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nisCaptionTextBox.Name = "nisCaptionTextBox";
            this.nisCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.nisCaptionTextBox.StyleName = "Caption";
            this.nisCaptionTextBox.Value = "Nis";
            // 
            // namaCaptionTextBox
            // 
            this.namaCaptionTextBox.CanGrow = true;
            this.namaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.9404761791229248D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.namaCaptionTextBox.Name = "namaCaptionTextBox";
            this.namaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.namaCaptionTextBox.StyleName = "Caption";
            this.namaCaptionTextBox.Value = "Nama";
            // 
            // kelasCaptionTextBox
            // 
            this.kelasCaptionTextBox.CanGrow = true;
            this.kelasCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8601189851760864D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.kelasCaptionTextBox.Name = "kelasCaptionTextBox";
            this.kelasCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.kelasCaptionTextBox.StyleName = "Caption";
            this.kelasCaptionTextBox.Value = "Kelas";
            // 
            // tanggalCaptionTextBox
            // 
            this.tanggalCaptionTextBox.CanGrow = true;
            this.tanggalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.779761791229248D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.tanggalCaptionTextBox.Name = "tanggalCaptionTextBox";
            this.tanggalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.tanggalCaptionTextBox.StyleName = "Caption";
            this.tanggalCaptionTextBox.Value = "Tanggal";
            // 
            // jenisCaptionTextBox
            // 
            this.jenisCaptionTextBox.CanGrow = true;
            this.jenisCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6994047164916992D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.jenisCaptionTextBox.Name = "jenisCaptionTextBox";
            this.jenisCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.jenisCaptionTextBox.StyleName = "Caption";
            this.jenisCaptionTextBox.Value = "Jenis";
            // 
            // jumlahCaptionTextBox
            // 
            this.jumlahCaptionTextBox.CanGrow = true;
            this.jumlahCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.61904764175415D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.jumlahCaptionTextBox.Name = "jumlahCaptionTextBox";
            this.jumlahCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.jumlahCaptionTextBox.StyleName = "Caption";
            this.jumlahCaptionTextBox.Value = "Jumlah";
            // 
            // petugasCaptionTextBox
            // 
            this.petugasCaptionTextBox.CanGrow = true;
            this.petugasCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5386905670166016D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.petugasCaptionTextBox.Name = "petugasCaptionTextBox";
            this.petugasCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.petugasCaptionTextBox.StyleName = "Caption";
            this.petugasCaptionTextBox.Value = "Petugas";
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
            this.reportNameTextBox.Value = "ReportPendaftaran";
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3583332300186157D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.pictureBox1});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.8583331108093262D), Telerik.Reporting.Drawing.Unit.Inch(1.158333420753479D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Laporan Pendaftaran\r\nSD IT Serang Banten";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nisDataTextBox,
            this.namaDataTextBox,
            this.kelasDataTextBox,
            this.tanggalDataTextBox,
            this.jenisDataTextBox,
            this.jumlahDataTextBox,
            this.petugasDataTextBox});
            this.detail.Name = "detail";
            // 
            // nisDataTextBox
            // 
            this.nisDataTextBox.CanGrow = true;
            this.nisDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nisDataTextBox.Name = "nisDataTextBox";
            this.nisDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.nisDataTextBox.StyleName = "Data";
            this.nisDataTextBox.Value = "=Fields.nis";
            // 
            // namaDataTextBox
            // 
            this.namaDataTextBox.CanGrow = true;
            this.namaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.9404761791229248D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.namaDataTextBox.Name = "namaDataTextBox";
            this.namaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.namaDataTextBox.StyleName = "Data";
            this.namaDataTextBox.Value = "=Fields.nama";
            // 
            // kelasDataTextBox
            // 
            this.kelasDataTextBox.CanGrow = true;
            this.kelasDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8601189851760864D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.kelasDataTextBox.Name = "kelasDataTextBox";
            this.kelasDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.kelasDataTextBox.StyleName = "Data";
            this.kelasDataTextBox.Value = "=Fields.kelas";
            // 
            // tanggalDataTextBox
            // 
            this.tanggalDataTextBox.CanGrow = true;
            this.tanggalDataTextBox.Format = "{0:d}";
            this.tanggalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.779761791229248D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.tanggalDataTextBox.Name = "tanggalDataTextBox";
            this.tanggalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.tanggalDataTextBox.StyleName = "Data";
            this.tanggalDataTextBox.Value = "=Fields.tanggal";
            // 
            // jenisDataTextBox
            // 
            this.jenisDataTextBox.CanGrow = true;
            this.jenisDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6994047164916992D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.jenisDataTextBox.Name = "jenisDataTextBox";
            this.jenisDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.jenisDataTextBox.StyleName = "Data";
            this.jenisDataTextBox.Value = "=Fields.jenis";
            // 
            // jumlahDataTextBox
            // 
            this.jumlahDataTextBox.CanGrow = true;
            this.jumlahDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.61904764175415D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.jumlahDataTextBox.Name = "jumlahDataTextBox";
            this.jumlahDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.jumlahDataTextBox.StyleName = "Data";
            this.jumlahDataTextBox.Value = "=Fields.jumlah";
            // 
            // petugasDataTextBox
            // 
            this.petugasDataTextBox.CanGrow = true;
            this.petugasDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5386905670166016D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.petugasDataTextBox.Name = "petugasDataTextBox";
            this.petugasDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.petugasDataTextBox.StyleName = "Data";
            this.petugasDataTextBox.Value = "=Fields.Petugas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5790878534317017D), Telerik.Reporting.Drawing.Unit.Inch(1.3583332300186157D));
            this.pictureBox1.Style.BackgroundImage.ImageData = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Style.BackgroundImage.ImageData")));
            this.pictureBox1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // ReportPendaftaran
            // 
            this.DataSource = this.sqlDataSource1;
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
            this.Name = "ReportPendaftaran";
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
        private Telerik.Reporting.TextBox nisCaptionTextBox;
        private Telerik.Reporting.TextBox namaCaptionTextBox;
        private Telerik.Reporting.TextBox kelasCaptionTextBox;
        private Telerik.Reporting.TextBox tanggalCaptionTextBox;
        private Telerik.Reporting.TextBox jenisCaptionTextBox;
        private Telerik.Reporting.TextBox jumlahCaptionTextBox;
        private Telerik.Reporting.TextBox petugasCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox nisDataTextBox;
        private Telerik.Reporting.TextBox namaDataTextBox;
        private Telerik.Reporting.TextBox kelasDataTextBox;
        private Telerik.Reporting.TextBox tanggalDataTextBox;
        private Telerik.Reporting.TextBox jenisDataTextBox;
        private Telerik.Reporting.TextBox jumlahDataTextBox;
        private Telerik.Reporting.TextBox petugasDataTextBox;
        private Telerik.Reporting.PictureBox pictureBox1;

    }
}
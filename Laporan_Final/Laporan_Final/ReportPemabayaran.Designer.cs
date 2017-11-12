namespace Laporan_Final
{
    partial class ReportPemabayaran
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPemabayaran));
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
            this.bulanCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sppCaptionTextBox = new Telerik.Reporting.TextBox();
            this.marching_bandCaptionTextBox = new Telerik.Reporting.TextBox();
            this.catheringCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalCaptionTextBox = new Telerik.Reporting.TextBox();
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
            this.bulanDataTextBox = new Telerik.Reporting.TextBox();
            this.sppDataTextBox = new Telerik.Reporting.TextBox();
            this.marching_bandDataTextBox = new Telerik.Reporting.TextBox();
            this.catheringDataTextBox = new Telerik.Reporting.TextBox();
            this.totalDataTextBox = new Telerik.Reporting.TextBox();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "DATABASE=administrasi;DSN=mysql;OPTION=0;PORT=3306;SERVER=localhost;UID=root;";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.ProviderName = "System.Data.Odbc";
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nisCaptionTextBox,
            this.namaCaptionTextBox,
            this.kelasCaptionTextBox,
            this.tanggalCaptionTextBox,
            this.bulanCaptionTextBox,
            this.sppCaptionTextBox,
            this.marching_bandCaptionTextBox,
            this.catheringCaptionTextBox,
            this.totalCaptionTextBox});
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
            this.nisCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.nisCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.nisCaptionTextBox.StyleName = "Caption";
            this.nisCaptionTextBox.Value = "Nis";
            // 
            // namaCaptionTextBox
            // 
            this.namaCaptionTextBox.CanGrow = true;
            this.namaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.7361111044883728D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.namaCaptionTextBox.Name = "namaCaptionTextBox";
            this.namaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.namaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.namaCaptionTextBox.StyleName = "Caption";
            this.namaCaptionTextBox.Value = "Nama";
            // 
            // kelasCaptionTextBox
            // 
            this.kelasCaptionTextBox.CanGrow = true;
            this.kelasCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4513888359069824D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.kelasCaptionTextBox.Name = "kelasCaptionTextBox";
            this.kelasCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5486111044883728D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.kelasCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.kelasCaptionTextBox.StyleName = "Caption";
            this.kelasCaptionTextBox.Value = "Kelas";
            // 
            // tanggalCaptionTextBox
            // 
            this.tanggalCaptionTextBox.CanGrow = true;
            this.tanggalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.019444465637207D), Telerik.Reporting.Drawing.Unit.Inch(0.023650698363780975D));
            this.tanggalCaptionTextBox.Name = "tanggalCaptionTextBox";
            this.tanggalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.84166651964187622D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.tanggalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.tanggalCaptionTextBox.StyleName = "Caption";
            this.tanggalCaptionTextBox.Value = "Tanggal";
            // 
            // bulanCaptionTextBox
            // 
            this.bulanCaptionTextBox.CanGrow = true;
            this.bulanCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8819444179534912D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.bulanCaptionTextBox.Name = "bulanCaptionTextBox";
            this.bulanCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.bulanCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.bulanCaptionTextBox.StyleName = "Caption";
            this.bulanCaptionTextBox.Value = "Bulan";
            // 
            // sppCaptionTextBox
            // 
            this.sppCaptionTextBox.CanGrow = true;
            this.sppCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5972220897674561D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.sppCaptionTextBox.Name = "sppCaptionTextBox";
            this.sppCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.sppCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.sppCaptionTextBox.StyleName = "Caption";
            this.sppCaptionTextBox.Value = "SPP";
            // 
            // marching_bandCaptionTextBox
            // 
            this.marching_bandCaptionTextBox.CanGrow = true;
            this.marching_bandCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.marching_bandCaptionTextBox.Name = "marching_bandCaptionTextBox";
            this.marching_bandCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.marching_bandCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.marching_bandCaptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.marching_bandCaptionTextBox.StyleName = "Caption";
            this.marching_bandCaptionTextBox.Value = "Marching Band";
            // 
            // catheringCaptionTextBox
            // 
            this.catheringCaptionTextBox.CanGrow = true;
            this.catheringCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0277776718139648D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.catheringCaptionTextBox.Name = "catheringCaptionTextBox";
            this.catheringCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.catheringCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.catheringCaptionTextBox.StyleName = "Caption";
            this.catheringCaptionTextBox.Value = "Cathering";
            // 
            // totalCaptionTextBox
            // 
            this.totalCaptionTextBox.CanGrow = true;
            this.totalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.74305534362793D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.totalCaptionTextBox.Name = "totalCaptionTextBox";
            this.totalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.totalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.totalCaptionTextBox.StyleName = "Caption";
            this.totalCaptionTextBox.Value = "Subtotal";
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
            this.reportNameTextBox.Value = "ReportPemabayaran";
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
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4513888359069824D), Telerik.Reporting.Drawing.Unit.Inch(0.020793914794921875D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0069050788879395D), Telerik.Reporting.Drawing.Unit.Inch(1.3374999761581421D));
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Laporan Pembayaran\r\nSD IT Serang Banten";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
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
            this.bulanDataTextBox,
            this.sppDataTextBox,
            this.marching_bandDataTextBox,
            this.catheringDataTextBox,
            this.totalDataTextBox});
            this.detail.Name = "detail";
            // 
            // nisDataTextBox
            // 
            this.nisDataTextBox.CanGrow = true;
            this.nisDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nisDataTextBox.Name = "nisDataTextBox";
            this.nisDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.nisDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.nisDataTextBox.StyleName = "Data";
            this.nisDataTextBox.Value = "=Fields.nis";
            // 
            // namaDataTextBox
            // 
            this.namaDataTextBox.CanGrow = true;
            this.namaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.7361111044883728D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.namaDataTextBox.Name = "namaDataTextBox";
            this.namaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.namaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.namaDataTextBox.StyleName = "Data";
            this.namaDataTextBox.Value = "=Fields.nama";
            // 
            // kelasDataTextBox
            // 
            this.kelasDataTextBox.CanGrow = true;
            this.kelasDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4513888359069824D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.kelasDataTextBox.Name = "kelasDataTextBox";
            this.kelasDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5486111044883728D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.kelasDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.kelasDataTextBox.StyleName = "Data";
            this.kelasDataTextBox.Value = "=Fields.kelas";
            // 
            // tanggalDataTextBox
            // 
            this.tanggalDataTextBox.CanGrow = true;
            this.tanggalDataTextBox.Format = "{0:d}";
            this.tanggalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0000789165496826D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.tanggalDataTextBox.Name = "tanggalDataTextBox";
            this.tanggalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.861032247543335D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.tanggalDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.tanggalDataTextBox.StyleName = "Data";
            this.tanggalDataTextBox.Value = "=Fields.tanggal";
            // 
            // bulanDataTextBox
            // 
            this.bulanDataTextBox.CanGrow = true;
            this.bulanDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8819444179534912D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.bulanDataTextBox.Name = "bulanDataTextBox";
            this.bulanDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.bulanDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.bulanDataTextBox.StyleName = "Data";
            this.bulanDataTextBox.Value = "=Fields.bulan";
            // 
            // sppDataTextBox
            // 
            this.sppDataTextBox.CanGrow = true;
            this.sppDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5972220897674561D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.sppDataTextBox.Name = "sppDataTextBox";
            this.sppDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.sppDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.sppDataTextBox.StyleName = "Data";
            this.sppDataTextBox.Value = "=Fields.spp";
            // 
            // marching_bandDataTextBox
            // 
            this.marching_bandDataTextBox.CanGrow = true;
            this.marching_bandDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.marching_bandDataTextBox.Name = "marching_bandDataTextBox";
            this.marching_bandDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.marching_bandDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.marching_bandDataTextBox.StyleName = "Data";
            this.marching_bandDataTextBox.Value = "=Fields.marching_band";
            // 
            // catheringDataTextBox
            // 
            this.catheringDataTextBox.CanGrow = true;
            this.catheringDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0277776718139648D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.catheringDataTextBox.Name = "catheringDataTextBox";
            this.catheringDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.catheringDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.catheringDataTextBox.StyleName = "Data";
            this.catheringDataTextBox.Value = "=Fields.cathering";
            // 
            // totalDataTextBox
            // 
            this.totalDataTextBox.CanGrow = true;
            this.totalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.74305534362793D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.totalDataTextBox.Name = "totalDataTextBox";
            this.totalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69444441795349121D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.totalDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.totalDataTextBox.StyleName = "Data";
            this.totalDataTextBox.Value = "=Fields.total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4097222089767456D), Telerik.Reporting.Drawing.Unit.Inch(1.3582936525344849D));
            this.pictureBox1.Style.BackgroundImage.ImageData = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Style.BackgroundImage.ImageData")));
            this.pictureBox1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // textBox1
            // 
            this.textBox1.Format = "{0:Rp #, ##0}";
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2374997138977051D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054D), Telerik.Reporting.Drawing.Unit.Inch(0.23541705310344696D));
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "=sum(Fields.total)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0374207496643066D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054D), Telerik.Reporting.Drawing.Unit.Inch(0.23541705310344696D));
            this.textBox2.Value = "Total :";
            // 
            // ReportPemabayaran
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
            this.Name = "ReportPemabayaran";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            styleRule1.Style.Font.Name = "Verdana";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            styleRule2.Style.Font.Name = "Verdana";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Verdana";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            styleRule4.Style.Font.Name = "Verdana";
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
        private Telerik.Reporting.TextBox bulanCaptionTextBox;
        private Telerik.Reporting.TextBox sppCaptionTextBox;
        private Telerik.Reporting.TextBox marching_bandCaptionTextBox;
        private Telerik.Reporting.TextBox catheringCaptionTextBox;
        private Telerik.Reporting.TextBox totalCaptionTextBox;
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
        private Telerik.Reporting.TextBox bulanDataTextBox;
        private Telerik.Reporting.TextBox sppDataTextBox;
        private Telerik.Reporting.TextBox marching_bandDataTextBox;
        private Telerik.Reporting.TextBox catheringDataTextBox;
        private Telerik.Reporting.TextBox totalDataTextBox;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;

    }
}
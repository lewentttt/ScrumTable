namespace KursSeminer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBasTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.txtProjeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgwKart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBitisTar = new System.Windows.Forms.DateTimePicker();
            this.dtpPlanTar = new System.Windows.Forms.DateTimePicker();
            this.cmbUzman = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgwGorev = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGorevDuzelt = new System.Windows.Forms.Button();
            this.btnGorevYeni = new System.Windows.Forms.Button();
            this.btnGorevIptal = new System.Windows.Forms.Button();
            this.btnGorevKaydet = new System.Windows.Forms.Button();
            this.txtGorevDurumAciklama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGorev)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nitelik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teknik Kart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(132, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 36);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(338, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Başl.Tarihi";
            // 
            // dtpBasTarih
            // 
            this.dtpBasTarih.CustomFormat = "dd MMMM yyyy";
            this.dtpBasTarih.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBasTarih.Location = new System.Drawing.Point(409, 58);
            this.dtpBasTarih.Name = "dtpBasTarih";
            this.dtpBasTarih.Size = new System.Drawing.Size(162, 24);
            this.dtpBasTarih.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kart No";
            // 
            // txtKartNo
            // 
            this.txtKartNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKartNo.Enabled = false;
            this.txtKartNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKartNo.Location = new System.Drawing.Point(109, 58);
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(179, 24);
            this.txtKartNo.TabIndex = 47;
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProjeNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.Location = new System.Drawing.Point(109, 88);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.Size = new System.Drawing.Size(179, 24);
            this.txtProjeNo.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Proje No / Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(300, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Teknik Uzman";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(315, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Planlanan Tar.";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAciklama.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(21, 135);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(419, 45);
            this.txtAciklama.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "İşin Açıklaması";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotlar.Location = new System.Drawing.Point(446, 135);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(389, 45);
            this.txtNotlar.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(443, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Notlar";
            // 
            // dgwKart
            // 
            this.dgwKart.AllowUserToAddRows = false;
            this.dgwKart.BackgroundColor = System.Drawing.Color.White;
            this.dgwKart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwKart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwKart.ColumnHeadersHeight = 25;
            this.dgwKart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwKart.EnableHeadersVisualStyles = false;
            this.dgwKart.Location = new System.Drawing.Point(21, 402);
            this.dgwKart.Name = "dgwKart";
            this.dgwKart.RowHeadersVisible = false;
            this.dgwKart.Size = new System.Drawing.Size(814, 154);
            this.dgwKart.TabIndex = 60;
            this.dgwKart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKart_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sn";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tarih";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Açıklama";
            this.Column5.Name = "Column5";
            this.Column5.Width = 360;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teknik Uzman";
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Durum";
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "pkKartID";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // btnYeni
            // 
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.Location = new System.Drawing.Point(610, 12);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(54, 53);
            this.btnYeni.TabIndex = 61;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIptal.Location = new System.Drawing.Point(721, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(54, 53);
            this.btnIptal.TabIndex = 63;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(670, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(54, 53);
            this.btnKaydet.TabIndex = 62;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.FlatAppearance.BorderSize = 0;
            this.btnDuzelt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzelt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzelt.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzelt.Image")));
            this.btnDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuzelt.Location = new System.Drawing.Point(781, 12);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(54, 53);
            this.btnDuzelt.TabIndex = 64;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(586, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Bitiş Tarihi";
            // 
            // dtpBitisTar
            // 
            this.dtpBitisTar.CustomFormat = "dd MMMM yyyy";
            this.dtpBitisTar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitisTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitisTar.Location = new System.Drawing.Point(658, 88);
            this.dtpBitisTar.Name = "dtpBitisTar";
            this.dtpBitisTar.Size = new System.Drawing.Size(173, 24);
            this.dtpBitisTar.TabIndex = 65;
            // 
            // dtpPlanTar
            // 
            this.dtpPlanTar.CustomFormat = "dd MMMM yyyy";
            this.dtpPlanTar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpPlanTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPlanTar.Location = new System.Drawing.Point(409, 88);
            this.dtpPlanTar.Name = "dtpPlanTar";
            this.dtpPlanTar.Size = new System.Drawing.Size(162, 24);
            this.dtpPlanTar.TabIndex = 67;
            // 
            // cmbUzman
            // 
            this.cmbUzman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUzman.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUzman.FormattingEnabled = true;
            this.cmbUzman.Items.AddRange(new object[] {
            "Seçiniz",
            "Levent ALBAYRAK",
            "Dilek ÖZÖVGÜ"});
            this.cmbUzman.Location = new System.Drawing.Point(398, 369);
            this.cmbUzman.Name = "cmbUzman";
            this.cmbUzman.Size = new System.Drawing.Size(173, 23);
            this.cmbUzman.TabIndex = 68;
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbDurum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Seçiniz",
            "ToDo",
            "InProgress",
            "Revison",
            "Check",
            "Done"});
            this.cmbDurum.Location = new System.Drawing.Point(398, 340);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(173, 23);
            this.cmbDurum.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(339, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "Durum";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dgwGorev
            // 
            this.dgwGorev.AllowUserToAddRows = false;
            this.dgwGorev.BackgroundColor = System.Drawing.Color.White;
            this.dgwGorev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwGorev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwGorev.ColumnHeadersHeight = 25;
            this.dgwGorev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Column8,
            this.Column9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwGorev.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwGorev.EnableHeadersVisualStyles = false;
            this.dgwGorev.Location = new System.Drawing.Point(21, 186);
            this.dgwGorev.Name = "dgwGorev";
            this.dgwGorev.RowHeadersVisible = false;
            this.dgwGorev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwGorev.Size = new System.Drawing.Size(814, 125);
            this.dgwGorev.TabIndex = 71;
            this.dgwGorev.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGorev_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Proje No / Adı";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Baslangıç Tarihi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Planlanan Tarih";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Bitiş Tarihi";
            this.Column9.Name = "Column9";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "pkServisID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // btnGorevDuzelt
            // 
            this.btnGorevDuzelt.FlatAppearance.BorderSize = 0;
            this.btnGorevDuzelt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevDuzelt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevDuzelt.Image = ((System.Drawing.Image)(resources.GetObject("btnGorevDuzelt.Image")));
            this.btnGorevDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGorevDuzelt.Location = new System.Drawing.Point(781, 317);
            this.btnGorevDuzelt.Name = "btnGorevDuzelt";
            this.btnGorevDuzelt.Size = new System.Drawing.Size(54, 53);
            this.btnGorevDuzelt.TabIndex = 75;
            this.btnGorevDuzelt.Text = "Düzelt";
            this.btnGorevDuzelt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGorevDuzelt.UseVisualStyleBackColor = true;
            this.btnGorevDuzelt.Click += new System.EventHandler(this.btnGorevDuzelt_Click);
            // 
            // btnGorevYeni
            // 
            this.btnGorevYeni.FlatAppearance.BorderSize = 0;
            this.btnGorevYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevYeni.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnGorevYeni.Image")));
            this.btnGorevYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGorevYeni.Location = new System.Drawing.Point(610, 317);
            this.btnGorevYeni.Name = "btnGorevYeni";
            this.btnGorevYeni.Size = new System.Drawing.Size(54, 53);
            this.btnGorevYeni.TabIndex = 72;
            this.btnGorevYeni.Text = "Yeni";
            this.btnGorevYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGorevYeni.UseVisualStyleBackColor = true;
            this.btnGorevYeni.Click += new System.EventHandler(this.btnGorevYeni_Click);
            // 
            // btnGorevIptal
            // 
            this.btnGorevIptal.FlatAppearance.BorderSize = 0;
            this.btnGorevIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevIptal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnGorevIptal.Image")));
            this.btnGorevIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGorevIptal.Location = new System.Drawing.Point(721, 317);
            this.btnGorevIptal.Name = "btnGorevIptal";
            this.btnGorevIptal.Size = new System.Drawing.Size(54, 53);
            this.btnGorevIptal.TabIndex = 74;
            this.btnGorevIptal.Text = "İptal";
            this.btnGorevIptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGorevIptal.UseVisualStyleBackColor = true;
            this.btnGorevIptal.Click += new System.EventHandler(this.btnGorevIptal_Click);
            // 
            // btnGorevKaydet
            // 
            this.btnGorevKaydet.FlatAppearance.BorderSize = 0;
            this.btnGorevKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevKaydet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnGorevKaydet.Image")));
            this.btnGorevKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGorevKaydet.Location = new System.Drawing.Point(670, 317);
            this.btnGorevKaydet.Name = "btnGorevKaydet";
            this.btnGorevKaydet.Size = new System.Drawing.Size(54, 53);
            this.btnGorevKaydet.TabIndex = 73;
            this.btnGorevKaydet.Text = "Kaydet";
            this.btnGorevKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGorevKaydet.UseVisualStyleBackColor = true;
            this.btnGorevKaydet.Click += new System.EventHandler(this.btnGorevKaydet_Click);
            // 
            // txtGorevDurumAciklama
            // 
            this.txtGorevDurumAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGorevDurumAciklama.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorevDurumAciklama.Location = new System.Drawing.Point(31, 340);
            this.txtGorevDurumAciklama.Multiline = true;
            this.txtGorevDurumAciklama.Name = "txtGorevDurumAciklama";
            this.txtGorevDurumAciklama.Size = new System.Drawing.Size(257, 53);
            this.txtGorevDurumAciklama.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(28, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 76;
            this.label12.Text = "Açıklama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(586, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 79;
            this.label13.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "dd MMMM yyyy";
            this.dtpTarih.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarih.Location = new System.Drawing.Point(658, 372);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(173, 24);
            this.dtpTarih.TabIndex = 78;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 568);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtGorevDurumAciklama);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGorevDuzelt);
            this.Controls.Add(this.btnGorevYeni);
            this.Controls.Add(this.btnGorevIptal);
            this.Controls.Add(this.btnGorevKaydet);
            this.Controls.Add(this.dgwGorev);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbUzman);
            this.Controls.Add(this.dtpPlanTar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBitisTar);
            this.Controls.Add(this.btnDuzelt);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgwKart);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKartNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBasTarih);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGorev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpBasTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.TextBox txtProjeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgwKart;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBitisTar;
        private System.Windows.Forms.DateTimePicker dtpPlanTar;
        private System.Windows.Forms.ComboBox cmbUzman;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgwGorev;
        private System.Windows.Forms.Button btnGorevDuzelt;
        private System.Windows.Forms.Button btnGorevYeni;
        private System.Windows.Forms.Button btnGorevIptal;
        private System.Windows.Forms.Button btnGorevKaydet;
        private System.Windows.Forms.TextBox txtGorevDurumAciklama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
namespace DernekTakipApp.Forms
{
    partial class FormMemberDues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemberDues));
            panel1 = new Panel();
            LabelHeaderText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label16 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            LabelOcakAidat = new Label();
            LabelSubatAidat = new Label();
            LabelMartAidat = new Label();
            LabelNisanAidat = new Label();
            LabelMayisAidat = new Label();
            LabelHaziranAidat = new Label();
            LabelTemmuzAidat = new Label();
            LabelAgustosAidat = new Label();
            LabelEylulAidat = new Label();
            LabelEkimAidat = new Label();
            LabelKasimAidat = new Label();
            LabelAralikAidat = new Label();
            LabelOcakKalan = new Label();
            LabelSubatKalan = new Label();
            LabelMartKalan = new Label();
            LabelNisanKalan = new Label();
            LabelMayisKalan = new Label();
            LabelHaziranKalan = new Label();
            LabelTemmuzKalan = new Label();
            LabelAgustosKalan = new Label();
            LabelEylulKalan = new Label();
            LabelEkimKalan = new Label();
            LabelKasimKalan = new Label();
            LabelAralikKalan = new Label();
            ComboBoxYear = new ComboBox();
            ButtonSave = new Button();
            TextBoxOcakOdenen = new TextBox();
            TextBoxSubatOdenen = new TextBox();
            TextBoxMartOdenen = new TextBox();
            TextBoxNisanOdenen = new TextBox();
            TextBoxMayisOdenen = new TextBox();
            TextBoxHaziranOdenen = new TextBox();
            TextBoxTemmuzOdenen = new TextBox();
            TextBoxAgustosOdenen = new TextBox();
            TextBoxEylulOdenen = new TextBox();
            TextBoxEkimOdenen = new TextBox();
            TextBoxKasimOdenen = new TextBox();
            TextBoxAralikOdenen = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(38, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 1);
            panel1.TabIndex = 0;
            // 
            // LabelHeaderText
            // 
            LabelHeaderText.Anchor = AnchorStyles.Bottom;
            LabelHeaderText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LabelHeaderText, 2);
            LabelHeaderText.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderText.Location = new Point(242, 81);
            LabelHeaderText.Margin = new Padding(3, 0, 3, 10);
            LabelHeaderText.Name = "LabelHeaderText";
            LabelHeaderText.Size = new Size(319, 33);
            LabelHeaderText.TabIndex = 1;
            LabelHeaderText.Text = "Üye Aidat Ödeme Tablosu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(LabelHeaderText, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(ComboBoxYear, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonSave, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(35);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.54167F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.45833F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(803, 578);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(label8, 0, 5);
            tableLayoutPanel2.Controls.Add(label9, 0, 6);
            tableLayoutPanel2.Controls.Add(label10, 0, 7);
            tableLayoutPanel2.Controls.Add(label11, 0, 8);
            tableLayoutPanel2.Controls.Add(label12, 0, 9);
            tableLayoutPanel2.Controls.Add(label13, 0, 10);
            tableLayoutPanel2.Controls.Add(label14, 0, 11);
            tableLayoutPanel2.Controls.Add(label15, 0, 12);
            tableLayoutPanel2.Controls.Add(LabelOcakAidat, 1, 1);
            tableLayoutPanel2.Controls.Add(LabelSubatAidat, 1, 2);
            tableLayoutPanel2.Controls.Add(LabelMartAidat, 1, 3);
            tableLayoutPanel2.Controls.Add(LabelNisanAidat, 1, 4);
            tableLayoutPanel2.Controls.Add(LabelMayisAidat, 1, 5);
            tableLayoutPanel2.Controls.Add(LabelHaziranAidat, 1, 6);
            tableLayoutPanel2.Controls.Add(LabelTemmuzAidat, 1, 7);
            tableLayoutPanel2.Controls.Add(LabelAgustosAidat, 1, 8);
            tableLayoutPanel2.Controls.Add(LabelEylulAidat, 1, 9);
            tableLayoutPanel2.Controls.Add(LabelEkimAidat, 1, 10);
            tableLayoutPanel2.Controls.Add(LabelKasimAidat, 1, 11);
            tableLayoutPanel2.Controls.Add(LabelAralikAidat, 1, 12);
            tableLayoutPanel2.Controls.Add(LabelOcakKalan, 3, 1);
            tableLayoutPanel2.Controls.Add(LabelSubatKalan, 3, 2);
            tableLayoutPanel2.Controls.Add(LabelMartKalan, 3, 3);
            tableLayoutPanel2.Controls.Add(LabelNisanKalan, 3, 4);
            tableLayoutPanel2.Controls.Add(LabelMayisKalan, 3, 5);
            tableLayoutPanel2.Controls.Add(LabelHaziranKalan, 3, 6);
            tableLayoutPanel2.Controls.Add(LabelTemmuzKalan, 3, 7);
            tableLayoutPanel2.Controls.Add(LabelAgustosKalan, 3, 8);
            tableLayoutPanel2.Controls.Add(LabelEylulKalan, 3, 9);
            tableLayoutPanel2.Controls.Add(LabelEkimKalan, 3, 10);
            tableLayoutPanel2.Controls.Add(LabelKasimKalan, 3, 11);
            tableLayoutPanel2.Controls.Add(LabelAralikKalan, 3, 12);
            tableLayoutPanel2.Controls.Add(TextBoxOcakOdenen, 2, 1);
            tableLayoutPanel2.Controls.Add(TextBoxSubatOdenen, 2, 2);
            tableLayoutPanel2.Controls.Add(TextBoxMartOdenen, 2, 3);
            tableLayoutPanel2.Controls.Add(TextBoxNisanOdenen, 2, 4);
            tableLayoutPanel2.Controls.Add(TextBoxMayisOdenen, 2, 5);
            tableLayoutPanel2.Controls.Add(TextBoxHaziranOdenen, 2, 6);
            tableLayoutPanel2.Controls.Add(TextBoxTemmuzOdenen, 2, 7);
            tableLayoutPanel2.Controls.Add(TextBoxAgustosOdenen, 2, 8);
            tableLayoutPanel2.Controls.Add(TextBoxEylulOdenen, 2, 9);
            tableLayoutPanel2.Controls.Add(TextBoxEkimOdenen, 2, 10);
            tableLayoutPanel2.Controls.Add(TextBoxKasimOdenen, 2, 11);
            tableLayoutPanel2.Controls.Add(TextBoxAralikOdenen, 2, 12);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(38, 129);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692309F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(727, 375);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 35);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Ocak";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Silver;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 4);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label16, 3, 0);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1, 1);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(725, 27);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 6);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 4;
            label2.Text = "Ay";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(602, 6);
            label16.Name = "label16";
            label16.Size = new Size(63, 15);
            label16.TabIndex = 4;
            label16.Text = "Kalan Borç";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(236, 6);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Aidat Tutarı";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(427, 6);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Ödenen";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 63);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Şubat";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(74, 91);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 4;
            label6.Text = "Mart";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(72, 119);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 4;
            label7.Text = "Nisan";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(72, 147);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 4;
            label8.Text = "Mayıs";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(67, 175);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 4;
            label9.Text = "Haziran";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(64, 203);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 4;
            label10.Text = "Temmuz";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(66, 231);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 4;
            label11.Text = "Ağustos";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(75, 259);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 4;
            label12.Text = "Eylül";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(74, 287);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 4;
            label13.Text = "Ekim";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(71, 315);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 4;
            label14.Text = "Kasım";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(72, 348);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 4;
            label15.Text = "Aralık";
            // 
            // LabelOcakAidat
            // 
            LabelOcakAidat.Anchor = AnchorStyles.None;
            LabelOcakAidat.AutoSize = true;
            LabelOcakAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOcakAidat.Location = new Point(257, 35);
            LabelOcakAidat.Name = "LabelOcakAidat";
            LabelOcakAidat.Size = new Size(29, 15);
            LabelOcakAidat.TabIndex = 4;
            LabelOcakAidat.Text = "0 TL";
            // 
            // LabelSubatAidat
            // 
            LabelSubatAidat.Anchor = AnchorStyles.None;
            LabelSubatAidat.AutoSize = true;
            LabelSubatAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSubatAidat.Location = new Point(257, 63);
            LabelSubatAidat.Name = "LabelSubatAidat";
            LabelSubatAidat.Size = new Size(29, 15);
            LabelSubatAidat.TabIndex = 4;
            LabelSubatAidat.Text = "0 TL";
            // 
            // LabelMartAidat
            // 
            LabelMartAidat.Anchor = AnchorStyles.None;
            LabelMartAidat.AutoSize = true;
            LabelMartAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMartAidat.Location = new Point(257, 91);
            LabelMartAidat.Name = "LabelMartAidat";
            LabelMartAidat.Size = new Size(29, 15);
            LabelMartAidat.TabIndex = 4;
            LabelMartAidat.Text = "0 TL";
            // 
            // LabelNisanAidat
            // 
            LabelNisanAidat.Anchor = AnchorStyles.None;
            LabelNisanAidat.AutoSize = true;
            LabelNisanAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNisanAidat.Location = new Point(257, 119);
            LabelNisanAidat.Name = "LabelNisanAidat";
            LabelNisanAidat.Size = new Size(29, 15);
            LabelNisanAidat.TabIndex = 4;
            LabelNisanAidat.Text = "0 TL";
            // 
            // LabelMayisAidat
            // 
            LabelMayisAidat.Anchor = AnchorStyles.None;
            LabelMayisAidat.AutoSize = true;
            LabelMayisAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMayisAidat.Location = new Point(257, 147);
            LabelMayisAidat.Name = "LabelMayisAidat";
            LabelMayisAidat.Size = new Size(29, 15);
            LabelMayisAidat.TabIndex = 4;
            LabelMayisAidat.Text = "0 TL";
            // 
            // LabelHaziranAidat
            // 
            LabelHaziranAidat.Anchor = AnchorStyles.None;
            LabelHaziranAidat.AutoSize = true;
            LabelHaziranAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHaziranAidat.Location = new Point(257, 175);
            LabelHaziranAidat.Name = "LabelHaziranAidat";
            LabelHaziranAidat.Size = new Size(29, 15);
            LabelHaziranAidat.TabIndex = 4;
            LabelHaziranAidat.Text = "0 TL";
            // 
            // LabelTemmuzAidat
            // 
            LabelTemmuzAidat.Anchor = AnchorStyles.None;
            LabelTemmuzAidat.AutoSize = true;
            LabelTemmuzAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTemmuzAidat.Location = new Point(257, 203);
            LabelTemmuzAidat.Name = "LabelTemmuzAidat";
            LabelTemmuzAidat.Size = new Size(29, 15);
            LabelTemmuzAidat.TabIndex = 4;
            LabelTemmuzAidat.Text = "0 TL";
            // 
            // LabelAgustosAidat
            // 
            LabelAgustosAidat.Anchor = AnchorStyles.None;
            LabelAgustosAidat.AutoSize = true;
            LabelAgustosAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAgustosAidat.Location = new Point(257, 231);
            LabelAgustosAidat.Name = "LabelAgustosAidat";
            LabelAgustosAidat.Size = new Size(29, 15);
            LabelAgustosAidat.TabIndex = 4;
            LabelAgustosAidat.Text = "0 TL";
            // 
            // LabelEylulAidat
            // 
            LabelEylulAidat.Anchor = AnchorStyles.None;
            LabelEylulAidat.AutoSize = true;
            LabelEylulAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEylulAidat.Location = new Point(257, 259);
            LabelEylulAidat.Name = "LabelEylulAidat";
            LabelEylulAidat.Size = new Size(29, 15);
            LabelEylulAidat.TabIndex = 4;
            LabelEylulAidat.Text = "0 TL";
            // 
            // LabelEkimAidat
            // 
            LabelEkimAidat.Anchor = AnchorStyles.None;
            LabelEkimAidat.AutoSize = true;
            LabelEkimAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEkimAidat.Location = new Point(257, 287);
            LabelEkimAidat.Name = "LabelEkimAidat";
            LabelEkimAidat.Size = new Size(29, 15);
            LabelEkimAidat.TabIndex = 4;
            LabelEkimAidat.Text = "0 TL";
            // 
            // LabelKasimAidat
            // 
            LabelKasimAidat.Anchor = AnchorStyles.None;
            LabelKasimAidat.AutoSize = true;
            LabelKasimAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKasimAidat.Location = new Point(257, 315);
            LabelKasimAidat.Name = "LabelKasimAidat";
            LabelKasimAidat.Size = new Size(29, 15);
            LabelKasimAidat.TabIndex = 4;
            LabelKasimAidat.Text = "0 TL";
            // 
            // LabelAralikAidat
            // 
            LabelAralikAidat.Anchor = AnchorStyles.None;
            LabelAralikAidat.AutoSize = true;
            LabelAralikAidat.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAralikAidat.Location = new Point(257, 348);
            LabelAralikAidat.Name = "LabelAralikAidat";
            LabelAralikAidat.Size = new Size(29, 15);
            LabelAralikAidat.TabIndex = 4;
            LabelAralikAidat.Text = "0 TL";
            // 
            // LabelOcakKalan
            // 
            LabelOcakKalan.Anchor = AnchorStyles.None;
            LabelOcakKalan.AutoSize = true;
            LabelOcakKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOcakKalan.Location = new Point(620, 34);
            LabelOcakKalan.Name = "LabelOcakKalan";
            LabelOcakKalan.Size = new Size(30, 16);
            LabelOcakKalan.TabIndex = 4;
            LabelOcakKalan.Text = "0 TL";
            // 
            // LabelSubatKalan
            // 
            LabelSubatKalan.Anchor = AnchorStyles.None;
            LabelSubatKalan.AutoSize = true;
            LabelSubatKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSubatKalan.Location = new Point(620, 62);
            LabelSubatKalan.Name = "LabelSubatKalan";
            LabelSubatKalan.Size = new Size(30, 16);
            LabelSubatKalan.TabIndex = 4;
            LabelSubatKalan.Text = "0 TL";
            // 
            // LabelMartKalan
            // 
            LabelMartKalan.Anchor = AnchorStyles.None;
            LabelMartKalan.AutoSize = true;
            LabelMartKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMartKalan.Location = new Point(620, 90);
            LabelMartKalan.Name = "LabelMartKalan";
            LabelMartKalan.Size = new Size(30, 16);
            LabelMartKalan.TabIndex = 4;
            LabelMartKalan.Text = "0 TL";
            // 
            // LabelNisanKalan
            // 
            LabelNisanKalan.Anchor = AnchorStyles.None;
            LabelNisanKalan.AutoSize = true;
            LabelNisanKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNisanKalan.Location = new Point(620, 118);
            LabelNisanKalan.Name = "LabelNisanKalan";
            LabelNisanKalan.Size = new Size(30, 16);
            LabelNisanKalan.TabIndex = 4;
            LabelNisanKalan.Text = "0 TL";
            // 
            // LabelMayisKalan
            // 
            LabelMayisKalan.Anchor = AnchorStyles.None;
            LabelMayisKalan.AutoSize = true;
            LabelMayisKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMayisKalan.Location = new Point(620, 146);
            LabelMayisKalan.Name = "LabelMayisKalan";
            LabelMayisKalan.Size = new Size(30, 16);
            LabelMayisKalan.TabIndex = 4;
            LabelMayisKalan.Text = "0 TL";
            // 
            // LabelHaziranKalan
            // 
            LabelHaziranKalan.Anchor = AnchorStyles.None;
            LabelHaziranKalan.AutoSize = true;
            LabelHaziranKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHaziranKalan.Location = new Point(620, 174);
            LabelHaziranKalan.Name = "LabelHaziranKalan";
            LabelHaziranKalan.Size = new Size(30, 16);
            LabelHaziranKalan.TabIndex = 4;
            LabelHaziranKalan.Text = "0 TL";
            // 
            // LabelTemmuzKalan
            // 
            LabelTemmuzKalan.Anchor = AnchorStyles.None;
            LabelTemmuzKalan.AutoSize = true;
            LabelTemmuzKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTemmuzKalan.Location = new Point(620, 202);
            LabelTemmuzKalan.Name = "LabelTemmuzKalan";
            LabelTemmuzKalan.Size = new Size(30, 16);
            LabelTemmuzKalan.TabIndex = 4;
            LabelTemmuzKalan.Text = "0 TL";
            // 
            // LabelAgustosKalan
            // 
            LabelAgustosKalan.Anchor = AnchorStyles.None;
            LabelAgustosKalan.AutoSize = true;
            LabelAgustosKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAgustosKalan.Location = new Point(620, 230);
            LabelAgustosKalan.Name = "LabelAgustosKalan";
            LabelAgustosKalan.Size = new Size(30, 16);
            LabelAgustosKalan.TabIndex = 4;
            LabelAgustosKalan.Text = "0 TL";
            // 
            // LabelEylulKalan
            // 
            LabelEylulKalan.Anchor = AnchorStyles.None;
            LabelEylulKalan.AutoSize = true;
            LabelEylulKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEylulKalan.Location = new Point(620, 258);
            LabelEylulKalan.Name = "LabelEylulKalan";
            LabelEylulKalan.Size = new Size(30, 16);
            LabelEylulKalan.TabIndex = 4;
            LabelEylulKalan.Text = "0 TL";
            // 
            // LabelEkimKalan
            // 
            LabelEkimKalan.Anchor = AnchorStyles.None;
            LabelEkimKalan.AutoSize = true;
            LabelEkimKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEkimKalan.Location = new Point(620, 286);
            LabelEkimKalan.Name = "LabelEkimKalan";
            LabelEkimKalan.Size = new Size(30, 16);
            LabelEkimKalan.TabIndex = 4;
            LabelEkimKalan.Text = "0 TL";
            // 
            // LabelKasimKalan
            // 
            LabelKasimKalan.Anchor = AnchorStyles.None;
            LabelKasimKalan.AutoSize = true;
            LabelKasimKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKasimKalan.Location = new Point(620, 314);
            LabelKasimKalan.Name = "LabelKasimKalan";
            LabelKasimKalan.Size = new Size(30, 16);
            LabelKasimKalan.TabIndex = 4;
            LabelKasimKalan.Text = "0 TL";
            // 
            // LabelAralikKalan
            // 
            LabelAralikKalan.Anchor = AnchorStyles.None;
            LabelAralikKalan.AutoSize = true;
            LabelAralikKalan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAralikKalan.Location = new Point(620, 347);
            LabelAralikKalan.Name = "LabelAralikKalan";
            LabelAralikKalan.Size = new Size(30, 16);
            LabelAralikKalan.TabIndex = 4;
            LabelAralikKalan.Text = "0 TL";
            // 
            // ComboBoxYear
            // 
            ComboBoxYear.Anchor = AnchorStyles.Right;
            ComboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxYear.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxYear.FormattingEnabled = true;
            ComboBoxYear.Items.AddRange(new object[] { "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100" });
            ComboBoxYear.Location = new Point(618, 38);
            ComboBoxYear.Name = "ComboBoxYear";
            ComboBoxYear.Size = new Size(147, 23);
            ComboBoxYear.TabIndex = 5;
            ComboBoxYear.SelectedIndexChanged += ComboBoxYear_SelectedIndexChanged;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSave.BackColor = Color.FromArgb(240, 236, 87);
            ButtonSave.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.Location = new Point(512, 510);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(253, 30);
            ButtonSave.TabIndex = 8;
            ButtonSave.Text = "KAYDET";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // TextBoxOcakOdenen
            // 
            TextBoxOcakOdenen.Anchor = AnchorStyles.None;
            TextBoxOcakOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxOcakOdenen.Location = new Point(407, 32);
            TextBoxOcakOdenen.Name = "TextBoxOcakOdenen";
            TextBoxOcakOdenen.Size = new Size(91, 23);
            TextBoxOcakOdenen.TabIndex = 5;
            // 
            // TextBoxSubatOdenen
            // 
            TextBoxSubatOdenen.Anchor = AnchorStyles.None;
            TextBoxSubatOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxSubatOdenen.Location = new Point(407, 60);
            TextBoxSubatOdenen.Name = "TextBoxSubatOdenen";
            TextBoxSubatOdenen.Size = new Size(91, 23);
            TextBoxSubatOdenen.TabIndex = 5;
            // 
            // TextBoxMartOdenen
            // 
            TextBoxMartOdenen.Anchor = AnchorStyles.None;
            TextBoxMartOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxMartOdenen.Location = new Point(407, 88);
            TextBoxMartOdenen.Name = "TextBoxMartOdenen";
            TextBoxMartOdenen.Size = new Size(91, 23);
            TextBoxMartOdenen.TabIndex = 5;
            // 
            // TextBoxNisanOdenen
            // 
            TextBoxNisanOdenen.Anchor = AnchorStyles.None;
            TextBoxNisanOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxNisanOdenen.Location = new Point(407, 116);
            TextBoxNisanOdenen.Name = "TextBoxNisanOdenen";
            TextBoxNisanOdenen.Size = new Size(91, 23);
            TextBoxNisanOdenen.TabIndex = 5;
            // 
            // TextBoxMayisOdenen
            // 
            TextBoxMayisOdenen.Anchor = AnchorStyles.None;
            TextBoxMayisOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxMayisOdenen.Location = new Point(407, 144);
            TextBoxMayisOdenen.Name = "TextBoxMayisOdenen";
            TextBoxMayisOdenen.Size = new Size(91, 23);
            TextBoxMayisOdenen.TabIndex = 5;
            // 
            // TextBoxHaziranOdenen
            // 
            TextBoxHaziranOdenen.Anchor = AnchorStyles.None;
            TextBoxHaziranOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxHaziranOdenen.Location = new Point(407, 172);
            TextBoxHaziranOdenen.Name = "TextBoxHaziranOdenen";
            TextBoxHaziranOdenen.Size = new Size(91, 23);
            TextBoxHaziranOdenen.TabIndex = 5;
            // 
            // TextBoxTemmuzOdenen
            // 
            TextBoxTemmuzOdenen.Anchor = AnchorStyles.None;
            TextBoxTemmuzOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxTemmuzOdenen.Location = new Point(407, 200);
            TextBoxTemmuzOdenen.Name = "TextBoxTemmuzOdenen";
            TextBoxTemmuzOdenen.Size = new Size(91, 23);
            TextBoxTemmuzOdenen.TabIndex = 5;
            // 
            // TextBoxAgustosOdenen
            // 
            TextBoxAgustosOdenen.Anchor = AnchorStyles.None;
            TextBoxAgustosOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxAgustosOdenen.Location = new Point(407, 228);
            TextBoxAgustosOdenen.Name = "TextBoxAgustosOdenen";
            TextBoxAgustosOdenen.Size = new Size(91, 23);
            TextBoxAgustosOdenen.TabIndex = 5;
            // 
            // TextBoxEylulOdenen
            // 
            TextBoxEylulOdenen.Anchor = AnchorStyles.None;
            TextBoxEylulOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxEylulOdenen.Location = new Point(407, 256);
            TextBoxEylulOdenen.Name = "TextBoxEylulOdenen";
            TextBoxEylulOdenen.Size = new Size(91, 23);
            TextBoxEylulOdenen.TabIndex = 5;
            // 
            // TextBoxEkimOdenen
            // 
            TextBoxEkimOdenen.Anchor = AnchorStyles.None;
            TextBoxEkimOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxEkimOdenen.Location = new Point(407, 284);
            TextBoxEkimOdenen.Name = "TextBoxEkimOdenen";
            TextBoxEkimOdenen.Size = new Size(91, 23);
            TextBoxEkimOdenen.TabIndex = 5;
            // 
            // TextBoxKasimOdenen
            // 
            TextBoxKasimOdenen.Anchor = AnchorStyles.None;
            TextBoxKasimOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxKasimOdenen.Location = new Point(407, 312);
            TextBoxKasimOdenen.Name = "TextBoxKasimOdenen";
            TextBoxKasimOdenen.Size = new Size(91, 23);
            TextBoxKasimOdenen.TabIndex = 5;
            // 
            // TextBoxAralikOdenen
            // 
            TextBoxAralikOdenen.Anchor = AnchorStyles.None;
            TextBoxAralikOdenen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxAralikOdenen.Location = new Point(407, 344);
            TextBoxAralikOdenen.Name = "TextBoxAralikOdenen";
            TextBoxAralikOdenen.Size = new Size(91, 23);
            TextBoxAralikOdenen.TabIndex = 5;
            TextBoxAralikOdenen.Text = " ";
            // 
            // FormMemberDues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 578);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMemberDues";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Aidat Ödeme Durumu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        public Label LabelHeaderText;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        public Label LabelOcakAidat;
        public Label LabelSubatAidat;
        public Label LabelMartAidat;
        public Label LabelNisanAidat;
        public Label LabelMayisAidat;
        public Label LabelHaziranAidat;
        public Label LabelTemmuzAidat;
        public Label LabelAgustosAidat;
        public Label LabelEylulAidat;
        public Label LabelEkimAidat;
        public Label LabelKasimAidat;
        public Label LabelAralikAidat;
        public Label LabelAgustosOdenen;
        public Label LabelEylulOdenen;
        public Label LabelEkimOdenen;
        public Label LabelKasimOdenen;
        public Label LabelAralikOdenen;
        public Label LabelOcakKalan;
        public Label LabelSubatKalan;
        public Label LabelMartKalan;
        public Label LabelNisanKalan;
        public Label LabelMayisKalan;
        public Label LabelHaziranKalan;
        public Label LabelTemmuzKalan;
        public Label LabelAgustosKalan;
        public Label LabelEylulKalan;
        public Label LabelEkimKalan;
        public Label LabelKasimKalan;
        public Label LabelAralikKalan;
        public ComboBox ComboBoxYear;
        private Button ButtonSave;
        private TextBox TextBoxOcakOdenen;
        private TextBox TextBoxSubatOdenen;
        private TextBox TextBoxMartOdenen;
        private TextBox TextBoxNisanOdenen;
        private TextBox TextBoxMayisOdenen;
        private TextBox TextBoxHaziranOdenen;
        private TextBox TextBoxTemmuzOdenen;
        private TextBox TextBoxAgustosOdenen;
        private TextBox TextBoxEylulOdenen;
        private TextBox TextBoxEkimOdenen;
        private TextBox TextBoxKasimOdenen;
        private TextBox TextBoxAralikOdenen;
    }
}
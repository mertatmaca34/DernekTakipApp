namespace DernekTakipApp.Forms
{
    partial class FormMemberDebts
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            DataGridViewMemberDebts = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            ButtonSearch = new Button();
            groupBox3 = new GroupBox();
            ComboBoxFilter = new ComboBox();
            groupBox4 = new GroupBox();
            ButtonSendMails = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMemberDebts).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(DataGridViewMemberDebts, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(86, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1002, 681);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(154, 33);
            label1.TabIndex = 0;
            label1.Text = "Üye Borçları";
            // 
            // DataGridViewMemberDebts
            // 
            DataGridViewMemberDebts.AllowUserToAddRows = false;
            DataGridViewMemberDebts.AllowUserToDeleteRows = false;
            DataGridViewMemberDebts.AllowUserToResizeColumns = false;
            DataGridViewMemberDebts.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            DataGridViewMemberDebts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewMemberDebts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewMemberDebts.BackgroundColor = Color.White;
            DataGridViewMemberDebts.BorderStyle = BorderStyle.None;
            DataGridViewMemberDebts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewMemberDebts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle7.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            DataGridViewMemberDebts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewMemberDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(DataGridViewMemberDebts, 2);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(187, 206, 168);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DataGridViewMemberDebts.DefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewMemberDebts.Dock = DockStyle.Fill;
            DataGridViewMemberDebts.EnableHeadersVisualStyles = false;
            DataGridViewMemberDebts.GridColor = Color.WhiteSmoke;
            DataGridViewMemberDebts.Location = new Point(0, 140);
            DataGridViewMemberDebts.Margin = new Padding(0);
            DataGridViewMemberDebts.MultiSelect = false;
            DataGridViewMemberDebts.Name = "DataGridViewMemberDebts";
            DataGridViewMemberDebts.ReadOnly = true;
            DataGridViewMemberDebts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataGridViewMemberDebts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewMemberDebts.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.Padding = new Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(227, 216, 126);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DataGridViewMemberDebts.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DataGridViewMemberDebts.RowTemplate.DividerHeight = 10;
            DataGridViewMemberDebts.RowTemplate.Height = 50;
            DataGridViewMemberDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMemberDebts.Size = new Size(1002, 541);
            DataGridViewMemberDebts.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(ButtonSearch, 4, 0);
            tableLayoutPanel2.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 85);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(996, 52);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(3, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 22);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(202, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 46);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "BİTİŞ TARİHİ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Location = new Point(3, 18);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(187, 22);
            dateTimePicker2.TabIndex = 0;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Anchor = AnchorStyles.None;
            ButtonSearch.BackColor = Color.FromArgb(240, 236, 87);
            ButtonSearch.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSearch.Location = new Point(849, 12);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(93, 28);
            ButtonSearch.TabIndex = 1;
            ButtonSearch.Text = "ARA";
            ButtonSearch.UseVisualStyleBackColor = false;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ComboBoxFilter);
            groupBox3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(401, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 46);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "ÖDEME YAPAN/YAPMAYAN";
            // 
            // ComboBoxFilter
            // 
            ComboBoxFilter.Anchor = AnchorStyles.None;
            ComboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFilter.FormattingEnabled = true;
            ComboBoxFilter.Items.AddRange(new object[] { "HEPSİ", "ÖDEME YAPANLAR", "ÖDEME YAPMAYANLAR" });
            ComboBoxFilter.Location = new Point(6, 21);
            ComboBoxFilter.Name = "ComboBoxFilter";
            ComboBoxFilter.Size = new Size(181, 21);
            ComboBoxFilter.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ButtonSendMails);
            groupBox4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(600, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(193, 46);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "BORÇLU BİLGİLENDİRME";
            // 
            // ButtonSendMails
            // 
            ButtonSendMails.Anchor = AnchorStyles.None;
            ButtonSendMails.BackColor = Color.FromArgb(240, 236, 87);
            ButtonSendMails.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSendMails.Location = new Point(6, 18);
            ButtonSendMails.Name = "ButtonSendMails";
            ButtonSendMails.Size = new Size(181, 24);
            ButtonSendMails.TabIndex = 1;
            ButtonSendMails.Text = "MAİL GÖNDER";
            ButtonSendMails.UseVisualStyleBackColor = false;
            ButtonSendMails.Click += ButtonSendMails_Click;
            // 
            // FormMemberDebts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 681);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMemberDebts";
            Padding = new Padding(86, 0, 86, 0);
            Text = "FormMemberDebts";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMemberDebts).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView DataGridViewMemberDebts;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Button ButtonSearch;
        private ComboBox ComboBoxFilter;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button ButtonSendMails;
    }
}
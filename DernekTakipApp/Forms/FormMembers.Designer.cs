namespace DernekTakipApp.Forms
{
    partial class FormMembers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ButtonNewMember = new Button();
            DataGridViewMembers = new DataGridView();
            EditColumn = new DataGridViewImageColumn();
            DeleteColumn = new DataGridViewImageColumn();
            PaymentColumn = new DataGridViewButtonColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            TextBoxSearch = new TextBox();
            label2 = new Label();
            ComboBoxFilterBloodGroup = new ComboBox();
            label3 = new Label();
            ComboBoxFilterCity = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembers).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonNewMember, 1, 0);
            tableLayoutPanel1.Controls.Add(DataGridViewMembers, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(86, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1002, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(91, 33);
            label1.TabIndex = 0;
            label1.Text = "Üyeler";
            // 
            // ButtonNewMember
            // 
            ButtonNewMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonNewMember.BackColor = Color.FromArgb(240, 236, 87);
            ButtonNewMember.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonNewMember.Location = new Point(906, 51);
            ButtonNewMember.Name = "ButtonNewMember";
            ButtonNewMember.Size = new Size(93, 28);
            ButtonNewMember.TabIndex = 1;
            ButtonNewMember.Text = "YENİ KAYIT";
            ButtonNewMember.UseVisualStyleBackColor = false;
            ButtonNewMember.Click += ButtonNewMember_Click;
            // 
            // DataGridViewMembers
            // 
            DataGridViewMembers.AllowUserToAddRows = false;
            DataGridViewMembers.AllowUserToDeleteRows = false;
            DataGridViewMembers.AllowUserToResizeColumns = false;
            DataGridViewMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewMembers.BackgroundColor = Color.White;
            DataGridViewMembers.BorderStyle = BorderStyle.None;
            DataGridViewMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMembers.Columns.AddRange(new DataGridViewColumn[] { EditColumn, DeleteColumn, PaymentColumn });
            tableLayoutPanel1.SetColumnSpan(DataGridViewMembers, 2);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 206, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewMembers.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewMembers.Dock = DockStyle.Fill;
            DataGridViewMembers.EnableHeadersVisualStyles = false;
            DataGridViewMembers.GridColor = Color.WhiteSmoke;
            DataGridViewMembers.Location = new Point(0, 117);
            DataGridViewMembers.Margin = new Padding(0);
            DataGridViewMembers.MultiSelect = false;
            DataGridViewMembers.Name = "DataGridViewMembers";
            DataGridViewMembers.ReadOnly = true;
            DataGridViewMembers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewMembers.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(227, 216, 126);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGridViewMembers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewMembers.RowTemplate.DividerHeight = 10;
            DataGridViewMembers.RowTemplate.Height = 50;
            DataGridViewMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMembers.Size = new Size(1002, 564);
            DataGridViewMembers.TabIndex = 3;
            DataGridViewMembers.CellContentClick += DataGridViewMembers_CellContentClick;
            // 
            // EditColumn
            // 
            EditColumn.FillWeight = 30F;
            EditColumn.HeaderText = "";
            EditColumn.Image = Properties.Resources.edit_row_24px;
            EditColumn.Name = "EditColumn";
            EditColumn.ReadOnly = true;
            EditColumn.Resizable = DataGridViewTriState.True;
            EditColumn.ToolTipText = "Düzenle";
            // 
            // DeleteColumn
            // 
            DeleteColumn.FillWeight = 30F;
            DeleteColumn.HeaderText = "";
            DeleteColumn.Image = Properties.Resources.waste_24px;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.ToolTipText = "Sil";
            // 
            // PaymentColumn
            // 
            PaymentColumn.HeaderText = "";
            PaymentColumn.Name = "PaymentColumn";
            PaymentColumn.ReadOnly = true;
            PaymentColumn.Resizable = DataGridViewTriState.True;
            PaymentColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            PaymentColumn.Text = "Aidat Ödemeleri";
            PaymentColumn.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(TextBoxSearch, 4, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(ComboBoxFilterBloodGroup, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(ComboBoxFilterCity, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 85);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(996, 29);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Anchor = AnchorStyles.Right;
            TextBoxSearch.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxSearch.Location = new Point(749, 3);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.PlaceholderText = "Akıllı Arama";
            TextBoxSearch.Size = new Size(244, 23);
            TextBoxSearch.TabIndex = 2;
            TextBoxSearch.Text = " ";
            TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 4;
            label2.Text = "Kan Grubuna Göre:";
            // 
            // ComboBoxFilterBloodGroup
            // 
            ComboBoxFilterBloodGroup.Dock = DockStyle.Fill;
            ComboBoxFilterBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFilterBloodGroup.FormattingEnabled = true;
            ComboBoxFilterBloodGroup.Items.AddRange(new object[] { "A Rh(+)", "A Rh(-)", "B Rh(+)", "B Rh(-)", "AB Rh(+)", "AB Rh(-)", "0 Rh(+)", "0 Rh(-)" });
            ComboBoxFilterBloodGroup.Location = new Point(128, 3);
            ComboBoxFilterBloodGroup.Name = "ComboBoxFilterBloodGroup";
            ComboBoxFilterBloodGroup.Size = new Size(251, 23);
            ComboBoxFilterBloodGroup.TabIndex = 5;
            ComboBoxFilterBloodGroup.SelectedIndexChanged += ComboBoxFilterBloodGroup_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(409, 7);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Şehire Göre:";
            // 
            // ComboBoxFilterCity
            // 
            ComboBoxFilterCity.Dock = DockStyle.Fill;
            ComboBoxFilterCity.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFilterCity.FormattingEnabled = true;
            ComboBoxFilterCity.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            ComboBoxFilterCity.Location = new Point(485, 3);
            ComboBoxFilterCity.Margin = new Padding(3, 3, 20, 3);
            ComboBoxFilterCity.Name = "ComboBoxFilterCity";
            ComboBoxFilterCity.Size = new Size(234, 23);
            ComboBoxFilterCity.TabIndex = 5;
            ComboBoxFilterCity.SelectedIndexChanged += ComboBoxFilterCity_SelectedIndexChanged;
            // 
            // FormMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 681);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMembers";
            Padding = new Padding(86, 0, 86, 0);
            Text = "FormMembers";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembers).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button ButtonNewMember;
        private DataGridView DataGridViewMembers;
        private DataGridViewImageColumn EditColumn;
        private DataGridViewImageColumn DeleteColumn;
        private DataGridViewButtonColumn PaymentColumn;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TextBoxSearch;
        private Label label2;
        private ComboBox ComboBoxFilterBloodGroup;
        private Label label3;
        private ComboBox ComboBoxFilterCity;
    }
}
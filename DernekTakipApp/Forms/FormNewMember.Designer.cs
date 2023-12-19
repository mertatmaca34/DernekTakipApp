namespace DernekTakipApp.Forms
{
    partial class FormNewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewMember));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            LabelHeaderText = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            ComboBoxCity = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            ComboBoxBloodGroup = new ComboBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            TextBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            TextBoxTc = new MaskedTextBox();
            label5 = new Label();
            ButtonDues = new Button();
            ButtonSave = new Button();
            label6 = new Label();
            CheckBoxMemberStatement = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelHeaderText, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(ButtonDues, 0, 7);
            tableLayoutPanel1.Controls.Add(ButtonSave, 0, 8);
            tableLayoutPanel1.Controls.Add(label6, 1, 6);
            tableLayoutPanel1.Controls.Add(CheckBoxMemberStatement, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(35);
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.334116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.27792F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.709959F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.27792F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.709959F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.27535963F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7099619F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7048006F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(653, 456);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(38, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 1);
            panel1.TabIndex = 0;
            // 
            // LabelHeaderText
            // 
            LabelHeaderText.Anchor = AnchorStyles.Bottom;
            LabelHeaderText.AutoSize = true;
            LabelHeaderText.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderText.Location = new Point(86, 62);
            LabelHeaderText.Margin = new Padding(3, 0, 3, 10);
            LabelHeaderText.Name = "LabelHeaderText";
            LabelHeaderText.Size = new Size(189, 33);
            LabelHeaderText.TabIndex = 1;
            LabelHeaderText.Text = "Yeni Üye Kaydı";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(ComboBoxCity, 0, 0);
            tableLayoutPanel4.Location = new Point(329, 215);
            tableLayoutPanel4.Margin = new Padding(3, 3, 9, 9);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(273, 35);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // ComboBoxCity
            // 
            ComboBoxCity.Anchor = AnchorStyles.None;
            ComboBoxCity.BackColor = Color.WhiteSmoke;
            ComboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCity.FlatStyle = FlatStyle.Flat;
            ComboBoxCity.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxCity.FormattingEnabled = true;
            ComboBoxCity.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            ComboBoxCity.Location = new Point(3, 4);
            ComboBoxCity.Name = "ComboBoxCity";
            ComboBoxCity.Size = new Size(266, 27);
            ComboBoxCity.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.WhiteSmoke;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(ComboBoxBloodGroup, 0, 0);
            tableLayoutPanel5.Location = new Point(38, 215);
            tableLayoutPanel5.Margin = new Padding(3, 3, 9, 9);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(273, 35);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // ComboBoxBloodGroup
            // 
            ComboBoxBloodGroup.Anchor = AnchorStyles.None;
            ComboBoxBloodGroup.BackColor = Color.WhiteSmoke;
            ComboBoxBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxBloodGroup.FlatStyle = FlatStyle.Flat;
            ComboBoxBloodGroup.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxBloodGroup.FormattingEnabled = true;
            ComboBoxBloodGroup.Items.AddRange(new object[] { "A Rh(+)", "A Rh(-)", "B Rh(+)", "B Rh(-)", "AB Rh(+)", "AB Rh(-)", "0 Rh(+)", "0 Rh(-)" });
            ComboBoxBloodGroup.Location = new Point(3, 4);
            ComboBoxBloodGroup.Name = "ComboBoxBloodGroup";
            ComboBoxBloodGroup.Size = new Size(266, 27);
            ComboBoxBloodGroup.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 196);
            label1.Name = "label1";
            label1.Size = new Size(67, 16);
            label1.TabIndex = 3;
            label1.Text = "Kan Grubu";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(TextBoxName, 0, 0);
            tableLayoutPanel2.Location = new Point(38, 136);
            tableLayoutPanel2.Margin = new Padding(3, 3, 9, 9);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(273, 35);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TextBoxName
            // 
            TextBoxName.Anchor = AnchorStyles.None;
            TextBoxName.BackColor = Color.WhiteSmoke;
            TextBoxName.BorderStyle = BorderStyle.None;
            TextBoxName.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxName.Location = new Point(3, 7);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.PlaceholderText = "Ad soyad";
            TextBoxName.Size = new Size(267, 20);
            TextBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 117);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 3;
            label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(329, 117);
            label3.Name = "label3";
            label3.Size = new Size(41, 16);
            label3.TabIndex = 3;
            label3.Text = "TC NO";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(329, 196);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 3;
            label4.Text = "Şehir";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(TextBoxTc, 0, 0);
            tableLayoutPanel3.Location = new Point(329, 136);
            tableLayoutPanel3.Margin = new Padding(3, 3, 9, 9);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(273, 35);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // TextBoxTc
            // 
            TextBoxTc.Anchor = AnchorStyles.Bottom;
            TextBoxTc.BackColor = Color.WhiteSmoke;
            TextBoxTc.BorderStyle = BorderStyle.None;
            TextBoxTc.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxTc.Location = new Point(3, 12);
            TextBoxTc.Mask = "00000000000";
            TextBoxTc.Name = "TextBoxTc";
            TextBoxTc.RejectInputOnFirstFailure = true;
            TextBoxTc.Size = new Size(267, 20);
            TextBoxTc.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 275);
            label5.Name = "label5";
            label5.Size = new Size(116, 16);
            label5.TabIndex = 3;
            label5.Text = "Aidatlar/Ödemeler";
            // 
            // ButtonDues
            // 
            ButtonDues.Dock = DockStyle.Fill;
            ButtonDues.Enabled = false;
            ButtonDues.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDues.Location = new Point(44, 300);
            ButtonDues.Margin = new Padding(9);
            ButtonDues.Name = "ButtonDues";
            ButtonDues.Size = new Size(273, 35);
            ButtonDues.TabIndex = 4;
            ButtonDues.Text = "Üye Aidat Ödeme Durumu";
            ButtonDues.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.FromArgb(240, 236, 87);
            tableLayoutPanel1.SetColumnSpan(ButtonSave, 2);
            ButtonSave.Dock = DockStyle.Fill;
            ButtonSave.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.Location = new Point(44, 353);
            ButtonSave.Margin = new Padding(9);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(565, 35);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(329, 275);
            label6.Name = "label6";
            label6.Size = new Size(93, 16);
            label6.TabIndex = 3;
            label6.Text = "Üyelik Durumu";
            // 
            // CheckBoxMemberStatement
            // 
            CheckBoxMemberStatement.Anchor = AnchorStyles.Left;
            CheckBoxMemberStatement.AutoSize = true;
            CheckBoxMemberStatement.Checked = true;
            CheckBoxMemberStatement.CheckState = CheckState.Checked;
            CheckBoxMemberStatement.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxMemberStatement.Location = new Point(335, 306);
            CheckBoxMemberStatement.Margin = new Padding(9);
            CheckBoxMemberStatement.Name = "CheckBoxMemberStatement";
            CheckBoxMemberStatement.Size = new Size(135, 23);
            CheckBoxMemberStatement.TabIndex = 5;
            CheckBoxMemberStatement.Text = "Üyelik Aktif Mi?";
            CheckBoxMemberStatement.UseVisualStyleBackColor = true;
            // 
            // FormNewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 456);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormNewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Üye Kaydı";
            Load += FormNewMember_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Button ButtonSave;
        private Label label6;
        public TextBox TextBoxName;
        public ComboBox ComboBoxBloodGroup;
        public MaskedTextBox TextBoxTc;
        public ComboBox ComboBoxCity;
        public CheckBox CheckBoxMemberStatement;
        public Button ButtonDues;
        public Label LabelHeaderText;
    }
}
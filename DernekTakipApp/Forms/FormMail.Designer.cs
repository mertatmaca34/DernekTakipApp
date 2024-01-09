namespace DernekTakipApp.Forms
{
    partial class FormMail
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ButtonSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CheckBoxUseCredentials = new CheckBox();
            CheckBoxUseSSL = new CheckBox();
            TextBoxPassword = new TextBox();
            TextBoxMailAddress = new TextBox();
            TextBoxPort = new TextBox();
            TextBoxHost = new TextBox();
            label8 = new Label();
            TextBoxBody = new TextBox();
            label9 = new Label();
            label10 = new Label();
            CheckBoxDebtInfo = new CheckBox();
            TextBoxSubject = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(86, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1002, 681);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 236, 87);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 107);
            panel1.Margin = new Padding(0, 25, 0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 15);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(246, 33);
            label1.TabIndex = 0;
            label1.Text = "Mail Sunucu Ayarları";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ButtonSave, 0, 10);
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(label3, 0, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(label5, 0, 7);
            tableLayoutPanel2.Controls.Add(label6, 0, 8);
            tableLayoutPanel2.Controls.Add(label7, 0, 9);
            tableLayoutPanel2.Controls.Add(CheckBoxUseCredentials, 1, 9);
            tableLayoutPanel2.Controls.Add(CheckBoxUseSSL, 1, 8);
            tableLayoutPanel2.Controls.Add(TextBoxPassword, 1, 7);
            tableLayoutPanel2.Controls.Add(TextBoxMailAddress, 1, 6);
            tableLayoutPanel2.Controls.Add(TextBoxPort, 1, 5);
            tableLayoutPanel2.Controls.Add(TextBoxHost, 1, 4);
            tableLayoutPanel2.Controls.Add(label8, 0, 2);
            tableLayoutPanel2.Controls.Add(TextBoxBody, 1, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Controls.Add(label10, 0, 1);
            tableLayoutPanel2.Controls.Add(CheckBoxDebtInfo, 1, 1);
            tableLayoutPanel2.Controls.Add(TextBoxSubject, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.28146F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.28146F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2171726F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.277487F));
            tableLayoutPanel2.Size = new Size(996, 553);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.FromArgb(240, 236, 87);
            tableLayoutPanel2.SetColumnSpan(ButtonSave, 2);
            ButtonSave.Dock = DockStyle.Fill;
            ButtonSave.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.Location = new Point(9, 473);
            ButtonSave.Margin = new Padding(9);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(978, 23);
            ButtonSave.TabIndex = 7;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(223, 227);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 0;
            label2.Text = "Host:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 268);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 0;
            label3.Text = "Port:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(195, 309);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 0;
            label4.Text = "Mail Adresi:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(223, 350);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 0;
            label5.Text = "Şifre:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(171, 391);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 0;
            label6.Text = "SSL Kullanılsın mı?";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(75, 432);
            label7.Name = "label7";
            label7.Size = new Size(347, 23);
            label7.TabIndex = 0;
            label7.Text = "Varsayılan Kullanıcı Bilgileri Kullanılsın mı?\r\n";
            // 
            // CheckBoxUseCredentials
            // 
            CheckBoxUseCredentials.Anchor = AnchorStyles.None;
            CheckBoxUseCredentials.AutoSize = true;
            CheckBoxUseCredentials.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxUseCredentials.Location = new Point(739, 436);
            CheckBoxUseCredentials.Name = "CheckBoxUseCredentials";
            CheckBoxUseCredentials.Size = new Size(15, 14);
            CheckBoxUseCredentials.TabIndex = 8;
            CheckBoxUseCredentials.UseVisualStyleBackColor = true;
            // 
            // CheckBoxUseSSL
            // 
            CheckBoxUseSSL.Anchor = AnchorStyles.None;
            CheckBoxUseSSL.AutoSize = true;
            CheckBoxUseSSL.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxUseSSL.Location = new Point(739, 395);
            CheckBoxUseSSL.Name = "CheckBoxUseSSL";
            CheckBoxUseSSL.Size = new Size(15, 14);
            CheckBoxUseSSL.TabIndex = 8;
            CheckBoxUseSSL.UseVisualStyleBackColor = true;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Anchor = AnchorStyles.None;
            TextBoxPassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(597, 346);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PlaceholderText = "example";
            TextBoxPassword.Size = new Size(299, 31);
            TextBoxPassword.TabIndex = 9;
            TextBoxPassword.Text = "mertemir123";
            // 
            // TextBoxMailAddress
            // 
            TextBoxMailAddress.Anchor = AnchorStyles.None;
            TextBoxMailAddress.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxMailAddress.Location = new Point(597, 305);
            TextBoxMailAddress.Name = "TextBoxMailAddress";
            TextBoxMailAddress.PlaceholderText = "example@example.com";
            TextBoxMailAddress.Size = new Size(299, 31);
            TextBoxMailAddress.TabIndex = 9;
            TextBoxMailAddress.Text = "mertemirgorsel@outlook.com";
            // 
            // TextBoxPort
            // 
            TextBoxPort.Anchor = AnchorStyles.None;
            TextBoxPort.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxPort.Location = new Point(597, 264);
            TextBoxPort.Name = "TextBoxPort";
            TextBoxPort.PlaceholderText = "587";
            TextBoxPort.Size = new Size(299, 31);
            TextBoxPort.TabIndex = 9;
            TextBoxPort.Text = "587";
            // 
            // TextBoxHost
            // 
            TextBoxHost.Anchor = AnchorStyles.None;
            TextBoxHost.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxHost.Location = new Point(597, 223);
            TextBoxHost.Name = "TextBoxHost";
            TextBoxHost.PlaceholderText = "smtp-mail.outlook.com";
            TextBoxHost.Size = new Size(299, 31);
            TextBoxHost.TabIndex = 9;
            TextBoxHost.Text = "smtp-mail.outlook.com";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(185, 113);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 0;
            label8.Text = "E-Posta İçeriği:";
            // 
            // TextBoxBody
            // 
            TextBoxBody.Anchor = AnchorStyles.None;
            TextBoxBody.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxBody.Location = new Point(597, 85);
            TextBoxBody.Multiline = true;
            TextBoxBody.Name = "TextBoxBody";
            TextBoxBody.PlaceholderText = "smtp-mail.outlook.com";
            TextBoxBody.Size = new Size(299, 80);
            TextBoxBody.TabIndex = 9;
            TextBoxBody.Text = "Derneğimize ödeme yapmanızı beklemekteyiz.";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(183, 9);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 0;
            label9.Text = "E-Posta Konusu";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(91, 50);
            label10.Name = "label10";
            label10.Size = new Size(316, 23);
            label10.TabIndex = 0;
            label10.Text = "Kullanıcıya Borç Bilgisi Gönderilsin mi?\r\n";
            // 
            // CheckBoxDebtInfo
            // 
            CheckBoxDebtInfo.Anchor = AnchorStyles.None;
            CheckBoxDebtInfo.AutoSize = true;
            CheckBoxDebtInfo.Checked = true;
            CheckBoxDebtInfo.CheckState = CheckState.Checked;
            CheckBoxDebtInfo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxDebtInfo.Location = new Point(739, 54);
            CheckBoxDebtInfo.Name = "CheckBoxDebtInfo";
            CheckBoxDebtInfo.Size = new Size(15, 14);
            CheckBoxDebtInfo.TabIndex = 8;
            CheckBoxDebtInfo.UseVisualStyleBackColor = true;
            // 
            // TextBoxSubject
            // 
            TextBoxSubject.Anchor = AnchorStyles.None;
            TextBoxSubject.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxSubject.Location = new Point(597, 5);
            TextBoxSubject.Name = "TextBoxSubject";
            TextBoxSubject.PlaceholderText = "smtp-mail.outlook.com";
            TextBoxSubject.Size = new Size(299, 31);
            TextBoxSubject.TabIndex = 9;
            TextBoxSubject.Text = "[DERNEK] - Borç Hatırlatması";
            // 
            // FormMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 681);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMail";
            Padding = new Padding(86, 0, 86, 0);
            Text = "FormMail";
            Load += FormMail_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ButtonSave;
        private CheckBox CheckBoxUseCredentials;
        private CheckBox CheckBoxUseSSL;
        private TextBox TextBoxPassword;
        private TextBox TextBoxMailAddress;
        private TextBox TextBoxPort;
        private TextBox TextBoxHost;
        private Label label8;
        private TextBox TextBoxBody;
        private Label label9;
        private Label label10;
        private CheckBox CheckBoxDebtInfo;
        private TextBox TextBoxSubject;
    }
}
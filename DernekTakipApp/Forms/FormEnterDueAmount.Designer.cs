namespace DernekTakipApp.Forms
{
    partial class FormEnterDueAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterDueAmount));
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            TextBoxMonth = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            LabelHeaderText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonSave = new Button();
            TextBoxAmount = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 121);
            label2.Name = "label2";
            label2.Size = new Size(21, 16);
            label2.TabIndex = 3;
            label2.Text = "AY";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(275, 121);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 3;
            label3.Text = "TUTAR";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(TextBoxAmount, 0, 0);
            tableLayoutPanel3.Location = new Point(275, 140);
            tableLayoutPanel3.Margin = new Padding(3, 3, 9, 9);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(225, 33);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // TextBoxMonth
            // 
            TextBoxMonth.Anchor = AnchorStyles.None;
            TextBoxMonth.BackColor = Color.WhiteSmoke;
            TextBoxMonth.BorderStyle = BorderStyle.None;
            TextBoxMonth.Enabled = false;
            TextBoxMonth.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxMonth.Location = new Point(3, 6);
            TextBoxMonth.Name = "TextBoxMonth";
            TextBoxMonth.PlaceholderText = "Ay";
            TextBoxMonth.Size = new Size(219, 20);
            TextBoxMonth.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(TextBoxMonth, 0, 0);
            tableLayoutPanel2.Location = new Point(38, 140);
            tableLayoutPanel2.Margin = new Padding(3, 3, 9, 9);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(225, 33);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(38, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 1);
            panel1.TabIndex = 0;
            // 
            // LabelHeaderText
            // 
            LabelHeaderText.Anchor = AnchorStyles.Bottom;
            LabelHeaderText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LabelHeaderText, 2);
            LabelHeaderText.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderText.Location = new Point(143, 65);
            LabelHeaderText.Margin = new Padding(3, 0, 3, 10);
            LabelHeaderText.Name = "LabelHeaderText";
            LabelHeaderText.Size = new Size(257, 33);
            LabelHeaderText.TabIndex = 1;
            LabelHeaderText.Text = "Aidat Tutarı Düzenle";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ButtonSave, 0, 4);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelHeaderText, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(35);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.6584663F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0464458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3691654F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9259262F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(544, 304);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.FromArgb(240, 236, 87);
            tableLayoutPanel1.SetColumnSpan(ButtonSave, 2);
            ButtonSave.Dock = DockStyle.Fill;
            ButtonSave.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.Location = new Point(44, 201);
            ButtonSave.Margin = new Padding(9);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(456, 36);
            ButtonSave.TabIndex = 7;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            // 
            // TextBoxAmount
            // 
            TextBoxAmount.Anchor = AnchorStyles.None;
            TextBoxAmount.BackColor = Color.WhiteSmoke;
            TextBoxAmount.BorderStyle = BorderStyle.None;
            TextBoxAmount.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxAmount.Location = new Point(3, 6);
            TextBoxAmount.Name = "TextBoxAmount";
            TextBoxAmount.PlaceholderText = "Tutar";
            TextBoxAmount.Size = new Size(219, 20);
            TextBoxAmount.TabIndex = 3;
            // 
            // FormEnterDueAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 304);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEnterDueAmount";
            Text = "Aidat Tutarı Düzenle";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        public TextBox TextBoxMonth;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        public Label LabelHeaderText;
        private Button ButtonSave;
        public TextBox TextBoxAmount;
    }
}
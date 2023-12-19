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
            panel1 = new Panel();
            LabelHeaderText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(38, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 1);
            panel1.TabIndex = 0;
            // 
            // LabelHeaderText
            // 
            LabelHeaderText.Anchor = AnchorStyles.Bottom;
            LabelHeaderText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LabelHeaderText, 2);
            LabelHeaderText.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderText.Location = new Point(167, 270);
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
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelHeaderText, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(35);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.334116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.27792F));
            tableLayoutPanel1.Size = new Size(653, 456);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FormMemberDues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 456);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "FormMemberDues";
            Text = "Üye Aidat Ödeme Durumu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        public Label LabelHeaderText;
    }
}
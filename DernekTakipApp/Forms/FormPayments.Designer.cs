namespace DernekTakipApp.Forms
{
    partial class FormPayments
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
            DataGridViewMembers = new DataGridView();
            EditColumn = new DataGridViewImageColumn();
            DeleteColumn = new DataGridViewImageColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ButtonNewMember = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembers).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            DataGridViewMembers.Columns.AddRange(new DataGridViewColumn[] { EditColumn, DeleteColumn });
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
            DataGridViewMembers.Size = new Size(1002, 544);
            DataGridViewMembers.TabIndex = 3;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonNewMember, 1, 0);
            tableLayoutPanel1.Controls.Add(DataGridViewMembers, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(86, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
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
            label1.Size = new Size(217, 33);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Durumları";
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
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(196, 664);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ara";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 82);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1002, 35);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // FormPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 681);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPayments";
            Padding = new Padding(86, 0, 86, 0);
            Text = "FormPayments";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembers).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewMembers;
        private DataGridViewImageColumn EditColumn;
        private DataGridViewImageColumn DeleteColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button ButtonNewMember;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
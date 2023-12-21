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
            ButtonNewMember = new Button();
            textBox1 = new TextBox();
            DataGridViewMembers = new DataGridView();
            EditColumn = new DataGridViewImageColumn();
            DeleteColumn = new DataGridViewImageColumn();
            PaymentColumn = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembers).BeginInit();
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
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(DataGridViewMembers, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(86, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(697, 88);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ara";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 2;
            // 
            // DataGridViewMembers
            // 
            DataGridViewMembers.AllowUserToAddRows = false;
            DataGridViewMembers.AllowUserToDeleteRows = false;
            DataGridViewMembers.AllowUserToResizeColumns = false;
            DataGridViewMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            DataGridViewMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewMembers.BackgroundColor = Color.White;
            DataGridViewMembers.BorderStyle = BorderStyle.None;
            DataGridViewMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle7.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            DataGridViewMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMembers.Columns.AddRange(new DataGridViewColumn[] { EditColumn, DeleteColumn, PaymentColumn });
            tableLayoutPanel1.SetColumnSpan(DataGridViewMembers, 2);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(187, 206, 168);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DataGridViewMembers.DefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewMembers.Dock = DockStyle.Fill;
            DataGridViewMembers.EnableHeadersVisualStyles = false;
            DataGridViewMembers.GridColor = Color.WhiteSmoke;
            DataGridViewMembers.Location = new Point(0, 117);
            DataGridViewMembers.Margin = new Padding(0);
            DataGridViewMembers.MultiSelect = false;
            DataGridViewMembers.Name = "DataGridViewMembers";
            DataGridViewMembers.ReadOnly = true;
            DataGridViewMembers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataGridViewMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewMembers.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.Padding = new Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(227, 216, 126);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DataGridViewMembers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DataGridViewMembers.RowTemplate.DividerHeight = 10;
            DataGridViewMembers.RowTemplate.Height = 50;
            DataGridViewMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMembers.Size = new Size(1002, 564);
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
            ((System.ComponentModel.ISupportInitialize)DataGridViewMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button ButtonNewMember;
        private TextBox textBox1;
        private DataGridView DataGridViewMembers;
        private DataGridViewImageColumn EditColumn;
        private DataGridViewImageColumn DeleteColumn;
        private DataGridViewButtonColumn PaymentColumn;
    }
}
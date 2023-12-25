﻿namespace DernekTakipApp.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ButtonNewMember = new Button();
            textBox1 = new TextBox();
            DataGridViewMemberDebts = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMemberDebts).BeginInit();
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
            tableLayoutPanel1.Controls.Add(DataGridViewMemberDebts, 0, 2);
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
            label1.Size = new Size(154, 33);
            label1.TabIndex = 0;
            label1.Text = "Üye Borçları";
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
            // DataGridViewMemberDebts
            // 
            DataGridViewMemberDebts.AllowUserToAddRows = false;
            DataGridViewMemberDebts.AllowUserToDeleteRows = false;
            DataGridViewMemberDebts.AllowUserToResizeColumns = false;
            DataGridViewMemberDebts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewMemberDebts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewMemberDebts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewMemberDebts.BackgroundColor = Color.White;
            DataGridViewMemberDebts.BorderStyle = BorderStyle.None;
            DataGridViewMemberDebts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewMemberDebts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 236, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewMemberDebts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewMemberDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(DataGridViewMemberDebts, 2);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 206, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewMemberDebts.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewMemberDebts.Dock = DockStyle.Fill;
            DataGridViewMemberDebts.EnableHeadersVisualStyles = false;
            DataGridViewMemberDebts.GridColor = Color.WhiteSmoke;
            DataGridViewMemberDebts.Location = new Point(0, 117);
            DataGridViewMemberDebts.Margin = new Padding(0);
            DataGridViewMemberDebts.MultiSelect = false;
            DataGridViewMemberDebts.Name = "DataGridViewMemberDebts";
            DataGridViewMemberDebts.ReadOnly = true;
            DataGridViewMemberDebts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewMemberDebts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewMemberDebts.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(227, 216, 126);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGridViewMemberDebts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewMemberDebts.RowTemplate.DividerHeight = 10;
            DataGridViewMemberDebts.RowTemplate.Height = 50;
            DataGridViewMemberDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMemberDebts.Size = new Size(1002, 564);
            DataGridViewMemberDebts.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button ButtonNewMember;
        private TextBox textBox1;
        private DataGridView DataGridViewMemberDebts;
    }
}
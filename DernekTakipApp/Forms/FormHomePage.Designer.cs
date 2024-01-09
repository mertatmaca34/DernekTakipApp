namespace DernekTakipApp.Forms
{
    partial class FormHomePage
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            zedGraphControl3 = new ZedGraph.ZedGraphControl();
            zedGraphControl2 = new ZedGraph.ZedGraphControl();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            zedGraphControl1 = new ZedGraph.ZedGraphControl();
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
            tableLayoutPanel1.TabIndex = 3;
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
            label1.Size = new Size(117, 33);
            label1.TabIndex = 0;
            label1.Text = "Anasayfa";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(zedGraphControl3, 0, 3);
            tableLayoutPanel2.Controls.Add(zedGraphControl2, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(zedGraphControl1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 122);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(1002, 559);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // zedGraphControl3
            // 
            tableLayoutPanel2.SetColumnSpan(zedGraphControl3, 2);
            zedGraphControl3.Dock = DockStyle.Fill;
            zedGraphControl3.Location = new Point(4, 302);
            zedGraphControl3.Margin = new Padding(4, 3, 4, 3);
            zedGraphControl3.Name = "zedGraphControl3";
            zedGraphControl3.ScrollGrace = 0D;
            zedGraphControl3.ScrollMaxX = 0D;
            zedGraphControl3.ScrollMaxY = 0D;
            zedGraphControl3.ScrollMaxY2 = 0D;
            zedGraphControl3.ScrollMinX = 0D;
            zedGraphControl3.ScrollMinY = 0D;
            zedGraphControl3.ScrollMinY2 = 0D;
            zedGraphControl3.Size = new Size(994, 213);
            zedGraphControl3.TabIndex = 3;
            // 
            // zedGraphControl2
            // 
            zedGraphControl2.Dock = DockStyle.Fill;
            zedGraphControl2.Location = new Point(505, 43);
            zedGraphControl2.Margin = new Padding(4, 3, 4, 3);
            zedGraphControl2.Name = "zedGraphControl2";
            zedGraphControl2.ScrollGrace = 0D;
            zedGraphControl2.ScrollMaxX = 0D;
            zedGraphControl2.ScrollMaxY = 0D;
            zedGraphControl2.ScrollMaxY2 = 0D;
            zedGraphControl2.ScrollMinX = 0D;
            zedGraphControl2.ScrollMinY = 0D;
            zedGraphControl2.ScrollMinY2 = 0D;
            zedGraphControl2.Size = new Size(493, 213);
            zedGraphControl2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(248, 23);
            label2.TabIndex = 0;
            label2.Text = "Aidat Gelirlerinin Aylık Grafiği";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(504, 17);
            label3.Name = "label3";
            label3.Size = new Size(247, 23);
            label3.TabIndex = 0;
            label3.Text = "Aidat Gelirlerinin Yıllık Grafiği";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 276);
            label4.Name = "label4";
            label4.Size = new Size(251, 23);
            label4.TabIndex = 0;
            label4.Text = "Şehirlere Göre Üye Dağılımları";
            // 
            // zedGraphControl1
            // 
            zedGraphControl1.Dock = DockStyle.Fill;
            zedGraphControl1.Location = new Point(4, 43);
            zedGraphControl1.Margin = new Padding(4, 3, 4, 3);
            zedGraphControl1.Name = "zedGraphControl1";
            zedGraphControl1.ScrollGrace = 0D;
            zedGraphControl1.ScrollMaxX = 0D;
            zedGraphControl1.ScrollMaxY = 0D;
            zedGraphControl1.ScrollMaxY2 = 0D;
            zedGraphControl1.ScrollMinX = 0D;
            zedGraphControl1.ScrollMinY = 0D;
            zedGraphControl1.ScrollMinY2 = 0D;
            zedGraphControl1.Size = new Size(493, 213);
            zedGraphControl1.TabIndex = 1;
            // 
            // FormHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 681);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHomePage";
            Padding = new Padding(86, 0, 86, 0);
            Text = "FormHomePage";
            Load += FormHomePage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}
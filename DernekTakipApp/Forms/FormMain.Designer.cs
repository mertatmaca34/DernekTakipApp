namespace DernekTakipApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            TableLayoutPanelLeftBar = new TableLayoutPanel();
            ButtonHome = new Button();
            ButtonMail = new Button();
            ButtonPayments = new Button();
            ButtonDues = new Button();
            ButtonMembers = new Button();
            PanelContent = new Panel();
            TableLayoutPanelLeftBar.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelLeftBar
            // 
            TableLayoutPanelLeftBar.BackColor = Color.White;
            TableLayoutPanelLeftBar.ColumnCount = 1;
            TableLayoutPanelLeftBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelLeftBar.Controls.Add(ButtonHome, 0, 0);
            TableLayoutPanelLeftBar.Controls.Add(ButtonMail, 0, 4);
            TableLayoutPanelLeftBar.Controls.Add(ButtonPayments, 0, 3);
            TableLayoutPanelLeftBar.Controls.Add(ButtonDues, 0, 2);
            TableLayoutPanelLeftBar.Controls.Add(ButtonMembers, 0, 1);
            TableLayoutPanelLeftBar.Dock = DockStyle.Left;
            TableLayoutPanelLeftBar.Location = new Point(0, 0);
            TableLayoutPanelLeftBar.Name = "TableLayoutPanelLeftBar";
            TableLayoutPanelLeftBar.RowCount = 8;
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelLeftBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            TableLayoutPanelLeftBar.Size = new Size(90, 681);
            TableLayoutPanelLeftBar.TabIndex = 1;
            // 
            // ButtonHome
            // 
            ButtonHome.Dock = DockStyle.Fill;
            ButtonHome.FlatAppearance.BorderSize = 0;
            ButtonHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            ButtonHome.FlatStyle = FlatStyle.Flat;
            ButtonHome.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonHome.ForeColor = Color.DimGray;
            ButtonHome.Image = Properties.Resources.house_24px;
            ButtonHome.Location = new Point(8, 8);
            ButtonHome.Margin = new Padding(8);
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(74, 68);
            ButtonHome.TabIndex = 5;
            ButtonHome.Text = "Anasayfa";
            ButtonHome.TextAlign = ContentAlignment.BottomCenter;
            ButtonHome.UseVisualStyleBackColor = false;
            ButtonHome.Click += ButtonHome_Click;
            // 
            // ButtonMail
            // 
            ButtonMail.Dock = DockStyle.Fill;
            ButtonMail.FlatAppearance.BorderSize = 0;
            ButtonMail.FlatStyle = FlatStyle.Flat;
            ButtonMail.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMail.ForeColor = Color.DimGray;
            ButtonMail.Image = Properties.Resources.mail_24px;
            ButtonMail.Location = new Point(8, 344);
            ButtonMail.Margin = new Padding(8);
            ButtonMail.Name = "ButtonMail";
            ButtonMail.Size = new Size(74, 68);
            ButtonMail.TabIndex = 4;
            ButtonMail.Text = "Mail";
            ButtonMail.TextAlign = ContentAlignment.BottomCenter;
            ButtonMail.UseVisualStyleBackColor = true;
            ButtonMail.Click += ButtonMail_Click;
            // 
            // ButtonPayments
            // 
            ButtonPayments.Dock = DockStyle.Fill;
            ButtonPayments.FlatAppearance.BorderSize = 0;
            ButtonPayments.FlatStyle = FlatStyle.Flat;
            ButtonPayments.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPayments.ForeColor = Color.DimGray;
            ButtonPayments.Image = Properties.Resources.transaction_24px;
            ButtonPayments.Location = new Point(8, 260);
            ButtonPayments.Margin = new Padding(8);
            ButtonPayments.Name = "ButtonPayments";
            ButtonPayments.Size = new Size(74, 68);
            ButtonPayments.TabIndex = 3;
            ButtonPayments.Text = "Üye Borçları";
            ButtonPayments.TextAlign = ContentAlignment.BottomCenter;
            ButtonPayments.UseVisualStyleBackColor = true;
            ButtonPayments.Click += ButtonPayments_Click;
            // 
            // ButtonDues
            // 
            ButtonDues.Dock = DockStyle.Fill;
            ButtonDues.FlatAppearance.BorderSize = 0;
            ButtonDues.FlatStyle = FlatStyle.Flat;
            ButtonDues.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDues.ForeColor = Color.DimGray;
            ButtonDues.Image = Properties.Resources.stack_of_coins_24px;
            ButtonDues.Location = new Point(8, 176);
            ButtonDues.Margin = new Padding(8);
            ButtonDues.Name = "ButtonDues";
            ButtonDues.Size = new Size(74, 68);
            ButtonDues.TabIndex = 2;
            ButtonDues.Text = "Aidatlar";
            ButtonDues.TextAlign = ContentAlignment.BottomCenter;
            ButtonDues.UseVisualStyleBackColor = true;
            ButtonDues.Click += ButtonDues_Click;
            // 
            // ButtonMembers
            // 
            ButtonMembers.BackColor = Color.FromArgb(230, 230, 230);
            ButtonMembers.Dock = DockStyle.Fill;
            ButtonMembers.FlatAppearance.BorderSize = 0;
            ButtonMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            ButtonMembers.FlatStyle = FlatStyle.Flat;
            ButtonMembers.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMembers.ForeColor = Color.DimGray;
            ButtonMembers.Image = Properties.Resources.management_24px;
            ButtonMembers.Location = new Point(8, 92);
            ButtonMembers.Margin = new Padding(8);
            ButtonMembers.Name = "ButtonMembers";
            ButtonMembers.Size = new Size(74, 68);
            ButtonMembers.TabIndex = 1;
            ButtonMembers.Text = "Üyeler";
            ButtonMembers.TextAlign = ContentAlignment.BottomCenter;
            ButtonMembers.UseVisualStyleBackColor = false;
            ButtonMembers.Click += ButtonMembers_Click;
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(90, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1174, 681);
            PanelContent.TabIndex = 2;
            PanelContent.Paint += PanelContent_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1264, 681);
            Controls.Add(PanelContent);
            Controls.Add(TableLayoutPanelLeftBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dernek Takip Programı";
            Load += FormMain_Load;
            SizeChanged += FormMain_SizeChanged;
            TableLayoutPanelLeftBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelLeftBar;
        private Button ButtonMail;
        private Button ButtonPayments;
        private Button ButtonDues;
        private Button ButtonMembers;
        private Panel PanelContent;
        private Button ButtonHome;
    }
}
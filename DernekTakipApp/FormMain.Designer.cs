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
            TableLayoutPanelLeftBar = new TableLayoutPanel();
            ButtonMailPage = new Button();
            ButtonCalibrationPage = new Button();
            ButtonSimulationPage = new Button();
            ButtonHomePage = new Button();
            PanelContent = new Panel();
            TableLayoutPanelLeftBar.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelLeftBar
            // 
            TableLayoutPanelLeftBar.BackColor = Color.White;
            TableLayoutPanelLeftBar.ColumnCount = 1;
            TableLayoutPanelLeftBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelLeftBar.Controls.Add(ButtonMailPage, 0, 3);
            TableLayoutPanelLeftBar.Controls.Add(ButtonCalibrationPage, 0, 2);
            TableLayoutPanelLeftBar.Controls.Add(ButtonSimulationPage, 0, 1);
            TableLayoutPanelLeftBar.Controls.Add(ButtonHomePage, 0, 0);
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
            // ButtonMailPage
            // 
            ButtonMailPage.Dock = DockStyle.Fill;
            ButtonMailPage.FlatAppearance.BorderSize = 0;
            ButtonMailPage.FlatStyle = FlatStyle.Flat;
            ButtonMailPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMailPage.ForeColor = Color.DimGray;
            ButtonMailPage.Image = Properties.Resources.mail_outlined_24px;
            ButtonMailPage.Location = new Point(8, 260);
            ButtonMailPage.Margin = new Padding(8);
            ButtonMailPage.Name = "ButtonMailPage";
            ButtonMailPage.Size = new Size(74, 68);
            ButtonMailPage.TabIndex = 4;
            ButtonMailPage.Text = "Mail";
            ButtonMailPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonMailPage.UseVisualStyleBackColor = true;
            // 
            // ButtonCalibrationPage
            // 
            ButtonCalibrationPage.Dock = DockStyle.Fill;
            ButtonCalibrationPage.FlatAppearance.BorderSize = 0;
            ButtonCalibrationPage.FlatStyle = FlatStyle.Flat;
            ButtonCalibrationPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCalibrationPage.ForeColor = Color.DimGray;
            ButtonCalibrationPage.Image = Properties.Resources.due_payments_outlined_24px;
            ButtonCalibrationPage.Location = new Point(8, 176);
            ButtonCalibrationPage.Margin = new Padding(8);
            ButtonCalibrationPage.Name = "ButtonCalibrationPage";
            ButtonCalibrationPage.Size = new Size(74, 68);
            ButtonCalibrationPage.TabIndex = 3;
            ButtonCalibrationPage.Text = "Ödenenler";
            ButtonCalibrationPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonCalibrationPage.UseVisualStyleBackColor = true;
            // 
            // ButtonSimulationPage
            // 
            ButtonSimulationPage.Dock = DockStyle.Fill;
            ButtonSimulationPage.FlatAppearance.BorderSize = 0;
            ButtonSimulationPage.FlatStyle = FlatStyle.Flat;
            ButtonSimulationPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSimulationPage.ForeColor = Color.DimGray;
            ButtonSimulationPage.Image = Properties.Resources.dues_24px;
            ButtonSimulationPage.Location = new Point(8, 92);
            ButtonSimulationPage.Margin = new Padding(8);
            ButtonSimulationPage.Name = "ButtonSimulationPage";
            ButtonSimulationPage.Size = new Size(74, 68);
            ButtonSimulationPage.TabIndex = 2;
            ButtonSimulationPage.Text = "Aidatlar";
            ButtonSimulationPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonSimulationPage.UseVisualStyleBackColor = true;
            // 
            // ButtonHomePage
            // 
            ButtonHomePage.BackColor = Color.FromArgb(230, 230, 230);
            ButtonHomePage.Dock = DockStyle.Fill;
            ButtonHomePage.FlatAppearance.BorderSize = 0;
            ButtonHomePage.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            ButtonHomePage.FlatStyle = FlatStyle.Flat;
            ButtonHomePage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomePage.ForeColor = Color.DimGray;
            ButtonHomePage.Image = Properties.Resources.people_24px;
            ButtonHomePage.Location = new Point(8, 8);
            ButtonHomePage.Margin = new Padding(8);
            ButtonHomePage.Name = "ButtonHomePage";
            ButtonHomePage.Size = new Size(74, 68);
            ButtonHomePage.TabIndex = 1;
            ButtonHomePage.Text = "Üyeler";
            ButtonHomePage.TextAlign = ContentAlignment.BottomCenter;
            ButtonHomePage.UseVisualStyleBackColor = false;
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(90, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1174, 681);
            PanelContent.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1264, 681);
            Controls.Add(PanelContent);
            Controls.Add(TableLayoutPanelLeftBar);
            Name = "FormMain";
            Text = "Dernek Takip Programı";
            Load += FormMain_Load;
            TableLayoutPanelLeftBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelLeftBar;
        private Button ButtonMailPage;
        private Button ButtonCalibrationPage;
        private Button ButtonSimulationPage;
        private Button ButtonHomePage;
        private Panel PanelContent;
    }
}
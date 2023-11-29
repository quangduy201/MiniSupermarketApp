namespace BachHoaXanh
{
    partial class WareHouseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            splitContainer1 = new SplitContainer();
            pnlFunction = new Guna.UI2.WinForms.Guna2GradientPanel();
            pnlCenter = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnDetail = new Guna.UI2.WinForms.Guna2CircleButton();
            lbDetail = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cbbSearch = new ComboBox();
            lbRefresh = new Label();
            btnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlFunction.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlFunction);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlCenter);
            splitContainer1.Size = new Size(1053, 820);
            splitContainer1.SplitterDistance = 103;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 0;
            // 
            // pnlFunction
            // 
            pnlFunction.BackColor = Color.White;
            pnlFunction.BorderRadius = 20;
            pnlFunction.Controls.Add(lbRefresh);
            pnlFunction.Controls.Add(txtSearch);
            pnlFunction.Controls.Add(btnRefresh);
            pnlFunction.Controls.Add(cbbSearch);
            pnlFunction.Controls.Add(lbDetail);
            pnlFunction.Controls.Add(btnDetail);
            pnlFunction.CustomizableEdges = customizableEdges13;
            pnlFunction.Dock = DockStyle.Fill;
            pnlFunction.FillColor = Color.FromArgb(215, 215, 215);
            pnlFunction.FillColor2 = Color.FromArgb(215, 215, 215);
            pnlFunction.Location = new Point(0, 0);
            pnlFunction.Name = "pnlFunction";
            pnlFunction.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlFunction.Size = new Size(1053, 103);
            pnlFunction.TabIndex = 0;
            // 
            // pnlCenter
            // 
            pnlCenter.BackColor = Color.White;
            pnlCenter.BorderRadius = 20;
            pnlCenter.CustomizableEdges = customizableEdges15;
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.FillColor = Color.FromArgb(215, 215, 215);
            pnlCenter.FillColor2 = Color.FromArgb(215, 215, 215);
            pnlCenter.Location = new Point(0, 0);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlCenter.Size = new Size(1053, 709);
            pnlCenter.TabIndex = 0;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.FromArgb(215, 215, 215);
            btnDetail.DisabledState.BorderColor = Color.DarkGray;
            btnDetail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDetail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDetail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDetail.FillColor = Color.White;
            btnDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.Black;
            btnDetail.Image = Properties.Resources.Detail;
            btnDetail.ImageSize = new Size(60, 60);
            btnDetail.Location = new Point(37, 22);
            btnDetail.Name = "btnDetail";
            btnDetail.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDetail.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDetail.Size = new Size(51, 50);
            btnDetail.TabIndex = 0;
            // 
            // lbDetail
            // 
            lbDetail.AutoSize = true;
            lbDetail.BackColor = Color.FromArgb(215, 215, 215);
            lbDetail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetail.Location = new Point(33, 75);
            lbDetail.Name = "lbDetail";
            lbDetail.Size = new Size(59, 20);
            lbDetail.TabIndex = 0;
            lbDetail.Text = "Chi tiết";
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(674, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Black;
            txtSearch.PlaceholderText = "Nhập nội dung tìm kiếm";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(250, 28);
            txtSearch.TabIndex = 2;
            // 
            // cbbSearch
            // 
            cbbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Location = new Point(551, 41);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(117, 28);
            cbbSearch.TabIndex = 1;
            cbbSearch.Text = "Bộ lọc";
            // 
            // lbRefresh
            // 
            lbRefresh.AutoSize = true;
            lbRefresh.BackColor = Color.FromArgb(215, 215, 215);
            lbRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbRefresh.Location = new Point(949, 75);
            lbRefresh.Name = "lbRefresh";
            lbRefresh.Size = new Size(70, 20);
            lbRefresh.TabIndex = 1;
            lbRefresh.Text = "Làm mới";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(215, 215, 215);
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.White;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Image = Properties.Resources.Refresh;
            btnRefresh.ImageSize = new Size(60, 60);
            btnRefresh.Location = new Point(958, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnRefresh.Size = new Size(51, 50);
            btnRefresh.TabIndex = 2;
            // 
            // WareHouseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "WareHouseControl";
            Size = new Size(1053, 820);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlFunction.ResumeLayout(false);
            pnlFunction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlFunction;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCenter;
        private Label lbDetail;
        private Guna.UI2.WinForms.Guna2CircleButton btnDetail;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Label lbRefresh;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefresh;
        private ComboBox cbbSearch;
    }
}

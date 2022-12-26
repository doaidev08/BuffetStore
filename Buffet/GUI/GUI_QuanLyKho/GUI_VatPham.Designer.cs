namespace Buffet.GUI.GUI_QuanLyKho
{
    partial class GUI_VatPham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_VatPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbFoodList = new Bunifu.UI.WinForms.BunifuLabel();
            this.tableVatPham = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.selectLoaiVatPham = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txbTenVatPham = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelVatPham = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txbDvTinh = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableVatPham)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoLuong)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFoodList
            // 
            this.lbFoodList.AllowParentOverrides = false;
            this.lbFoodList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFoodList.AutoEllipsis = false;
            this.lbFoodList.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFoodList.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbFoodList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbFoodList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFoodList.Location = new System.Drawing.Point(348, 16);
            this.lbFoodList.Name = "lbFoodList";
            this.lbFoodList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFoodList.Size = new System.Drawing.Size(155, 21);
            this.lbFoodList.TabIndex = 8;
            this.lbFoodList.Text = "Danh sách vật phẩm";
            this.lbFoodList.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbFoodList.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tableVatPham
            // 
            this.tableVatPham.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.tableVatPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableVatPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableVatPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableVatPham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableVatPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableVatPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableVatPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableVatPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableVatPham.ColumnHeadersHeight = 40;
            this.tableVatPham.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableVatPham.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableVatPham.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableVatPham.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableVatPham.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableVatPham.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableVatPham.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableVatPham.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableVatPham.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableVatPham.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableVatPham.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tableVatPham.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tableVatPham.CurrentTheme.Name = null;
            this.tableVatPham.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableVatPham.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableVatPham.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableVatPham.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableVatPham.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableVatPham.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableVatPham.EnableHeadersVisualStyles = false;
            this.tableVatPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableVatPham.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableVatPham.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableVatPham.HeaderForeColor = System.Drawing.Color.White;
            this.tableVatPham.Location = new System.Drawing.Point(12, 55);
            this.tableVatPham.Name = "tableVatPham";
            this.tableVatPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableVatPham.RowHeadersVisible = false;
            this.tableVatPham.RowTemplate.Height = 40;
            this.tableVatPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVatPham.Size = new System.Drawing.Size(477, 373);
            this.tableVatPham.TabIndex = 7;
            this.tableVatPham.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tableVatPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableVatPham_CellClick);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MessageTopMargin = 0;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txbDvTinh);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.txbSoLuong);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Controls.Add(this.selectLoaiVatPham);
            this.bunifuPanel1.Controls.Add(this.txbTenVatPham);
            this.bunifuPanel1.Controls.Add(this.labelCount);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel1.Controls.Add(this.labelVatPham);
            this.bunifuPanel1.Location = new System.Drawing.Point(495, 55);
            this.bunifuPanel1.MaximumSize = new System.Drawing.Size(312, 400);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(298, 383);
            this.bunifuPanel1.TabIndex = 10;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(23, 279);
            this.txbSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(120, 20);
            this.txbSoLuong.TabIndex = 5;
            this.txbSoLuong.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnAdd);
            this.bunifuPanel2.Controls.Add(this.btnDelete);
            this.bunifuPanel2.Controls.Add(this.btnUpdate);
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 325);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(292, 48);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.IndianRed;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(32, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.DeepPink;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.Red;
            this.btnDelete.IdleForecolor = System.Drawing.Color.DarkGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(218, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.IndianRed;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Sửa";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.Gold;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(123, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 40);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // selectLoaiVatPham
            // 
            this.selectLoaiVatPham.BackColor = System.Drawing.Color.Transparent;
            this.selectLoaiVatPham.BackgroundColor = System.Drawing.Color.White;
            this.selectLoaiVatPham.BorderColor = System.Drawing.Color.OrangeRed;
            this.selectLoaiVatPham.BorderRadius = 1;
            this.selectLoaiVatPham.Color = System.Drawing.Color.OrangeRed;
            this.selectLoaiVatPham.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectLoaiVatPham.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectLoaiVatPham.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.selectLoaiVatPham.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectLoaiVatPham.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectLoaiVatPham.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.selectLoaiVatPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectLoaiVatPham.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.selectLoaiVatPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLoaiVatPham.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectLoaiVatPham.FillDropDown = true;
            this.selectLoaiVatPham.FillIndicator = false;
            this.selectLoaiVatPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLoaiVatPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectLoaiVatPham.ForeColor = System.Drawing.Color.Black;
            this.selectLoaiVatPham.FormattingEnabled = true;
            this.selectLoaiVatPham.Icon = null;
            this.selectLoaiVatPham.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectLoaiVatPham.IndicatorColor = System.Drawing.Color.DarkGray;
            this.selectLoaiVatPham.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectLoaiVatPham.IndicatorThickness = 2;
            this.selectLoaiVatPham.IsDropdownOpened = false;
            this.selectLoaiVatPham.ItemBackColor = System.Drawing.Color.White;
            this.selectLoaiVatPham.ItemBorderColor = System.Drawing.Color.White;
            this.selectLoaiVatPham.ItemForeColor = System.Drawing.Color.Black;
            this.selectLoaiVatPham.ItemHeight = 26;
            this.selectLoaiVatPham.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.selectLoaiVatPham.ItemHighLightForeColor = System.Drawing.Color.White;
            this.selectLoaiVatPham.ItemTopMargin = 3;
            this.selectLoaiVatPham.Location = new System.Drawing.Point(23, 137);
            this.selectLoaiVatPham.Name = "selectLoaiVatPham";
            this.selectLoaiVatPham.Size = new System.Drawing.Size(260, 32);
            this.selectLoaiVatPham.TabIndex = 4;
            this.selectLoaiVatPham.Text = null;
            this.selectLoaiVatPham.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectLoaiVatPham.TextLeftMargin = 5;
            // 
            // txbTenVatPham
            // 
            this.txbTenVatPham.AcceptsReturn = false;
            this.txbTenVatPham.AcceptsTab = false;
            this.txbTenVatPham.AnimationSpeed = 200;
            this.txbTenVatPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbTenVatPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbTenVatPham.AutoSizeHeight = true;
            this.txbTenVatPham.BackColor = System.Drawing.Color.White;
            this.txbTenVatPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbTenVatPham.BackgroundImage")));
            this.txbTenVatPham.BorderColorActive = System.Drawing.Color.Indigo;
            this.txbTenVatPham.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbTenVatPham.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbTenVatPham.BorderColorIdle = System.Drawing.Color.Coral;
            this.txbTenVatPham.BorderRadius = 1;
            this.txbTenVatPham.BorderThickness = 1;
            this.txbTenVatPham.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbTenVatPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenVatPham.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbTenVatPham.DefaultText = "";
            this.txbTenVatPham.FillColor = System.Drawing.Color.White;
            this.txbTenVatPham.HideSelection = true;
            this.txbTenVatPham.IconLeft = null;
            this.txbTenVatPham.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenVatPham.IconPadding = 10;
            this.txbTenVatPham.IconRight = null;
            this.txbTenVatPham.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenVatPham.Lines = new string[0];
            this.txbTenVatPham.Location = new System.Drawing.Point(23, 59);
            this.txbTenVatPham.MaxLength = 32767;
            this.txbTenVatPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbTenVatPham.Modified = false;
            this.txbTenVatPham.Multiline = false;
            this.txbTenVatPham.Name = "txbTenVatPham";
            stateProperties21.BorderColor = System.Drawing.Color.Indigo;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTenVatPham.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbTenVatPham.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTenVatPham.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Coral;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTenVatPham.OnIdleState = stateProperties24;
            this.txbTenVatPham.Padding = new System.Windows.Forms.Padding(3);
            this.txbTenVatPham.PasswordChar = '\0';
            this.txbTenVatPham.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbTenVatPham.PlaceholderText = "Mời nhập tên vật phẩm";
            this.txbTenVatPham.ReadOnly = false;
            this.txbTenVatPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTenVatPham.SelectedText = "";
            this.txbTenVatPham.SelectionLength = 0;
            this.txbTenVatPham.SelectionStart = 0;
            this.txbTenVatPham.ShortcutsEnabled = true;
            this.txbTenVatPham.Size = new System.Drawing.Size(260, 39);
            this.txbTenVatPham.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbTenVatPham.TabIndex = 3;
            this.txbTenVatPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTenVatPham.TextMarginBottom = 0;
            this.txbTenVatPham.TextMarginLeft = 3;
            this.txbTenVatPham.TextMarginTop = 1;
            this.txbTenVatPham.TextPlaceholder = "Mời nhập tên vật phẩm";
            this.txbTenVatPham.UseSystemPasswordChar = false;
            this.txbTenVatPham.WordWrap = true;
            // 
            // labelCount
            // 
            this.labelCount.AllowParentOverrides = false;
            this.labelCount.AutoEllipsis = false;
            this.labelCount.CursorType = null;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCount.Location = new System.Drawing.Point(23, 252);
            this.labelCount.Name = "labelCount";
            this.labelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCount.Size = new System.Drawing.Size(47, 15);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Số lượng";
            this.labelCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(23, 110);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(75, 15);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Loại vật phẩm";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelVatPham
            // 
            this.labelVatPham.AllowParentOverrides = false;
            this.labelVatPham.AutoEllipsis = false;
            this.labelVatPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelVatPham.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelVatPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelVatPham.Location = new System.Drawing.Point(23, 32);
            this.labelVatPham.Name = "labelVatPham";
            this.labelVatPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVatPham.Size = new System.Drawing.Size(75, 15);
            this.labelVatPham.TabIndex = 0;
            this.labelVatPham.Text = "Tên vật phẩm:";
            this.labelVatPham.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelVatPham.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(23, 181);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(58, 15);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Đơn vị tính";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txbDvTinh
            // 
            this.txbDvTinh.AcceptsReturn = false;
            this.txbDvTinh.AcceptsTab = false;
            this.txbDvTinh.AnimationSpeed = 200;
            this.txbDvTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbDvTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbDvTinh.AutoSizeHeight = true;
            this.txbDvTinh.BackColor = System.Drawing.Color.White;
            this.txbDvTinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbDvTinh.BackgroundImage")));
            this.txbDvTinh.BorderColorActive = System.Drawing.Color.Indigo;
            this.txbDvTinh.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbDvTinh.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbDvTinh.BorderColorIdle = System.Drawing.Color.Coral;
            this.txbDvTinh.BorderRadius = 1;
            this.txbDvTinh.BorderThickness = 1;
            this.txbDvTinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDvTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDvTinh.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbDvTinh.DefaultText = "";
            this.txbDvTinh.FillColor = System.Drawing.Color.White;
            this.txbDvTinh.HideSelection = true;
            this.txbDvTinh.IconLeft = null;
            this.txbDvTinh.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDvTinh.IconPadding = 10;
            this.txbDvTinh.IconRight = null;
            this.txbDvTinh.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDvTinh.Lines = new string[0];
            this.txbDvTinh.Location = new System.Drawing.Point(23, 202);
            this.txbDvTinh.MaxLength = 32767;
            this.txbDvTinh.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbDvTinh.Modified = false;
            this.txbDvTinh.Multiline = false;
            this.txbDvTinh.Name = "txbDvTinh";
            stateProperties17.BorderColor = System.Drawing.Color.Indigo;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbDvTinh.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbDvTinh.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbDvTinh.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Coral;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbDvTinh.OnIdleState = stateProperties20;
            this.txbDvTinh.Padding = new System.Windows.Forms.Padding(3);
            this.txbDvTinh.PasswordChar = '\0';
            this.txbDvTinh.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbDvTinh.PlaceholderText = "Mời nhập đơn vị tính";
            this.txbDvTinh.ReadOnly = false;
            this.txbDvTinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDvTinh.SelectedText = "";
            this.txbDvTinh.SelectionLength = 0;
            this.txbDvTinh.SelectionStart = 0;
            this.txbDvTinh.ShortcutsEnabled = true;
            this.txbDvTinh.Size = new System.Drawing.Size(260, 39);
            this.txbDvTinh.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbDvTinh.TabIndex = 7;
            this.txbDvTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbDvTinh.TextMarginBottom = 0;
            this.txbDvTinh.TextMarginLeft = 3;
            this.txbDvTinh.TextMarginTop = 1;
            this.txbDvTinh.TextPlaceholder = "Mời nhập đơn vị tính";
            this.txbDvTinh.UseSystemPasswordChar = false;
            this.txbDvTinh.WordWrap = true;
            // 
            // GUI_VatPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFoodList);
            this.Controls.Add(this.tableVatPham);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "GUI_VatPham";
            this.Text = "GUI_VatPham";
            ((System.ComponentModel.ISupportInitialize)(this.tableVatPham)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoLuong)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lbFoodList;
        private Bunifu.UI.WinForms.BunifuDataGridView tableVatPham;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.NumericUpDown txbSoLuong;
        private Bunifu.UI.WinForms.BunifuDropdown selectLoaiVatPham;
        private Bunifu.UI.WinForms.BunifuTextBox txbTenVatPham;
        private Bunifu.UI.WinForms.BunifuLabel labelCount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel labelVatPham;
        private Bunifu.UI.WinForms.BunifuTextBox txbDvTinh;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
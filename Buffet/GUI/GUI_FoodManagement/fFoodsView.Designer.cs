namespace Buffet.GUI.GUI_FoodManagement
{
    partial class fFoodsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFoodsView));
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tableMainDish = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lbFoodList = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txbFoodCount = new System.Windows.Forms.NumericUpDown();
            this.selectFoodCate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txbFoodName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelFoodName = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddFood = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tableMainDish)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMainDish
            // 
            this.tableMainDish.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.tableMainDish.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableMainDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMainDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableMainDish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableMainDish.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableMainDish.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableMainDish.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableMainDish.ColumnHeadersHeight = 40;
            this.tableMainDish.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableMainDish.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableMainDish.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableMainDish.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableMainDish.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableMainDish.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableMainDish.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableMainDish.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableMainDish.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableMainDish.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableMainDish.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tableMainDish.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tableMainDish.CurrentTheme.Name = null;
            this.tableMainDish.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableMainDish.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableMainDish.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableMainDish.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableMainDish.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableMainDish.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableMainDish.EnableHeadersVisualStyles = false;
            this.tableMainDish.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableMainDish.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableMainDish.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableMainDish.HeaderForeColor = System.Drawing.Color.White;
            this.tableMainDish.Location = new System.Drawing.Point(42, 51);
            this.tableMainDish.Name = "tableMainDish";
            this.tableMainDish.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableMainDish.RowHeadersVisible = false;
            this.tableMainDish.RowTemplate.Height = 40;
            this.tableMainDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableMainDish.Size = new System.Drawing.Size(478, 373);
            this.tableMainDish.TabIndex = 0;
            this.tableMainDish.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tableMainDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMainDish_CellClick);
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
            this.lbFoodList.Location = new System.Drawing.Point(379, 12);
            this.lbFoodList.Name = "lbFoodList";
            this.lbFoodList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFoodList.Size = new System.Drawing.Size(141, 21);
            this.lbFoodList.TabIndex = 3;
            this.lbFoodList.Text = "Danh sách món ăn";
            this.lbFoodList.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbFoodList.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.AnimationSpeed = 200;
            this.bunifuFormCaptionButton1.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.bunifuFormCaptionButton1.BackHoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BackPressedColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.bunifuFormCaptionButton1.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.bunifuFormCaptionButton1.BorderRadius = 1;
            this.bunifuFormCaptionButton1.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton1.BorderThickness = 1;
            this.bunifuFormCaptionButton1.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Minimize;
            this.bunifuFormCaptionButton1.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton1.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges2;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.Gainsboro;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(820, 12);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = true;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(24, 21);
            this.bunifuFormCaptionButton1.TabIndex = 4;
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
            this.bunifuPanel2.Controls.Add(this.btnAddFood);
            this.bunifuPanel2.Controls.Add(this.btnDelete);
            this.bunifuPanel2.Controls.Add(this.btnUpdate);
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 272);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(292, 48);
            this.bunifuPanel2.TabIndex = 5;
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
            this.bunifuPanel1.Controls.Add(this.txbFoodCount);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Controls.Add(this.selectFoodCate);
            this.bunifuPanel1.Controls.Add(this.txbFoodName);
            this.bunifuPanel1.Controls.Add(this.labelCount);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel1.Controls.Add(this.labelFoodName);
            this.bunifuPanel1.Location = new System.Drawing.Point(531, 51);
            this.bunifuPanel1.MaximumSize = new System.Drawing.Size(312, 323);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(298, 323);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // txbFoodCount
            // 
            this.txbFoodCount.Location = new System.Drawing.Point(23, 218);
            this.txbFoodCount.Name = "txbFoodCount";
            this.txbFoodCount.Size = new System.Drawing.Size(120, 20);
            this.txbFoodCount.TabIndex = 5;
            // 
            // selectFoodCate
            // 
            this.selectFoodCate.BackColor = System.Drawing.Color.Transparent;
            this.selectFoodCate.BackgroundColor = System.Drawing.Color.White;
            this.selectFoodCate.BorderColor = System.Drawing.Color.OrangeRed;
            this.selectFoodCate.BorderRadius = 1;
            this.selectFoodCate.Color = System.Drawing.Color.OrangeRed;
            this.selectFoodCate.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectFoodCate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectFoodCate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.selectFoodCate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectFoodCate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectFoodCate.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.selectFoodCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectFoodCate.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.selectFoodCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFoodCate.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectFoodCate.FillDropDown = true;
            this.selectFoodCate.FillIndicator = false;
            this.selectFoodCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFoodCate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectFoodCate.ForeColor = System.Drawing.Color.Black;
            this.selectFoodCate.FormattingEnabled = true;
            this.selectFoodCate.Icon = null;
            this.selectFoodCate.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectFoodCate.IndicatorColor = System.Drawing.Color.DarkGray;
            this.selectFoodCate.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectFoodCate.IndicatorThickness = 2;
            this.selectFoodCate.IsDropdownOpened = false;
            this.selectFoodCate.ItemBackColor = System.Drawing.Color.White;
            this.selectFoodCate.ItemBorderColor = System.Drawing.Color.White;
            this.selectFoodCate.ItemForeColor = System.Drawing.Color.Black;
            this.selectFoodCate.ItemHeight = 26;
            this.selectFoodCate.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.selectFoodCate.ItemHighLightForeColor = System.Drawing.Color.White;
            this.selectFoodCate.ItemTopMargin = 3;
            this.selectFoodCate.Location = new System.Drawing.Point(23, 143);
            this.selectFoodCate.Name = "selectFoodCate";
            this.selectFoodCate.Size = new System.Drawing.Size(260, 32);
            this.selectFoodCate.TabIndex = 4;
            this.selectFoodCate.Text = null;
            this.selectFoodCate.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectFoodCate.TextLeftMargin = 5;
            // 
            // txbFoodName
            // 
            this.txbFoodName.AcceptsReturn = false;
            this.txbFoodName.AcceptsTab = false;
            this.txbFoodName.AnimationSpeed = 200;
            this.txbFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbFoodName.AutoSizeHeight = true;
            this.txbFoodName.BackColor = System.Drawing.Color.White;
            this.txbFoodName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbFoodName.BackgroundImage")));
            this.txbFoodName.BorderColorActive = System.Drawing.Color.Indigo;
            this.txbFoodName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbFoodName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbFoodName.BorderColorIdle = System.Drawing.Color.Coral;
            this.txbFoodName.BorderRadius = 1;
            this.txbFoodName.BorderThickness = 1;
            this.txbFoodName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFoodName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbFoodName.DefaultText = "";
            this.txbFoodName.FillColor = System.Drawing.Color.White;
            this.txbFoodName.HideSelection = true;
            this.txbFoodName.IconLeft = null;
            this.txbFoodName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFoodName.IconPadding = 10;
            this.txbFoodName.IconRight = null;
            this.txbFoodName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFoodName.Lines = new string[0];
            this.txbFoodName.Location = new System.Drawing.Point(23, 61);
            this.txbFoodName.MaxLength = 32767;
            this.txbFoodName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbFoodName.Modified = false;
            this.txbFoodName.Multiline = false;
            this.txbFoodName.Name = "txbFoodName";
            stateProperties5.BorderColor = System.Drawing.Color.Indigo;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbFoodName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbFoodName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbFoodName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Coral;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbFoodName.OnIdleState = stateProperties8;
            this.txbFoodName.Padding = new System.Windows.Forms.Padding(3);
            this.txbFoodName.PasswordChar = '\0';
            this.txbFoodName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbFoodName.PlaceholderText = "Mời nhập tên món ăn";
            this.txbFoodName.ReadOnly = false;
            this.txbFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFoodName.SelectedText = "";
            this.txbFoodName.SelectionLength = 0;
            this.txbFoodName.SelectionStart = 0;
            this.txbFoodName.ShortcutsEnabled = true;
            this.txbFoodName.Size = new System.Drawing.Size(260, 39);
            this.txbFoodName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txbFoodName.TabIndex = 3;
            this.txbFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbFoodName.TextMarginBottom = 0;
            this.txbFoodName.TextMarginLeft = 3;
            this.txbFoodName.TextMarginTop = 1;
            this.txbFoodName.TextPlaceholder = "Mời nhập tên món ăn";
            this.txbFoodName.UseSystemPasswordChar = false;
            this.txbFoodName.WordWrap = true;
            // 
            // labelCount
            // 
            this.labelCount.AllowParentOverrides = false;
            this.labelCount.AutoEllipsis = false;
            this.labelCount.CursorType = null;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCount.Location = new System.Drawing.Point(23, 189);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(23, 114);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(66, 15);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Loại món ăn";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelFoodName
            // 
            this.labelFoodName.AllowParentOverrides = false;
            this.labelFoodName.AutoEllipsis = false;
            this.labelFoodName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFoodName.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelFoodName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFoodName.Location = new System.Drawing.Point(23, 32);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFoodName.Size = new System.Drawing.Size(66, 15);
            this.labelFoodName.TabIndex = 0;
            this.labelFoodName.Text = "Tên món ăn:";
            this.labelFoodName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelFoodName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddFood
            // 
            this.btnAddFood.ActiveBorderThickness = 1;
            this.btnAddFood.ActiveCornerRadius = 20;
            this.btnAddFood.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.ActiveForecolor = System.Drawing.Color.IndianRed;
            this.btnAddFood.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.ButtonText = "Thêm";
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.IdleBorderThickness = 1;
            this.btnAddFood.IdleCornerRadius = 20;
            this.btnAddFood.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAddFood.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.Location = new System.Drawing.Point(32, 3);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(66, 40);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
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
            // fFoodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuFormCaptionButton1);
            this.Controls.Add(this.lbFoodList);
            this.Controls.Add(this.tableMainDish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFoodsView";
            this.Text = "Danh sách món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.tableMainDish)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView tableMainDish;
        private Bunifu.UI.WinForms.BunifuLabel lbFoodList;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.NumericUpDown txbFoodCount;
        private Bunifu.UI.WinForms.BunifuDropdown selectFoodCate;
        private Bunifu.UI.WinForms.BunifuTextBox txbFoodName;
        private Bunifu.UI.WinForms.BunifuLabel labelCount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel labelFoodName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddFood;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
    }
}
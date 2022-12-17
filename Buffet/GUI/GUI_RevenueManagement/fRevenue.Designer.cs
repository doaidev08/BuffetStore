namespace Buffet.GUI.GUI_RevenueManagement
{
    partial class fRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRevenue));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbRevenueName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbRevenueSummary = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbCreatedBy = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbCreatedAt = new Bunifu.UI.WinForms.BunifuLabel();
            this.dateEndPick = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nmrRevenueSum = new System.Windows.Forms.NumericUpDown();
            this.createdAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dateStartPick = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dateEnd = new Bunifu.UI.WinForms.BunifuLabel();
            this.dateStart = new Bunifu.UI.WinForms.BunifuLabel();
            this.txbRevenueName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbCreator = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrRevenueSum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRevenueName
            // 
            this.lbRevenueName.AllowParentOverrides = false;
            this.lbRevenueName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRevenueName.AutoEllipsis = false;
            this.lbRevenueName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRevenueName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbRevenueName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbRevenueName.Location = new System.Drawing.Point(23, 65);
            this.lbRevenueName.Name = "lbRevenueName";
            this.lbRevenueName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRevenueName.Size = new System.Drawing.Size(80, 15);
            this.lbRevenueName.TabIndex = 0;
            this.lbRevenueName.Text = "Tên doanh thu:";
            this.lbRevenueName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbRevenueName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbRevenueSummary
            // 
            this.lbRevenueSummary.AllowParentOverrides = false;
            this.lbRevenueSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRevenueSummary.AutoEllipsis = false;
            this.lbRevenueSummary.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRevenueSummary.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbRevenueSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbRevenueSummary.Location = new System.Drawing.Point(23, 140);
            this.lbRevenueSummary.Name = "lbRevenueSummary";
            this.lbRevenueSummary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRevenueSummary.Size = new System.Drawing.Size(88, 15);
            this.lbRevenueSummary.TabIndex = 1;
            this.lbRevenueSummary.Text = "Tổng doanh thu:";
            this.lbRevenueSummary.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbRevenueSummary.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AllowParentOverrides = false;
            this.lbCreatedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCreatedBy.AutoEllipsis = false;
            this.lbCreatedBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCreatedBy.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCreatedBy.Location = new System.Drawing.Point(23, 214);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCreatedBy.Size = new System.Drawing.Size(56, 15);
            this.lbCreatedBy.TabIndex = 2;
            this.lbCreatedBy.Text = "Người tạo:";
            this.lbCreatedBy.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbCreatedBy.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbCreatedAt
            // 
            this.lbCreatedAt.AllowParentOverrides = false;
            this.lbCreatedAt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCreatedAt.AutoEllipsis = false;
            this.lbCreatedAt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCreatedAt.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbCreatedAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCreatedAt.Location = new System.Drawing.Point(23, 287);
            this.lbCreatedAt.Name = "lbCreatedAt";
            this.lbCreatedAt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCreatedAt.Size = new System.Drawing.Size(53, 15);
            this.lbCreatedAt.TabIndex = 3;
            this.lbCreatedAt.Text = "Ngày Tạo:";
            this.lbCreatedAt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbCreatedAt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dateEndPick
            // 
            this.dateEndPick.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateEndPick.BackColor = System.Drawing.Color.Transparent;
            this.dateEndPick.BorderColor = System.Drawing.Color.Silver;
            this.dateEndPick.BorderRadius = 1;
            this.dateEndPick.Color = System.Drawing.Color.Silver;
            this.dateEndPick.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateEndPick.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateEndPick.DisabledColor = System.Drawing.Color.Gray;
            this.dateEndPick.DisplayWeekNumbers = false;
            this.dateEndPick.DPHeight = 0;
            this.dateEndPick.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateEndPick.FillDatePicker = false;
            this.dateEndPick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateEndPick.ForeColor = System.Drawing.Color.Black;
            this.dateEndPick.Icon = ((System.Drawing.Image)(resources.GetObject("dateEndPick.Icon")));
            this.dateEndPick.IconColor = System.Drawing.Color.Gray;
            this.dateEndPick.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateEndPick.LeftTextMargin = 5;
            this.dateEndPick.Location = new System.Drawing.Point(554, 133);
            this.dateEndPick.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateEndPick.Name = "dateEndPick";
            this.dateEndPick.Size = new System.Drawing.Size(220, 32);
            this.dateEndPick.TabIndex = 4;
            this.dateEndPick.ValueChanged += new System.EventHandler(this.dateEndPick_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Thêm doanh thu";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges2;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAdd.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeft = null;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRight = null;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAdd.IdleBorderRadius = 0;
            this.btnAdd.IdleBorderThickness = 0;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(587, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 1;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.BorderRadius = 1;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnIdleState.BorderRadius = 1;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.BorderRadius = 1;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(150, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmrRevenueSum
            // 
            this.nmrRevenueSum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrRevenueSum.Location = new System.Drawing.Point(124, 135);
            this.nmrRevenueSum.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nmrRevenueSum.MaximumSize = new System.Drawing.Size(270, 0);
            this.nmrRevenueSum.Name = "nmrRevenueSum";
            this.nmrRevenueSum.Size = new System.Drawing.Size(260, 20);
            this.nmrRevenueSum.TabIndex = 8;
            // 
            // createdAt
            // 
            this.createdAt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createdAt.BackColor = System.Drawing.Color.Transparent;
            this.createdAt.BorderColor = System.Drawing.Color.Silver;
            this.createdAt.BorderRadius = 1;
            this.createdAt.Color = System.Drawing.Color.Silver;
            this.createdAt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.createdAt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.createdAt.DisabledColor = System.Drawing.Color.Gray;
            this.createdAt.DisplayWeekNumbers = false;
            this.createdAt.DPHeight = 0;
            this.createdAt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.createdAt.FillDatePicker = false;
            this.createdAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createdAt.ForeColor = System.Drawing.Color.Black;
            this.createdAt.Icon = ((System.Drawing.Image)(resources.GetObject("createdAt.Icon")));
            this.createdAt.IconColor = System.Drawing.Color.Gray;
            this.createdAt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.createdAt.LeftTextMargin = 5;
            this.createdAt.Location = new System.Drawing.Point(124, 270);
            this.createdAt.MaximumSize = new System.Drawing.Size(270, 60);
            this.createdAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.createdAt.Name = "createdAt";
            this.createdAt.Size = new System.Drawing.Size(260, 32);
            this.createdAt.TabIndex = 10;
            this.createdAt.Value = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            // 
            // dateStartPick
            // 
            this.dateStartPick.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateStartPick.BackColor = System.Drawing.Color.Transparent;
            this.dateStartPick.BorderColor = System.Drawing.Color.Silver;
            this.dateStartPick.BorderRadius = 1;
            this.dateStartPick.Color = System.Drawing.Color.Silver;
            this.dateStartPick.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateStartPick.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateStartPick.DisabledColor = System.Drawing.Color.Gray;
            this.dateStartPick.DisplayWeekNumbers = false;
            this.dateStartPick.DPHeight = 0;
            this.dateStartPick.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateStartPick.FillDatePicker = false;
            this.dateStartPick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateStartPick.ForeColor = System.Drawing.Color.Black;
            this.dateStartPick.Icon = ((System.Drawing.Image)(resources.GetObject("dateStartPick.Icon")));
            this.dateStartPick.IconColor = System.Drawing.Color.Gray;
            this.dateStartPick.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateStartPick.LeftTextMargin = 5;
            this.dateStartPick.Location = new System.Drawing.Point(554, 65);
            this.dateStartPick.MaximumSize = new System.Drawing.Size(270, 60);
            this.dateStartPick.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateStartPick.Name = "dateStartPick";
            this.dateStartPick.Size = new System.Drawing.Size(220, 32);
            this.dateStartPick.TabIndex = 11;
            this.dateStartPick.Value = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.dateStartPick.ValueChanged += new System.EventHandler(this.dateStartPick_ValueChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.AllowParentOverrides = false;
            this.dateEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateEnd.AutoEllipsis = false;
            this.dateEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateEnd.CursorType = System.Windows.Forms.Cursors.Default;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateEnd.Location = new System.Drawing.Point(554, 112);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateEnd.Size = new System.Drawing.Size(50, 15);
            this.dateEnd.TabIndex = 12;
            this.dateEnd.Text = "Đến ngày";
            this.dateEnd.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.dateEnd.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dateStart
            // 
            this.dateStart.AllowParentOverrides = false;
            this.dateStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateStart.AutoEllipsis = false;
            this.dateStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateStart.CursorType = System.Windows.Forms.Cursors.Default;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateStart.Location = new System.Drawing.Point(554, 44);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateStart.Size = new System.Drawing.Size(42, 15);
            this.dateStart.TabIndex = 13;
            this.dateStart.Text = "Từ ngày";
            this.dateStart.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.dateStart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txbRevenueName
            // 
            this.txbRevenueName.AcceptsReturn = false;
            this.txbRevenueName.AcceptsTab = false;
            this.txbRevenueName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRevenueName.AnimationSpeed = 200;
            this.txbRevenueName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbRevenueName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbRevenueName.AutoSizeHeight = true;
            this.txbRevenueName.BackColor = System.Drawing.Color.Transparent;
            this.txbRevenueName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbRevenueName.BackgroundImage")));
            this.txbRevenueName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbRevenueName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbRevenueName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbRevenueName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbRevenueName.BorderRadius = 1;
            this.txbRevenueName.BorderThickness = 1;
            this.txbRevenueName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRevenueName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRevenueName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbRevenueName.DefaultText = "";
            this.txbRevenueName.FillColor = System.Drawing.Color.White;
            this.txbRevenueName.HideSelection = true;
            this.txbRevenueName.IconLeft = null;
            this.txbRevenueName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRevenueName.IconPadding = 10;
            this.txbRevenueName.IconRight = null;
            this.txbRevenueName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRevenueName.Lines = new string[0];
            this.txbRevenueName.Location = new System.Drawing.Point(124, 41);
            this.txbRevenueName.MaximumSize = new System.Drawing.Size(270, 60);
            this.txbRevenueName.MaxLength = 32767;
            this.txbRevenueName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbRevenueName.Modified = false;
            this.txbRevenueName.Multiline = false;
            this.txbRevenueName.Name = "txbRevenueName";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbRevenueName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbRevenueName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbRevenueName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbRevenueName.OnIdleState = stateProperties12;
            this.txbRevenueName.Padding = new System.Windows.Forms.Padding(3);
            this.txbRevenueName.PasswordChar = '\0';
            this.txbRevenueName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbRevenueName.PlaceholderText = "Nhập tên doanh thu";
            this.txbRevenueName.ReadOnly = false;
            this.txbRevenueName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRevenueName.SelectedText = "";
            this.txbRevenueName.SelectionLength = 0;
            this.txbRevenueName.SelectionStart = 0;
            this.txbRevenueName.ShortcutsEnabled = true;
            this.txbRevenueName.Size = new System.Drawing.Size(260, 39);
            this.txbRevenueName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbRevenueName.TabIndex = 14;
            this.txbRevenueName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbRevenueName.TextMarginBottom = 0;
            this.txbRevenueName.TextMarginLeft = 3;
            this.txbRevenueName.TextMarginTop = 1;
            this.txbRevenueName.TextPlaceholder = "Nhập tên doanh thu";
            this.txbRevenueName.UseSystemPasswordChar = false;
            this.txbRevenueName.WordWrap = true;
            // 
            // txbCreator
            // 
            this.txbCreator.AcceptsReturn = false;
            this.txbCreator.AcceptsTab = false;
            this.txbCreator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbCreator.AnimationSpeed = 200;
            this.txbCreator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbCreator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbCreator.AutoSizeHeight = true;
            this.txbCreator.BackColor = System.Drawing.Color.Transparent;
            this.txbCreator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbCreator.BackgroundImage")));
            this.txbCreator.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbCreator.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbCreator.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbCreator.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbCreator.BorderRadius = 1;
            this.txbCreator.BorderThickness = 1;
            this.txbCreator.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCreator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCreator.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbCreator.DefaultText = "";
            this.txbCreator.Enabled = false;
            this.txbCreator.FillColor = System.Drawing.Color.White;
            this.txbCreator.HideSelection = true;
            this.txbCreator.IconLeft = null;
            this.txbCreator.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCreator.IconPadding = 10;
            this.txbCreator.IconRight = null;
            this.txbCreator.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCreator.Lines = new string[0];
            this.txbCreator.Location = new System.Drawing.Point(124, 190);
            this.txbCreator.MaximumSize = new System.Drawing.Size(270, 60);
            this.txbCreator.MaxLength = 32767;
            this.txbCreator.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbCreator.Modified = false;
            this.txbCreator.Multiline = false;
            this.txbCreator.Name = "txbCreator";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbCreator.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbCreator.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbCreator.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbCreator.OnIdleState = stateProperties16;
            this.txbCreator.Padding = new System.Windows.Forms.Padding(3);
            this.txbCreator.PasswordChar = '\0';
            this.txbCreator.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbCreator.PlaceholderText = "";
            this.txbCreator.ReadOnly = false;
            this.txbCreator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCreator.SelectedText = "";
            this.txbCreator.SelectionLength = 0;
            this.txbCreator.SelectionStart = 0;
            this.txbCreator.ShortcutsEnabled = true;
            this.txbCreator.Size = new System.Drawing.Size(260, 39);
            this.txbCreator.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbCreator.TabIndex = 15;
            this.txbCreator.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbCreator.TextMarginBottom = 0;
            this.txbCreator.TextMarginLeft = 3;
            this.txbCreator.TextMarginTop = 1;
            this.txbCreator.TextPlaceholder = "";
            this.txbCreator.UseSystemPasswordChar = false;
            this.txbCreator.WordWrap = true;
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
            // fRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbCreator);
            this.Controls.Add(this.txbRevenueName);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStartPick);
            this.Controls.Add(this.createdAt);
            this.Controls.Add(this.nmrRevenueSum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateEndPick);
            this.Controls.Add(this.lbCreatedAt);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.lbRevenueSummary);
            this.Controls.Add(this.lbRevenueName);
            this.Name = "fRevenue";
            this.Text = "fRevenue";
            ((System.ComponentModel.ISupportInitialize)(this.nmrRevenueSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbRevenueName;
        private Bunifu.UI.WinForms.BunifuLabel lbRevenueSummary;
        private Bunifu.UI.WinForms.BunifuLabel lbCreatedBy;
        private Bunifu.UI.WinForms.BunifuLabel lbCreatedAt;
        private Bunifu.UI.WinForms.BunifuDatePicker dateEndPick;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private System.Windows.Forms.NumericUpDown nmrRevenueSum;
        private Bunifu.UI.WinForms.BunifuDatePicker createdAt;
        private Bunifu.UI.WinForms.BunifuDatePicker dateStartPick;
        private Bunifu.UI.WinForms.BunifuLabel dateEnd;
        private Bunifu.UI.WinForms.BunifuLabel dateStart;
        private Bunifu.UI.WinForms.BunifuTextBox txbRevenueName;
        private Bunifu.UI.WinForms.BunifuTextBox txbCreator;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}
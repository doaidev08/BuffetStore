namespace Buffet.GUI.GUI_FoodManagement
{
    partial class fAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddFood));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnDeleteVal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnAddFood = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.BorderRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txbFoodName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.selectFoodCate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtFoodCount = new System.Windows.Forms.NumericUpDown();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbFoodCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbFoodCate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbFoodName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodCount)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuLabel1.Location = new System.Drawing.Point(356, 31);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(136, 31);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Thêm món ăn";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 1;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnDeleteVal);
            this.bunifuPanel2.Controls.Add(this.btnAddFood);
            this.bunifuPanel2.Location = new System.Drawing.Point(551, 319);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(202, 37);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // btnDeleteVal
            // 
            this.btnDeleteVal.AllowAnimations = true;
            this.btnDeleteVal.AllowMouseEffects = true;
            this.btnDeleteVal.AllowToggling = false;
            this.btnDeleteVal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteVal.AnimationSpeed = 200;
            this.btnDeleteVal.AutoGenerateColors = false;
            this.btnDeleteVal.AutoRoundBorders = false;
            this.btnDeleteVal.AutoSizeLeftIcon = true;
            this.btnDeleteVal.AutoSizeRightIcon = true;
            this.btnDeleteVal.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteVal.BackColor1 = System.Drawing.Color.Khaki;
            this.btnDeleteVal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteVal.BackgroundImage")));
            this.btnDeleteVal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDeleteVal.ButtonText = "Xóa thông tin";
            this.btnDeleteVal.ButtonTextMarginLeft = 0;
            this.btnDeleteVal.ColorContrastOnClick = 45;
            this.btnDeleteVal.ColorContrastOnHover = 45;
            this.btnDeleteVal.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnDeleteVal.CustomizableEdges = borderEdges10;
            this.btnDeleteVal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteVal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteVal.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteVal.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteVal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnDeleteVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVal.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteVal.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVal.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDeleteVal.IconMarginLeft = 11;
            this.btnDeleteVal.IconPadding = 10;
            this.btnDeleteVal.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteVal.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVal.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteVal.IconSize = 25;
            this.btnDeleteVal.IdleBorderColor = System.Drawing.Color.Wheat;
            this.btnDeleteVal.IdleBorderRadius = 2;
            this.btnDeleteVal.IdleBorderThickness = 1;
            this.btnDeleteVal.IdleFillColor = System.Drawing.Color.Khaki;
            this.btnDeleteVal.IdleIconLeftImage = null;
            this.btnDeleteVal.IdleIconRightImage = null;
            this.btnDeleteVal.IndicateFocus = false;
            this.btnDeleteVal.Location = new System.Drawing.Point(15, 3);
            this.btnDeleteVal.Name = "btnDeleteVal";
            this.btnDeleteVal.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteVal.OnDisabledState.BorderRadius = 2;
            this.btnDeleteVal.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDeleteVal.OnDisabledState.BorderThickness = 1;
            this.btnDeleteVal.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteVal.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteVal.OnDisabledState.IconLeftImage = null;
            this.btnDeleteVal.OnDisabledState.IconRightImage = null;
            this.btnDeleteVal.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDeleteVal.onHoverState.BorderRadius = 2;
            this.btnDeleteVal.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDeleteVal.onHoverState.BorderThickness = 1;
            this.btnDeleteVal.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDeleteVal.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVal.onHoverState.IconLeftImage = null;
            this.btnDeleteVal.onHoverState.IconRightImage = null;
            this.btnDeleteVal.OnIdleState.BorderColor = System.Drawing.Color.Wheat;
            this.btnDeleteVal.OnIdleState.BorderRadius = 2;
            this.btnDeleteVal.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDeleteVal.OnIdleState.BorderThickness = 1;
            this.btnDeleteVal.OnIdleState.FillColor = System.Drawing.Color.Khaki;
            this.btnDeleteVal.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVal.OnIdleState.IconLeftImage = null;
            this.btnDeleteVal.OnIdleState.IconRightImage = null;
            this.btnDeleteVal.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDeleteVal.OnPressedState.BorderRadius = 2;
            this.btnDeleteVal.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDeleteVal.OnPressedState.BorderThickness = 1;
            this.btnDeleteVal.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDeleteVal.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVal.OnPressedState.IconLeftImage = null;
            this.btnDeleteVal.OnPressedState.IconRightImage = null;
            this.btnDeleteVal.Size = new System.Drawing.Size(89, 30);
            this.btnDeleteVal.TabIndex = 0;
            this.btnDeleteVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteVal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteVal.TextMarginLeft = 0;
            this.btnDeleteVal.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDeleteVal.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.AllowAnimations = true;
            this.btnAddFood.AllowMouseEffects = true;
            this.btnAddFood.AllowToggling = false;
            this.btnAddFood.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFood.AnimationSpeed = 200;
            this.btnAddFood.AutoGenerateColors = false;
            this.btnAddFood.AutoRoundBorders = false;
            this.btnAddFood.AutoSizeLeftIcon = true;
            this.btnAddFood.AutoSizeRightIcon = true;
            this.btnAddFood.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddFood.ButtonText = "Thêm món";
            this.btnAddFood.ButtonTextMarginLeft = 0;
            this.btnAddFood.ColorContrastOnClick = 45;
            this.btnAddFood.ColorContrastOnHover = 45;
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnAddFood.CustomizableEdges = borderEdges11;
            this.btnAddFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddFood.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddFood.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddFood.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddFood.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddFood.IconMarginLeft = 11;
            this.btnAddFood.IconPadding = 10;
            this.btnAddFood.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddFood.IconSize = 25;
            this.btnAddFood.IdleBorderColor = System.Drawing.Color.Wheat;
            this.btnAddFood.IdleBorderRadius = 2;
            this.btnAddFood.IdleBorderThickness = 1;
            this.btnAddFood.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddFood.IdleIconLeftImage = null;
            this.btnAddFood.IdleIconRightImage = null;
            this.btnAddFood.IndicateFocus = false;
            this.btnAddFood.Location = new System.Drawing.Point(110, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddFood.OnDisabledState.BorderRadius = 2;
            this.btnAddFood.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddFood.OnDisabledState.BorderThickness = 1;
            this.btnAddFood.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddFood.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddFood.OnDisabledState.IconLeftImage = null;
            this.btnAddFood.OnDisabledState.IconRightImage = null;
            this.btnAddFood.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddFood.onHoverState.BorderRadius = 2;
            this.btnAddFood.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddFood.onHoverState.BorderThickness = 1;
            this.btnAddFood.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddFood.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.onHoverState.IconLeftImage = null;
            this.btnAddFood.onHoverState.IconRightImage = null;
            this.btnAddFood.OnIdleState.BorderColor = System.Drawing.Color.Wheat;
            this.btnAddFood.OnIdleState.BorderRadius = 2;
            this.btnAddFood.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddFood.OnIdleState.BorderThickness = 1;
            this.btnAddFood.OnIdleState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddFood.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.OnIdleState.IconLeftImage = null;
            this.btnAddFood.OnIdleState.IconRightImage = null;
            this.btnAddFood.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddFood.OnPressedState.BorderRadius = 2;
            this.btnAddFood.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddFood.OnPressedState.BorderThickness = 1;
            this.btnAddFood.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddFood.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.OnPressedState.IconLeftImage = null;
            this.btnAddFood.OnPressedState.IconRightImage = null;
            this.btnAddFood.Size = new System.Drawing.Size(89, 30);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFood.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddFood.TextMarginLeft = 0;
            this.btnAddFood.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddFood.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges12;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.Gainsboro;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(757, 12);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = true;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(31, 30);
            this.bunifuFormCaptionButton1.TabIndex = 0;
            // 
            // BorderRadius
            // 
            this.BorderRadius.ElipseRadius = 15;
            this.BorderRadius.TargetControl = this.btnDeleteVal;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnAddFood;
            // 
            // txbFoodName
            // 
            this.txbFoodName.AcceptsReturn = false;
            this.txbFoodName.AcceptsTab = false;
            this.txbFoodName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbFoodName.AnimationSpeed = 200;
            this.txbFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbFoodName.AutoSizeHeight = true;
            this.txbFoodName.BackColor = System.Drawing.Color.Transparent;
            this.txbFoodName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbFoodName.BackgroundImage")));
            this.txbFoodName.BorderColorActive = System.Drawing.Color.DarkOrange;
            this.txbFoodName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbFoodName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbFoodName.BorderColorIdle = System.Drawing.Color.Silver;
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
            this.txbFoodName.Location = new System.Drawing.Point(105, 6);
            this.txbFoodName.MaxLength = 32767;
            this.txbFoodName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbFoodName.Modified = false;
            this.txbFoodName.Multiline = false;
            this.txbFoodName.Name = "txbFoodName";
            stateProperties13.BorderColor = System.Drawing.Color.DarkOrange;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbFoodName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbFoodName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbFoodName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbFoodName.OnIdleState = stateProperties16;
            this.txbFoodName.Padding = new System.Windows.Forms.Padding(3);
            this.txbFoodName.PasswordChar = '\0';
            this.txbFoodName.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.txbFoodName.PlaceholderText = "Nhập tên món ăn";
            this.txbFoodName.ReadOnly = false;
            this.txbFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFoodName.SelectedText = "";
            this.txbFoodName.SelectionLength = 0;
            this.txbFoodName.SelectionStart = 0;
            this.txbFoodName.ShortcutsEnabled = true;
            this.txbFoodName.Size = new System.Drawing.Size(179, 27);
            this.txbFoodName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbFoodName.TabIndex = 1;
            this.txbFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbFoodName.TextMarginBottom = 0;
            this.txbFoodName.TextMarginLeft = 3;
            this.txbFoodName.TextMarginTop = 1;
            this.txbFoodName.TextPlaceholder = "Nhập tên món ăn";
            this.txbFoodName.UseSystemPasswordChar = false;
            this.txbFoodName.WordWrap = true;
            // 
            // selectFoodCate
            // 
            this.selectFoodCate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectFoodCate.BackColor = System.Drawing.Color.Transparent;
            this.selectFoodCate.BackgroundColor = System.Drawing.Color.White;
            this.selectFoodCate.BorderColor = System.Drawing.Color.Silver;
            this.selectFoodCate.BorderRadius = 1;
            this.selectFoodCate.Color = System.Drawing.Color.Silver;
            this.selectFoodCate.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.selectFoodCate.Location = new System.Drawing.Point(107, 3);
            this.selectFoodCate.Name = "selectFoodCate";
            this.selectFoodCate.Size = new System.Drawing.Size(180, 32);
            this.selectFoodCate.TabIndex = 2;
            this.selectFoodCate.Text = null;
            this.selectFoodCate.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectFoodCate.TextLeftMargin = 5;
            this.selectFoodCate.SelectedIndexChanged += new System.EventHandler(this.selectFoodCate_SelectedIndexChanged);
            // 
            // txtFoodCount
            // 
            this.txtFoodCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFoodCount.Location = new System.Drawing.Point(114, 119);
            this.txtFoodCount.Name = "txtFoodCount";
            this.txtFoodCount.Size = new System.Drawing.Size(84, 20);
            this.txtFoodCount.TabIndex = 3;
            this.txtFoodCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuPanel4);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel1.Controls.Add(this.txtFoodCount);
            this.bunifuPanel1.Controls.Add(this.lbFoodCount);
            this.bunifuPanel1.Location = new System.Drawing.Point(54, 95);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(711, 192);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // lbFoodCount
            // 
            this.lbFoodCount.AllowParentOverrides = false;
            this.lbFoodCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFoodCount.AutoEllipsis = false;
            this.lbFoodCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFoodCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbFoodCount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbFoodCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbFoodCount.Location = new System.Drawing.Point(17, 119);
            this.lbFoodCount.Name = "lbFoodCount";
            this.lbFoodCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFoodCount.Size = new System.Drawing.Size(60, 20);
            this.lbFoodCount.TabIndex = 0;
            this.lbFoodCount.Text = "Số lượng";
            this.lbFoodCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbFoodCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbFoodCate
            // 
            this.lbFoodCate.AllowParentOverrides = false;
            this.lbFoodCate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbFoodCate.AutoEllipsis = false;
            this.lbFoodCate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFoodCate.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbFoodCate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbFoodCate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbFoodCate.Location = new System.Drawing.Point(19, 15);
            this.lbFoodCate.Name = "lbFoodCate";
            this.lbFoodCate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFoodCate.Size = new System.Drawing.Size(82, 20);
            this.lbFoodCate.TabIndex = 0;
            this.lbFoodCate.Text = "Loại món ăn";
            this.lbFoodCate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbFoodCate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AllowParentOverrides = false;
            this.lbFoodName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFoodName.AutoEllipsis = false;
            this.lbFoodName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFoodName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbFoodName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbFoodName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbFoodName.Location = new System.Drawing.Point(8, 13);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFoodName.Size = new System.Drawing.Size(91, 20);
            this.lbFoodName.TabIndex = 0;
            this.lbFoodName.Text = "Thêm món ăn";
            this.lbFoodName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbFoodName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.txbFoodName);
            this.bunifuPanel3.Controls.Add(this.lbFoodName);
            this.bunifuPanel3.Location = new System.Drawing.Point(9, 18);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(320, 42);
            this.bunifuPanel3.TabIndex = 4;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.selectFoodCate);
            this.bunifuPanel4.Controls.Add(this.lbFoodCate);
            this.bunifuPanel4.Location = new System.Drawing.Point(385, 18);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(322, 41);
            this.bunifuPanel4.TabIndex = 5;
            // 
            // fAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuFormCaptionButton1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddFood";
            this.Text = "Thêm món ăn";
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodCount)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDeleteVal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAddFood;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.Framework.UI.BunifuElipse BorderRadius;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox txbFoodName;
        private Bunifu.UI.WinForms.BunifuDropdown selectFoodCate;
        private System.Windows.Forms.NumericUpDown txtFoodCount;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lbFoodCount;
        private Bunifu.UI.WinForms.BunifuLabel lbFoodCate;
        private Bunifu.UI.WinForms.BunifuLabel lbFoodName;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
    }
}
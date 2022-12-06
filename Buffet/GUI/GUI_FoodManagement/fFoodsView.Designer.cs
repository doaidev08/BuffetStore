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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFoodsView));
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            this.tableMainDish = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDesserts = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAppetizer = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFoodList = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            ((System.ComponentModel.ISupportInitialize)(this.tableMainDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAppetizer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMainDish
            // 
            this.tableMainDish.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableMainDish.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableMainDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableMainDish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableMainDish.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableMainDish.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableMainDish.ColumnHeadersHeight = 40;
            this.tableMainDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.cateType,
            this.action});
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableMainDish.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableMainDish.EnableHeadersVisualStyles = false;
            this.tableMainDish.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableMainDish.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableMainDish.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableMainDish.HeaderForeColor = System.Drawing.Color.White;
            this.tableMainDish.Location = new System.Drawing.Point(42, 51);
            this.tableMainDish.Name = "tableMainDish";
            this.tableMainDish.RowHeadersVisible = false;
            this.tableMainDish.RowTemplate.Height = 40;
            this.tableMainDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableMainDish.Size = new System.Drawing.Size(360, 387);
            this.tableMainDish.TabIndex = 0;
            this.tableMainDish.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tableMainDish.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMainDish_CellContentClick);
            // 
            // code
            // 
            this.code.HeaderText = "Mã món ăn";
            this.code.Name = "code";
            // 
            // name
            // 
            this.name.HeaderText = "Tên món ăn";
            this.name.Name = "name";
            // 
            // cateType
            // 
            this.cateType.HeaderText = "Danh mục";
            this.cateType.Name = "cateType";
            // 
            // action
            // 
            this.action.HeaderText = "Hành Động";
            this.action.Name = "action";
            // 
            // tableDesserts
            // 
            this.tableDesserts.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.tableDesserts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableDesserts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDesserts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDesserts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDesserts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableDesserts.ColumnHeadersHeight = 40;
            this.tableDesserts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableDesserts.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableDesserts.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableDesserts.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableDesserts.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableDesserts.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableDesserts.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableDesserts.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableDesserts.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableDesserts.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableDesserts.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableDesserts.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tableDesserts.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tableDesserts.CurrentTheme.Name = null;
            this.tableDesserts.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableDesserts.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableDesserts.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableDesserts.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableDesserts.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDesserts.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableDesserts.EnableHeadersVisualStyles = false;
            this.tableDesserts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableDesserts.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableDesserts.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableDesserts.HeaderForeColor = System.Drawing.Color.White;
            this.tableDesserts.Location = new System.Drawing.Point(450, 255);
            this.tableDesserts.Name = "tableDesserts";
            this.tableDesserts.RowHeadersVisible = false;
            this.tableDesserts.RowTemplate.Height = 40;
            this.tableDesserts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDesserts.Size = new System.Drawing.Size(360, 183);
            this.tableDesserts.TabIndex = 1;
            this.tableDesserts.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã món ăn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên món ăn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hành Động";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tableAppetizer
            // 
            this.tableAppetizer.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.tableAppetizer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableAppetizer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAppetizer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableAppetizer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAppetizer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableAppetizer.ColumnHeadersHeight = 40;
            this.tableAppetizer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tableAppetizer.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableAppetizer.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableAppetizer.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableAppetizer.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableAppetizer.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableAppetizer.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableAppetizer.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableAppetizer.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableAppetizer.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableAppetizer.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableAppetizer.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tableAppetizer.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tableAppetizer.CurrentTheme.Name = null;
            this.tableAppetizer.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableAppetizer.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableAppetizer.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableAppetizer.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableAppetizer.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAppetizer.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableAppetizer.EnableHeadersVisualStyles = false;
            this.tableAppetizer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableAppetizer.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableAppetizer.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableAppetizer.HeaderForeColor = System.Drawing.Color.White;
            this.tableAppetizer.Location = new System.Drawing.Point(450, 51);
            this.tableAppetizer.Name = "tableAppetizer";
            this.tableAppetizer.RowHeadersVisible = false;
            this.tableAppetizer.RowTemplate.Height = 40;
            this.tableAppetizer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAppetizer.Size = new System.Drawing.Size(360, 183);
            this.tableAppetizer.TabIndex = 2;
            this.tableAppetizer.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã món ăn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên món ăn";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Hành Động";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // lbFoodList
            // 
            this.lbFoodList.AllowParentOverrides = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges1;
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
            // fFoodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.bunifuFormCaptionButton1);
            this.Controls.Add(this.lbFoodList);
            this.Controls.Add(this.tableAppetizer);
            this.Controls.Add(this.tableDesserts);
            this.Controls.Add(this.tableMainDish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFoodsView";
            this.Text = "Danh sách món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.tableMainDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAppetizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView tableMainDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Bunifu.UI.WinForms.BunifuDataGridView tableDesserts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.UI.WinForms.BunifuDataGridView tableAppetizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Bunifu.UI.WinForms.BunifuLabel lbFoodList;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
    }
}
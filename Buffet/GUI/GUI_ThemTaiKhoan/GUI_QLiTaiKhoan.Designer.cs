namespace Buffet.GUI.GUI_ThemTaiKhoan
{
    partial class GUI_QLiTaiKhoan
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
            this.materialHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldTenNV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateStaff = new System.Windows.Forms.Button();
            this.DeleteStaff = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TextFieldSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.textFiledCCCD = new System.Windows.Forms.NumericUpDown();
            this.textFieldSDT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bunifuDataGridViewStaff = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.textFiledCCCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // materialHeader
            // 
            this.materialHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialHeader.AutoSize = true;
            this.materialHeader.Depth = 0;
            this.materialHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialHeader.Location = new System.Drawing.Point(317, 9);
            this.materialHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialHeader.Name = "materialHeader";
            this.materialHeader.Size = new System.Drawing.Size(290, 24);
            this.materialHeader.TabIndex = 0;
            this.materialHeader.Text = "QUẢN LÍ TÀI KHOẢN NHÂN VIÊN";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Ngày sinh :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Số CCCD :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(22, 164);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Điện thoại :";
            // 
            // textFieldTenNV
            // 
            this.textFieldTenNV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textFieldTenNV.Depth = 0;
            this.textFieldTenNV.Hint = "";
            this.textFieldTenNV.Location = new System.Drawing.Point(201, 36);
            this.textFieldTenNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldTenNV.Name = "textFieldTenNV";
            this.textFieldTenNV.PasswordChar = '\0';
            this.textFieldTenNV.SelectedText = "";
            this.textFieldTenNV.SelectionLength = 0;
            this.textFieldTenNV.SelectionStart = 0;
            this.textFieldTenNV.Size = new System.Drawing.Size(205, 28);
            this.textFieldTenNV.TabIndex = 5;
            this.textFieldTenNV.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(22, 36);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(160, 24);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Họ tên nhân viên :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(33, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // UpdateStaff
            // 
            this.UpdateStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateStaff.BackColor = System.Drawing.Color.Orange;
            this.UpdateStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateStaff.Location = new System.Drawing.Point(164, 204);
            this.UpdateStaff.Name = "UpdateStaff";
            this.UpdateStaff.Size = new System.Drawing.Size(97, 31);
            this.UpdateStaff.TabIndex = 12;
            this.UpdateStaff.Text = "Sửa";
            this.UpdateStaff.UseVisualStyleBackColor = false;
            this.UpdateStaff.Click += new System.EventHandler(this.UpdateStaff_Click);
            // 
            // DeleteStaff
            // 
            this.DeleteStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteStaff.BackColor = System.Drawing.Color.Orange;
            this.DeleteStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteStaff.Location = new System.Drawing.Point(304, 203);
            this.DeleteStaff.Name = "DeleteStaff";
            this.DeleteStaff.Size = new System.Drawing.Size(102, 32);
            this.DeleteStaff.TabIndex = 13;
            this.DeleteStaff.Text = "Xóa";
            this.DeleteStaff.UseVisualStyleBackColor = false;
            this.DeleteStaff.Click += new System.EventHandler(this.DeleteStaff_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(659, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 32);
            this.button4.TabIndex = 15;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextFieldSearch
            // 
            this.TextFieldSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextFieldSearch.Depth = 0;
            this.TextFieldSearch.Hint = "";
            this.TextFieldSearch.Location = new System.Drawing.Point(453, 207);
            this.TextFieldSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldSearch.Name = "TextFieldSearch";
            this.TextFieldSearch.PasswordChar = '\0';
            this.TextFieldSearch.SelectedText = "";
            this.TextFieldSearch.SelectionLength = 0;
            this.TextFieldSearch.SelectionStart = 0;
            this.TextFieldSearch.Size = new System.Drawing.Size(154, 28);
            this.TextFieldSearch.TabIndex = 16;
            this.TextFieldSearch.Text = "Tìm kiếm";
            this.TextFieldSearch.UseSystemPasswordChar = false;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(201, 82);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(203, 22);
            this.dateTimePickerNgaySinh.TabIndex = 17;
            // 
            // textFiledCCCD
            // 
            this.textFiledCCCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textFiledCCCD.Location = new System.Drawing.Point(201, 125);
            this.textFiledCCCD.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.textFiledCCCD.Name = "textFiledCCCD";
            this.textFiledCCCD.Size = new System.Drawing.Size(203, 22);
            this.textFiledCCCD.TabIndex = 18;
            // 
            // textFieldSDT
            // 
            this.textFieldSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textFieldSDT.Depth = 0;
            this.textFieldSDT.Hint = "";
            this.textFieldSDT.Location = new System.Drawing.Point(201, 164);
            this.textFieldSDT.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSDT.Name = "textFieldSDT";
            this.textFieldSDT.PasswordChar = '\0';
            this.textFieldSDT.SelectedText = "";
            this.textFieldSDT.SelectionLength = 0;
            this.textFieldSDT.SelectionStart = 0;
            this.textFieldSDT.Size = new System.Drawing.Size(203, 28);
            this.textFieldSDT.TabIndex = 19;
            this.textFieldSDT.UseSystemPasswordChar = false;
            // 
            // bunifuDataGridViewStaff
            // 
            this.bunifuDataGridViewStaff.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridViewStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridViewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridViewStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridViewStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridViewStaff.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridViewStaff.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridViewStaff.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridViewStaff.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridViewStaff.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridViewStaff.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridViewStaff.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridViewStaff.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridViewStaff.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridViewStaff.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridViewStaff.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridViewStaff.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridViewStaff.CurrentTheme.Name = null;
            this.bunifuDataGridViewStaff.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridViewStaff.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridViewStaff.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridViewStaff.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridViewStaff.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridViewStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridViewStaff.EnableHeadersVisualStyles = false;
            this.bunifuDataGridViewStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridViewStaff.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridViewStaff.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridViewStaff.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridViewStaff.Location = new System.Drawing.Point(12, 275);
            this.bunifuDataGridViewStaff.Name = "bunifuDataGridViewStaff";
            this.bunifuDataGridViewStaff.RowHeadersVisible = false;
            this.bunifuDataGridViewStaff.RowHeadersWidth = 51;
            this.bunifuDataGridViewStaff.RowTemplate.Height = 40;
            this.bunifuDataGridViewStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridViewStaff.Size = new System.Drawing.Size(776, 163);
            this.bunifuDataGridViewStaff.TabIndex = 20;
            this.bunifuDataGridViewStaff.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridViewStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowClick_Bunifu);
            // 
            // GUI_QLiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuDataGridViewStaff);
            this.Controls.Add(this.textFieldSDT);
            this.Controls.Add(this.textFiledCCCD);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.TextFieldSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteStaff);
            this.Controls.Add(this.UpdateStaff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.textFieldTenNV);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialHeader);
            this.Name = "GUI_QLiTaiKhoan";
            this.Text = "GUI_QLiTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.textFiledCCCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialHeader;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldTenNV;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateStaff;
        private System.Windows.Forms.Button DeleteStaff;
        private System.Windows.Forms.Button button4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.NumericUpDown textFiledCCCD;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSDT;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridViewStaff;
    }
}
namespace Buffet.GUI.GUI_ThemTaiKhoan
{
    partial class GUI_ThemTaiKhoan
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxVaitro = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TextFieldUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMaNV = new System.Windows.Forms.ComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Tên truy cập :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 193);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Mật khẩu :";
            // 
            // comboBoxVaitro
            // 
            this.comboBoxVaitro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxVaitro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVaitro.FormattingEnabled = true;
            this.comboBoxVaitro.Location = new System.Drawing.Point(421, 131);
            this.comboBoxVaitro.Name = "comboBoxVaitro";
            this.comboBoxVaitro.Size = new System.Drawing.Size(152, 30);
            this.comboBoxVaitro.TabIndex = 5;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(285, 129);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(70, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Vai trò:";
            // 
            // TextFieldUserName
            // 
            this.TextFieldUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextFieldUserName.Depth = 0;
            this.TextFieldUserName.Hint = "";
            this.TextFieldUserName.Location = new System.Drawing.Point(141, 125);
            this.TextFieldUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldUserName.Name = "TextFieldUserName";
            this.TextFieldUserName.PasswordChar = '\0';
            this.TextFieldUserName.SelectedText = "";
            this.TextFieldUserName.SelectionLength = 0;
            this.TextFieldUserName.SelectionStart = 0;
            this.TextFieldUserName.Size = new System.Drawing.Size(101, 28);
            this.TextFieldUserName.TabIndex = 7;
            this.TextFieldUserName.UseSystemPasswordChar = false;
            // 
            // TextFieldPassword
            // 
            this.TextFieldPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextFieldPassword.Depth = 0;
            this.TextFieldPassword.Hint = "";
            this.TextFieldPassword.Location = new System.Drawing.Point(141, 189);
            this.TextFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldPassword.Name = "TextFieldPassword";
            this.TextFieldPassword.PasswordChar = '\0';
            this.TextFieldPassword.SelectedText = "";
            this.TextFieldPassword.SelectionLength = 0;
            this.TextFieldPassword.SelectionStart = 0;
            this.TextFieldPassword.Size = new System.Drawing.Size(101, 28);
            this.TextFieldPassword.TabIndex = 8;
            this.TextFieldPassword.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(193, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMaNV
            // 
            this.comboBoxMaNV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxMaNV.FormattingEnabled = true;
            this.comboBoxMaNV.Location = new System.Drawing.Point(421, 196);
            this.comboBoxMaNV.Name = "comboBoxMaNV";
            this.comboBoxMaNV.Size = new System.Drawing.Size(152, 24);
            this.comboBoxMaNV.TabIndex = 10;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(276, 189);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(138, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "Mã nhân viên:";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // GUI_ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.comboBoxMaNV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextFieldPassword);
            this.Controls.Add(this.TextFieldUserName);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.comboBoxVaitro);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.KeyPreview = true;
            this.Name = "GUI_ThemTaiKhoan";
            this.Text = "Thêm tài khoản";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_ThemTaiKhoan_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBoxVaitro;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMaNV;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
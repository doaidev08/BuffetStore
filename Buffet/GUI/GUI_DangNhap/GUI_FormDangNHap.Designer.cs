namespace Buffet.GUI.GUI_DangNhap
{
    partial class GUI_FormDangNHap
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
            this.LabelUser = new MaterialSkin.Controls.MaterialLabel();
            this.LabelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.TextFieldUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckBoxLogin = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LabelUser
            // 
            this.LabelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUser.AutoSize = true;
            this.LabelUser.Depth = 0;
            this.LabelUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelUser.Location = new System.Drawing.Point(12, 169);
            this.LabelUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(92, 24);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "Tài khoản";
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Depth = 0;
            this.LabelPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelPassword.Location = new System.Drawing.Point(12, 273);
            this.LabelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(88, 24);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Mật khẩu";
            // 
            // TextFieldUserName
            // 
            this.TextFieldUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldUserName.Depth = 0;
            this.TextFieldUserName.Hint = "";
            this.TextFieldUserName.Location = new System.Drawing.Point(152, 165);
            this.TextFieldUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldUserName.Name = "TextFieldUserName";
            this.TextFieldUserName.PasswordChar = '\0';
            this.TextFieldUserName.SelectedText = "";
            this.TextFieldUserName.SelectionLength = 0;
            this.TextFieldUserName.SelectionStart = 0;
            this.TextFieldUserName.Size = new System.Drawing.Size(428, 28);
            this.TextFieldUserName.TabIndex = 2;
            this.TextFieldUserName.UseSystemPasswordChar = false;
            // 
            // TextFieldPassword
            // 
            this.TextFieldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldPassword.Depth = 0;
            this.TextFieldPassword.Hint = "";
            this.TextFieldPassword.Location = new System.Drawing.Point(152, 269);
            this.TextFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldPassword.Name = "TextFieldPassword";
            this.TextFieldPassword.PasswordChar = '\0';
            this.TextFieldPassword.SelectedText = "";
            this.TextFieldPassword.SelectionLength = 0;
            this.TextFieldPassword.SelectionStart = 0;
            this.TextFieldPassword.Size = new System.Drawing.Size(428, 28);
            this.TextFieldPassword.TabIndex = 3;
            this.TextFieldPassword.UseSystemPasswordChar = true;
            // 
            // CheckBoxLogin
            // 
            this.CheckBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxLogin.AutoSize = true;
            this.CheckBoxLogin.Depth = 0;
            this.CheckBoxLogin.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxLogin.Location = new System.Drawing.Point(16, 339);
            this.CheckBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxLogin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxLogin.Name = "CheckBoxLogin";
            this.CheckBoxLogin.Ripple = true;
            this.CheckBoxLogin.Size = new System.Drawing.Size(136, 30);
            this.CheckBoxLogin.TabIndex = 4;
            this.CheckBoxLogin.Text = "Lưu tài khoản";
            this.CheckBoxLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Buffet.Properties.Resources.LogoLogin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(586, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 389);
            this.panel1.TabIndex = 6;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLogin.Depth = 0;
            this.ButtonLogin.Location = new System.Drawing.Point(180, 407);
            this.ButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Primary = true;
            this.ButtonLogin.Size = new System.Drawing.Size(245, 68);
            this.ButtonLogin.TabIndex = 7;
            this.ButtonLogin.Text = "Đăng nhập";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // GUI_FormDangNHap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 558);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckBoxLogin);
            this.Controls.Add(this.TextFieldPassword);
            this.Controls.Add(this.TextFieldUserName);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUser);
            this.KeyPreview = true;
            this.Name = "GUI_FormDangNHap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_FormDangNHap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_FormDangNHap_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelUser;
        private MaterialSkin.Controls.MaterialLabel LabelPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldPassword;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxLogin;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonLogin;
    }
}
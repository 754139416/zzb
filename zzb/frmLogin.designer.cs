namespace zzb
{
    partial class frmLogin
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
            this.btn_login = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxLogin = new CCWin.SkinControl.SkinGroupBox();
            this.txt_password = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new CCWin.SkinControl.SkinTextBox();
            this.CPanel_Login = new CCWin.SkinControl.SkinCaptionPanel();
            this.gboxLogin.SuspendLayout();
            this.CPanel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_login.DownBack = null;
            this.btn_login.Location = new System.Drawing.Point(28, 127);
            this.btn_login.MouseBack = null;
            this.btn_login.Name = "btn_login";
            this.btn_login.NormlBack = null;
            this.btn_login.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_login.Size = new System.Drawing.Size(55, 31);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // gboxLogin
            // 
            this.gboxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.gboxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.gboxLogin.Controls.Add(this.txt_password);
            this.gboxLogin.Controls.Add(this.label3);
            this.gboxLogin.Controls.Add(this.txt_id);
            this.gboxLogin.Controls.Add(this.label2);
            this.gboxLogin.ForeColor = System.Drawing.Color.Blue;
            this.gboxLogin.Location = new System.Drawing.Point(1, 4);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Radius = 10;
            this.gboxLogin.RectBackColor = System.Drawing.Color.Transparent;
            this.gboxLogin.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.gboxLogin.Size = new System.Drawing.Size(380, 110);
            this.gboxLogin.TabIndex = 7;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.gboxLogin.TitleRectBackColor = System.Drawing.Color.SpringGreen;
            this.gboxLogin.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.DownBack = null;
            this.txt_password.Icon = null;
            this.txt_password.IconIsButton = false;
            this.txt_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_password.IsPasswordChat = '*';
            this.txt_password.IsSystemPasswordChar = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(108, 60);
            this.txt_password.Margin = new System.Windows.Forms.Padding(0);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_password.MouseBack = null;
            this.txt_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.NormlBack = null;
            this.txt_password.Padding = new System.Windows.Forms.Padding(5);
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.Size = new System.Drawing.Size(235, 28);
            // 
            // 
            // 
            this.txt_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_password.SkinTxt.Name = "BaseText";
            this.txt_password.SkinTxt.PasswordChar = '*';
            this.txt_password.SkinTxt.Size = new System.Drawing.Size(225, 16);
            this.txt_password.SkinTxt.TabIndex = 0;
            this.txt_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_password.SkinTxt.WaterText = "";
            this.txt_password.TabIndex = 6;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_password.WaterText = "";
            this.txt_password.WordWrap = true;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "登录密码";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_id.DownBack = null;
            this.txt_id.Icon = null;
            this.txt_id.IconIsButton = false;
            this.txt_id.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_id.IsPasswordChat = '\0';
            this.txt_id.IsSystemPasswordChar = false;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(108, 28);
            this.txt_id.Margin = new System.Windows.Forms.Padding(0);
            this.txt_id.MaxLength = 32767;
            this.txt_id.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_id.MouseBack = null;
            this.txt_id.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.NormlBack = null;
            this.txt_id.Padding = new System.Windows.Forms.Padding(5);
            this.txt_id.ReadOnly = false;
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.Size = new System.Drawing.Size(235, 28);
            // 
            // 
            // 
            this.txt_id.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_id.SkinTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt_id.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_id.SkinTxt.Name = "BaseText";
            this.txt_id.SkinTxt.Size = new System.Drawing.Size(225, 16);
            this.txt_id.SkinTxt.TabIndex = 0;
            this.txt_id.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_id.SkinTxt.WaterText = "";
            this.txt_id.TabIndex = 4;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_id.WaterText = "";
            this.txt_id.WordWrap = true;
            // 
            // CPanel_Login
            // 
            this.CPanel_Login.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic);
            this.CPanel_Login.CaptionHeight = 28;
            this.CPanel_Login.CaptionStyle = CCWin.SkinControl.CaptionStyle.Bottom;
            this.CPanel_Login.Controls.Add(this.gboxLogin);
            this.CPanel_Login.Controls.Add(this.btn_login);
            this.CPanel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPanel_Login.Location = new System.Drawing.Point(4, 28);
            this.CPanel_Login.Name = "CPanel_Login";
            this.CPanel_Login.Size = new System.Drawing.Size(386, 203);
            this.CPanel_Login.TabIndex = 9;
            this.CPanel_Login.Text = " 欢迎使用中证宝，方便快捷，彻底解决忘记携带身份证烦恼";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(394, 235);
            this.Controls.Add(this.CPanel_Login);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "中证宝 - 登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.CPanel_Login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinTextBox txt_password;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinGroupBox gboxLogin;
        private CCWin.SkinControl.SkinCaptionPanel CPanel_Login;
        private CCWin.SkinControl.SkinTextBox txt_id;
        private CCWin.SkinControl.SkinButton btn_login;
    }
}
namespace Citric.MyForms
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.TextBox txb_Login;
        private System.Windows.Forms.TextBox txb_Capt;
        private System.Windows.Forms.PictureBox pic_Capt;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Capt;
        private System.Windows.Forms.Button btn_cptAud;
        private System.Windows.Forms.PictureBox pic_Close;
        private System.Windows.Forms.Label lbl_Note;



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.btn_cptAud = new System.Windows.Forms.Button();
            this.lbl_Capt = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txb_Capt = new System.Windows.Forms.TextBox();
            this.pic_Capt = new System.Windows.Forms.PictureBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.txb_Login = new System.Windows.Forms.TextBox();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Capt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Login.Controls.Add(this.lbl_Note);
            this.pnl_Login.Controls.Add(this.btn_cptAud);
            this.pnl_Login.Controls.Add(this.lbl_Capt);
            this.pnl_Login.Controls.Add(this.btn_Refresh);
            this.pnl_Login.Controls.Add(this.txb_Capt);
            this.pnl_Login.Controls.Add(this.pic_Capt);
            this.pnl_Login.Controls.Add(this.lbl_Senha);
            this.pnl_Login.Controls.Add(this.lbl_Login);
            this.pnl_Login.Controls.Add(this.btn_Entrar);
            this.pnl_Login.Controls.Add(this.txb_Senha);
            this.pnl_Login.Controls.Add(this.txb_Login);
            this.pnl_Login.Location = new System.Drawing.Point(306, 97);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(293, 115);
            this.pnl_Login.TabIndex = 0;
            // 
            // lbl_Note
            // 
            this.lbl_Note.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Note.Location = new System.Drawing.Point(3, 93);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(278, 15);
            this.lbl_Note.TabIndex = 9;
            this.lbl_Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cptAud
            // 
            this.btn_cptAud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cptAud.Enabled = false;
            this.btn_cptAud.Location = new System.Drawing.Point(247, 67);
            this.btn_cptAud.Name = "btn_cptAud";
            this.btn_cptAud.Size = new System.Drawing.Size(34, 23);
            this.btn_cptAud.TabIndex = 6;
            this.btn_cptAud.Text = "♪";
            this.btn_cptAud.UseVisualStyleBackColor = true;
            // 
            // lbl_Capt
            // 
            this.lbl_Capt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Capt.Location = new System.Drawing.Point(3, 72);
            this.lbl_Capt.Name = "lbl_Capt";
            this.lbl_Capt.Size = new System.Drawing.Size(50, 17);
            this.lbl_Capt.TabIndex = 7;
            this.lbl_Capt.Text = "Captcha:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Location = new System.Drawing.Point(206, 68);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(36, 20);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "↻";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.ButtonRefreshClick);
            // 
            // txb_Capt
            // 
            this.txb_Capt.Location = new System.Drawing.Point(57, 69);
            this.txb_Capt.MaxLength = 10000;
            this.txb_Capt.Name = "txb_Capt";
            this.txb_Capt.Size = new System.Drawing.Size(79, 20);
            this.txb_Capt.TabIndex = 3;
            this.txb_Capt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_Capt
            // 
            this.pic_Capt.Location = new System.Drawing.Point(142, 69);
            this.pic_Capt.Name = "pic_Capt";
            this.pic_Capt.Size = new System.Drawing.Size(58, 20);
            this.pic_Capt.TabIndex = 4;
            this.pic_Capt.TabStop = false;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Location = new System.Drawing.Point(3, 46);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(48, 17);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.Location = new System.Drawing.Point(3, 20);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(40, 18);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login:";
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Entrar.Location = new System.Drawing.Point(206, 17);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 46);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.ButtonEntrarClick);
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(57, 43);
            this.txb_Senha.MaxLength = 256;
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.PasswordChar = '*';
            this.txb_Senha.Size = new System.Drawing.Size(143, 20);
            this.txb_Senha.TabIndex = 2;
            this.txb_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Login
            // 
            this.txb_Login.Location = new System.Drawing.Point(57, 17);
            this.txb_Login.MaxLength = 256;
            this.txb_Login.Name = "txb_Login";
            this.txb_Login.Size = new System.Drawing.Size(143, 20);
            this.txb_Login.TabIndex = 1;
            this.txb_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_Close
            // 
            this.pic_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Close.BackColor = System.Drawing.Color.Transparent;
            this.pic_Close.BackgroundImage = global::Citric.Properties.Resources.close;
            this.pic_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Close.Location = new System.Drawing.Point(643, 12);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(30, 30);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Close.TabIndex = 2;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Citric.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 293);
            this.Controls.Add(this.pic_Close);
            this.Controls.Add(this.pnl_Login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citric";
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Capt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
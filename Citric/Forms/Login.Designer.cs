/*
 * Created by SharpDevelop.
 * User: Matt
 * Date: 26/05/2018
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace citric.Forms
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label LabSenha;
		private System.Windows.Forms.Label LabLogin;
		private System.Windows.Forms.Button ButtonEntrar;
		private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxCaptcha;
		private System.Windows.Forms.PictureBox pictureBoxCaptcha;
		private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labCaptcha;
        private System.Windows.Forms.Button buttonCptAud;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCptAud = new System.Windows.Forms.Button();
            this.labCaptcha = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.LabSenha = new System.Windows.Forms.Label();
            this.LabLogin = new System.Windows.Forms.Label();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelNote);
            this.panel1.Controls.Add(this.buttonCptAud);
            this.panel1.Controls.Add(this.labCaptcha);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.textBoxCaptcha);
            this.panel1.Controls.Add(this.pictureBoxCaptcha);
            this.panel1.Controls.Add(this.LabSenha);
            this.panel1.Controls.Add(this.LabLogin);
            this.panel1.Controls.Add(this.ButtonEntrar);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Location = new System.Drawing.Point(306, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 115);
            this.panel1.TabIndex = 0;
            // 
            // buttonCptAud
            // 
            this.buttonCptAud.Enabled = false;
            this.buttonCptAud.Location = new System.Drawing.Point(247, 67);
            this.buttonCptAud.Name = "buttonCptAud";
            this.buttonCptAud.Size = new System.Drawing.Size(34, 23);
            this.buttonCptAud.TabIndex = 6;
            this.buttonCptAud.Text = "♪";
            this.buttonCptAud.UseVisualStyleBackColor = true;
            // 
            // labCaptcha
            // 
            this.labCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.labCaptcha.Location = new System.Drawing.Point(3, 72);
            this.labCaptcha.Name = "labCaptcha";
            this.labCaptcha.Size = new System.Drawing.Size(50, 17);
            this.labCaptcha.TabIndex = 7;
            this.labCaptcha.Text = "Captcha:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(206, 68);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(36, 20);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "↻";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefreshClick);
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(57, 69);
            this.textBoxCaptcha.MaxLength = 10000;
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(79, 20);
            this.textBoxCaptcha.TabIndex = 3;
            this.textBoxCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(142, 69);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(58, 20);
            this.pictureBoxCaptcha.TabIndex = 4;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // LabSenha
            // 
            this.LabSenha.Location = new System.Drawing.Point(3, 46);
            this.LabSenha.Name = "LabSenha";
            this.LabSenha.Size = new System.Drawing.Size(48, 17);
            this.LabSenha.TabIndex = 1;
            this.LabSenha.Text = "Senha:";
            // 
            // LabLogin
            // 
            this.LabLogin.Location = new System.Drawing.Point(3, 20);
            this.LabLogin.Name = "LabLogin";
            this.LabLogin.Size = new System.Drawing.Size(40, 18);
            this.LabLogin.TabIndex = 3;
            this.LabLogin.Text = "Login:";
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonEntrar.Location = new System.Drawing.Point(206, 17);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(75, 46);
            this.ButtonEntrar.TabIndex = 4;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = false;
            this.ButtonEntrar.Click += new System.EventHandler(this.ButtonEntrarClick);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(57, 43);
            this.textBoxSenha.MaxLength = 256;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(143, 20);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(57, 17);
            this.textBoxLogin.MaxLength = 256;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(143, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::citric.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(643, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelNote
            // 
            this.labelNote.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelNote.Location = new System.Drawing.Point(3, 93);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(278, 15);
            this.labelNote.TabIndex = 9;
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::citric.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citric";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNote;
	}
}

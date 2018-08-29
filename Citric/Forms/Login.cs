
using System;
using System.Drawing;
using System.Windows.Forms;

namespace citric.Forms
{
	public partial class Login : Form
	{
		
		//abaixo estão os atributos básicos desse form. São apenas para verificação e teste inicial de login 
		int cpt;
		private string login;
		private string senha;
		private string cptval;
		
		//Esse é o método de renderização do captcha.
		//randomizamos um numero e colocamos dentro de uma váriavel (cpt). Para validação do captcha no form, converte-se
		//para string em outra variável (cptval).
		//são criadas 3 variaveis, uma de bitmap que controla a geração da imagem, uma de fonte, onde se define
		//as propriedades da fonte e outra que recebe as propriedades da variavel de bitmap.
		//após isso, utilizando o método DrawString, embasado nas propriedades que definimos, ele desenha dentro do
		//pictureBox a imagem, randomizando a cada vez que for chamado.
		private void loadCaptchaImg()
		{
			Random Rdm = new Random();
			cpt = Rdm.Next(100, 10000);
			cptval = Convert.ToString(cpt);
			var img = new Bitmap(this.pictureBoxCaptcha.Width, this.pictureBoxCaptcha.Height);
			var font = new Font ("Calibri", 16, FontStyle.Bold, GraphicsUnit.Pixel);
			var graph = Graphics.FromImage(img);
			graph.DrawString(cpt.ToString(), font, Brushes.CadetBlue, new Point (0, 0));
			pictureBoxCaptcha.Image = img;
		}
		
		//abaixo inicia-se o form, se dá valor as variaveis de autenticação para teste e chamamos o 
		//método para carregar o captcha
		public Login()
		{

			InitializeComponent();
			loadCaptchaImg();
			login = "";
			senha = "";
			
		}
		
		//botão de atualização do captcha
		void ButtonRefreshClick(object sender, EventArgs e)
		{
			loadCaptchaImg();
		}
		
		//ao clicar nesse botao, ele realiza a verificação se o que está escrito nos devidos Text Box 
		//batem com o atributo de validação. Se estiver correto, este form fica invisível e o form MainWorkSt 
		//é chamado. Se não estiver correto, os campos são limpos e uma mensagem de erro é exibida, além de
		//ser gerado novo captcha
		void ButtonEntrarClick(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == login && textBoxSenha.Text == senha && textBoxCaptcha.Text == cptval)
			{
				loadCaptchaImg();
				textBoxLogin.Text = "";
				textBoxSenha.Text = "";
				textBoxCaptcha.Text = "";
				this.Visible = false;
				citric.Forms.MainScreen MainScreen = new citric.Forms.MainScreen();
				MainScreen.ShowDialog();
			}
			else
			{
				loadCaptchaImg();
				textBoxLogin.Text = "";
				textBoxSenha.Text = "";
				textBoxCaptcha.Text = "";
				labelNote.Text = "Entrada inválida, tente novamente!";
			}
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citric.MyForms
{
    public partial class frm_Login : Form
    {
		//abaixo estão os atributos básicos desse form. São apenas para verificação e teste inicial de login 
		private int cpt;
		private string login;
		private string senha;
		private string cptval;

        //declaração das classes em seus objetos
        MyForms.frm_mainScreen frm_mainScreen;
		
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
			var img = new Bitmap(this.pic_Capt.Width, this.pic_Capt.Height);
			var font = new Font ("Calibri", 16, FontStyle.Bold, GraphicsUnit.Pixel);
			var graph = Graphics.FromImage(img);
			graph.DrawString(cpt.ToString(), font, Brushes.CadetBlue, new Point (0, 0));
			pic_Capt.Image = img;
		}
		
		//abaixo inicia-se o form, se dá valor as variaveis de autenticação para teste e chamamos o 
		//método para carregar o captcha
		public frm_Login()
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
			if (txb_Login.Text == login && txb_Senha.Text == senha && txb_Capt.Text == cptval)
			{
				loadCaptchaImg();
				txb_Login.Text = "";
				txb_Senha.Text = "";
				txb_Capt.Text = "";
				this.Visible = false;
				frm_mainScreen = new MyForms.frm_mainScreen();
				frm_mainScreen.ShowDialog();
			}
			else
			{
				loadCaptchaImg();
				txb_Login.Text = "";
				txb_Senha.Text = "";
				txb_Capt.Text = "";
				lbl_Note.Text = "Entrada inválida, tente novamente!";
			}
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

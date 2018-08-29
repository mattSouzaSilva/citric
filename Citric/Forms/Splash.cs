/*
 * Created by SharpDevelop.
 * User: Matt
 * Date: 26/05/2018
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace citric
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Splash : Form
	{
		public Splash()
		{

			InitializeComponent();
			
		}
		
		//em cada pulso ele verifica o progresso. Ao chegar ao 100 ele mostra a tela de login e fecha esse form
		void SplashTimerTick(object sender, EventArgs e)
		{
			if (SplashProgBar.Value < 100)
			{
				SplashProgBar.Value = SplashProgBar.Value + 5;
			}
			else
			{
				SplashTimer.Enabled = false;
				this.Visible = false;
				citric.Forms.Login Login = new citric.Forms.Login();
				Login.ShowDialog();
				this.Close();
			}
		}
	}
}

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
    public partial class frm_Splash : Form
    {

        MyForms.frm_Login frm_Login;
        public frm_Splash()
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
                MyForms.frm_Login frm_Login;
                SplashTimer.Enabled = false;
                this.Visible = false;
                frm_Login = new MyForms.frm_Login();
                frm_Login.ShowDialog();
                this.Close();
            }
        }
    }
}

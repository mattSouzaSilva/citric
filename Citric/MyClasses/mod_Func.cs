using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citric
{
    class mod_Func
    {
        protected int id_func;
        protected string nome;
        protected string login;
        protected string senha;
        protected int status; //1 = ativo, 0 = inativo
    }

    class ctr_Func : mod_Func
    {
        public int inserir(string frm_nome, string frm_login, string frm_senha)
        {
            if (frm_nome != "" && frm_login != "" && frm_senha != "")
            {
                nome = frm_nome;
                login = frm_login;
                senha = frm_senha;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int alterar(string frm_nome, string frm_login, string frm_senha)
        {
            if (frm_nome != "" && frm_login != "" && frm_senha != "")
            {
                nome = frm_nome;
                login = frm_login;
                senha = frm_senha;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /*public object consultar()
        {

        }*/
        public int desativar(int frm_id)
        {
            if (frm_id == id_func)
            {
                status = 0;
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

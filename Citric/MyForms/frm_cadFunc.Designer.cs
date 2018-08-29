namespace Citric.MyForms
{
    partial class frm_cadFunc
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
            this.txb_Cod = new System.Windows.Forms.TextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Login = new System.Windows.Forms.TextBox();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Alt = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Cod
            // 
            this.txb_Cod.Location = new System.Drawing.Point(359, 13);
            this.txb_Cod.Name = "txb_Cod";
            this.txb_Cod.Size = new System.Drawing.Size(249, 20);
            this.txb_Cod.TabIndex = 2;
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(359, 63);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(249, 20);
            this.txb_Nome.TabIndex = 2;
            // 
            // txb_Login
            // 
            this.txb_Login.Location = new System.Drawing.Point(359, 116);
            this.txb_Login.Name = "txb_Login";
            this.txb_Login.Size = new System.Drawing.Size(249, 20);
            this.txb_Login.TabIndex = 2;
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(359, 166);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.Size = new System.Drawing.Size(249, 20);
            this.txb_Senha.TabIndex = 2;
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Location = new System.Drawing.Point(249, 16);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(43, 13);
            this.lbl_Cod.TabIndex = 3;
            this.lbl_Cod.Text = "Código:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(249, 66);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(249, 119);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(36, 13);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(249, 169);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha:";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(12, 14);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(220, 58);
            this.btn_Novo.TabIndex = 4;
            this.btn_Novo.Text = "Inserir Novo Funcionário";
            this.btn_Novo.UseVisualStyleBackColor = true;
            // 
            // btn_Alt
            // 
            this.btn_Alt.Location = new System.Drawing.Point(12, 78);
            this.btn_Alt.Name = "btn_Alt";
            this.btn_Alt.Size = new System.Drawing.Size(220, 58);
            this.btn_Alt.TabIndex = 5;
            this.btn_Alt.Text = "Alterar Cadastro";
            this.btn_Alt.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(12, 142);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(220, 58);
            this.btn_Del.TabIndex = 6;
            this.btn_Del.Text = "Desativar Funcionário";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nome,
            this.login});
            this.dgv_Clientes.Location = new System.Drawing.Point(12, 219);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.Size = new System.Drawing.Size(596, 150);
            this.dgv_Clientes.TabIndex = 7;
            // 
            // cod
            // 
            this.cod.HeaderText = "Código";
            this.cod.Name = "cod";
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            // 
            // frm_cadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(199)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(620, 383);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Alt);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.txb_Login);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.txb_Cod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cadFunc";
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Cod;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Login;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Alt;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
    }
}
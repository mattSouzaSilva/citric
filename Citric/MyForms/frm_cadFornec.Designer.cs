namespace Citric.MyForms
{
    partial class frm_cadFornec
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
            this.txb_Cat = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Cat = new System.Windows.Forms.Label();
            this.lbl_Descr = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Alt = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Descr = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.txb_Contato = new System.Windows.Forms.TextBox();
            this.lbl_Contato = new System.Windows.Forms.Label();
            this.dgv_Fornec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fornec)).BeginInit();
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
            this.txb_Nome.Location = new System.Drawing.Point(359, 49);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(249, 20);
            this.txb_Nome.TabIndex = 2;
            // 
            // txb_Cat
            // 
            this.txb_Cat.Location = new System.Drawing.Point(359, 84);
            this.txb_Cat.Name = "txb_Cat";
            this.txb_Cat.Size = new System.Drawing.Size(135, 20);
            this.txb_Cat.TabIndex = 2;
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
            this.lbl_Nome.Location = new System.Drawing.Point(249, 52);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Cat
            // 
            this.lbl_Cat.AutoSize = true;
            this.lbl_Cat.Location = new System.Drawing.Point(249, 87);
            this.lbl_Cat.Name = "lbl_Cat";
            this.lbl_Cat.Size = new System.Drawing.Size(65, 13);
            this.lbl_Cat.TabIndex = 3;
            this.lbl_Cat.Text = "CPF | CNPJ:";
            // 
            // lbl_Descr
            // 
            this.lbl_Descr.AutoSize = true;
            this.lbl_Descr.Location = new System.Drawing.Point(249, 211);
            this.lbl_Descr.Name = "lbl_Descr";
            this.lbl_Descr.Size = new System.Drawing.Size(58, 13);
            this.lbl_Descr.TabIndex = 3;
            this.lbl_Descr.Text = "Descrição:";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(12, 14);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(220, 58);
            this.btn_Novo.TabIndex = 4;
            this.btn_Novo.Text = "Inserir Novo Fornecedor";
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
            this.btn_Del.Text = "Excluir Fornecedor";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(249, 152);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-mail:";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(359, 149);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(249, 20);
            this.txb_Email.TabIndex = 2;
            // 
            // txb_Descr
            // 
            this.txb_Descr.Location = new System.Drawing.Point(359, 211);
            this.txb_Descr.Multiline = true;
            this.txb_Descr.Name = "txb_Descr";
            this.txb_Descr.Size = new System.Drawing.Size(249, 48);
            this.txb_Descr.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cidade:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(502, 118);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_Estado.TabIndex = 3;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(506, 87);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_Tipo.TabIndex = 3;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Items.AddRange(new object[] {
            "PF",
            "PJ"});
            this.cbx_Tipo.Location = new System.Drawing.Point(551, 84);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(57, 21);
            this.cbx_Tipo.TabIndex = 7;
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(551, 118);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(57, 21);
            this.cbx_Estado.TabIndex = 7;
            // 
            // txb_Contato
            // 
            this.txb_Contato.Location = new System.Drawing.Point(359, 182);
            this.txb_Contato.Name = "txb_Contato";
            this.txb_Contato.Size = new System.Drawing.Size(249, 20);
            this.txb_Contato.TabIndex = 2;
            // 
            // lbl_Contato
            // 
            this.lbl_Contato.AutoSize = true;
            this.lbl_Contato.Location = new System.Drawing.Point(249, 185);
            this.lbl_Contato.Name = "lbl_Contato";
            this.lbl_Contato.Size = new System.Drawing.Size(47, 13);
            this.lbl_Contato.TabIndex = 3;
            this.lbl_Contato.Text = "Contato:";
            // 
            // dgv_Fornec
            // 
            this.dgv_Fornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fornec.Location = new System.Drawing.Point(14, 275);
            this.dgv_Fornec.Name = "dgv_Fornec";
            this.dgv_Fornec.Size = new System.Drawing.Size(594, 117);
            this.dgv_Fornec.TabIndex = 8;
            // 
            // frm_cadFornec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(199)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(620, 401);
            this.Controls.Add(this.dgv_Fornec);
            this.Controls.Add(this.cbx_Estado);
            this.Controls.Add(this.cbx_Tipo);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Alt);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Contato);
            this.Controls.Add(this.lbl_Descr);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Cat);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.txb_Descr);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_Contato);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txb_Cat);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.txb_Cod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cadFornec";
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fornec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Cod;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Cat;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Cat;
        private System.Windows.Forms.Label lbl_Descr;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Alt;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_Descr;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.TextBox txb_Contato;
        private System.Windows.Forms.Label lbl_Contato;
        private System.Windows.Forms.DataGridView dgv_Fornec;
    }
}
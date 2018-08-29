namespace Citric.MyForms
{
    partial class frm_mainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mns_Main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;

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
            this.mns_Main = new System.Windows.Forms.MenuStrip();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeFornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusDeRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairTelaDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Venda = new System.Windows.Forms.GroupBox();
            this.btn_Credito = new System.Windows.Forms.Button();
            this.btn_Debito = new System.Windows.Forms.Button();
            this.btn_Dinheiro = new System.Windows.Forms.Button();
            this.msk_Total = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.dgv_Venda = new System.Windows.Forms.DataGridView();
            this.id_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Prod = new System.Windows.Forms.GroupBox();
            this.lbl_Quant = new System.Windows.Forms.Label();
            this.lbl_Descr = new System.Windows.Forms.Label();
            this.lbl_CatPlat = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txb_Preco = new System.Windows.Forms.TextBox();
            this.txb_Quant = new System.Windows.Forms.TextBox();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.txb_Cod = new System.Windows.Forms.TextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Descr = new System.Windows.Forms.TextBox();
            this.pic_Venda = new System.Windows.Forms.PictureBox();
            this.txb_CatPlat = new System.Windows.Forms.TextBox();
            this.btn_NovaVenda = new System.Windows.Forms.Button();
            this.btn_CancelarVenda = new System.Windows.Forms.Button();
            this.lbl_Vend = new System.Windows.Forms.Label();
            this.lbl_NomeVend = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mns_Main.SuspendLayout();
            this.pnl_Venda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Venda)).BeginInit();
            this.pnl_Prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_Main
            // 
            this.mns_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.mns_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeClientesToolStripMenuItem,
            this.meuCadastroToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mns_Main.Location = new System.Drawing.Point(0, 0);
            this.mns_Main.Name = "mns_Main";
            this.mns_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mns_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mns_Main.Size = new System.Drawing.Size(1350, 24);
            this.mns_Main.TabIndex = 0;
            this.mns_Main.Text = "mst_Tools";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // meuCadastroToolStripMenuItem
            // 
            this.meuCadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeFuncionariosToolStripMenuItem,
            this.catálogoDeFornecedoresToolStripMenuItem1,
            this.estatísticasToolStripMenuItem1});
            this.meuCadastroToolStripMenuItem.Name = "meuCadastroToolStripMenuItem";
            this.meuCadastroToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.meuCadastroToolStripMenuItem.Text = "Gerenciamento Empresarial";
            // 
            // gerenciamentoDeFuncionariosToolStripMenuItem
            // 
            this.gerenciamentoDeFuncionariosToolStripMenuItem.Name = "gerenciamentoDeFuncionariosToolStripMenuItem";
            this.gerenciamentoDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gerenciamentoDeFuncionariosToolStripMenuItem.Text = "Gerenciamento de Funcionarios";
            this.gerenciamentoDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeFuncionariosToolStripMenuItem_Click);
            // 
            // catálogoDeFornecedoresToolStripMenuItem1
            // 
            this.catálogoDeFornecedoresToolStripMenuItem1.Name = "catálogoDeFornecedoresToolStripMenuItem1";
            this.catálogoDeFornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.catálogoDeFornecedoresToolStripMenuItem1.Text = "Catálogo de Fornecedores";
            this.catálogoDeFornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.catálogoDeFornecedoresToolStripMenuItem1_Click);
            // 
            // estatísticasToolStripMenuItem1
            // 
            this.estatísticasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.estatísticasToolStripMenuItem1.Name = "estatísticasToolStripMenuItem1";
            this.estatísticasToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.estatísticasToolStripMenuItem1.Text = "Estatísticas";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDeRedeToolStripMenuItem,
            this.sairTelaDeLoginToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // statusDeRedeToolStripMenuItem
            // 
            this.statusDeRedeToolStripMenuItem.Name = "statusDeRedeToolStripMenuItem";
            this.statusDeRedeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.statusDeRedeToolStripMenuItem.Text = "Status de Rede";
            // 
            // sairTelaDeLoginToolStripMenuItem
            // 
            this.sairTelaDeLoginToolStripMenuItem.Name = "sairTelaDeLoginToolStripMenuItem";
            this.sairTelaDeLoginToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sairTelaDeLoginToolStripMenuItem.Text = "Sair (Tela de Login)";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatenosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.licençaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // contatenosToolStripMenuItem
            // 
            this.contatenosToolStripMenuItem.Name = "contatenosToolStripMenuItem";
            this.contatenosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contatenosToolStripMenuItem.Text = "Contate-nos";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // licençaToolStripMenuItem
            // 
            this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
            this.licençaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licençaToolStripMenuItem.Text = "Licença";
            // 
            // pnl_Venda
            // 
            this.pnl_Venda.Controls.Add(this.btn_Credito);
            this.pnl_Venda.Controls.Add(this.btn_Debito);
            this.pnl_Venda.Controls.Add(this.btn_Dinheiro);
            this.pnl_Venda.Controls.Add(this.msk_Total);
            this.pnl_Venda.Controls.Add(this.lbl_Total);
            this.pnl_Venda.Controls.Add(this.dgv_Venda);
            this.pnl_Venda.ForeColor = System.Drawing.Color.Black;
            this.pnl_Venda.Location = new System.Drawing.Point(649, 30);
            this.pnl_Venda.Name = "pnl_Venda";
            this.pnl_Venda.Size = new System.Drawing.Size(689, 560);
            this.pnl_Venda.TabIndex = 2;
            this.pnl_Venda.TabStop = false;
            // 
            // btn_Credito
            // 
            this.btn_Credito.Location = new System.Drawing.Point(489, 380);
            this.btn_Credito.Name = "btn_Credito";
            this.btn_Credito.Size = new System.Drawing.Size(176, 153);
            this.btn_Credito.TabIndex = 5;
            this.btn_Credito.Text = "Crédito";
            this.btn_Credito.UseVisualStyleBackColor = true;
            // 
            // btn_Debito
            // 
            this.btn_Debito.Location = new System.Drawing.Point(271, 380);
            this.btn_Debito.Name = "btn_Debito";
            this.btn_Debito.Size = new System.Drawing.Size(176, 153);
            this.btn_Debito.TabIndex = 4;
            this.btn_Debito.Text = "Débito";
            this.btn_Debito.UseVisualStyleBackColor = true;
            // 
            // btn_Dinheiro
            // 
            this.btn_Dinheiro.Location = new System.Drawing.Point(41, 380);
            this.btn_Dinheiro.Name = "btn_Dinheiro";
            this.btn_Dinheiro.Size = new System.Drawing.Size(176, 153);
            this.btn_Dinheiro.TabIndex = 3;
            this.btn_Dinheiro.Text = "Dinheiro";
            this.btn_Dinheiro.UseVisualStyleBackColor = true;
            // 
            // msk_Total
            // 
            this.msk_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Total.Location = new System.Drawing.Point(438, 269);
            this.msk_Total.Mask = ",";
            this.msk_Total.Name = "msk_Total";
            this.msk_Total.ReadOnly = true;
            this.msk_Total.Size = new System.Drawing.Size(234, 31);
            this.msk_Total.TabIndex = 2;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(334, 271);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(104, 29);
            this.lbl_Total.TabIndex = 1;
            this.lbl_Total.Text = "TOTAL:";
            // 
            // dgv_Venda
            // 
            this.dgv_Venda.AllowUserToDeleteRows = false;
            this.dgv_Venda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Prod,
            this.nome,
            this.preco,
            this.quantidade});
            this.dgv_Venda.Location = new System.Drawing.Point(16, 22);
            this.dgv_Venda.Name = "dgv_Venda";
            this.dgv_Venda.ReadOnly = true;
            this.dgv_Venda.Size = new System.Drawing.Size(656, 234);
            this.dgv_Venda.TabIndex = 0;
            // 
            // id_Prod
            // 
            this.id_Prod.FillWeight = 247.8168F;
            this.id_Prod.HeaderText = "Código";
            this.id_Prod.Name = "id_Prod";
            this.id_Prod.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.FillWeight = 101.5229F;
            this.nome.HeaderText = "Nome do Produto";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.FillWeight = 25.33022F;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 80;
            // 
            // quantidade
            // 
            this.quantidade.FillWeight = 25.33022F;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 70;
            // 
            // pnl_Prod
            // 
            this.pnl_Prod.Controls.Add(this.lbl_Quant);
            this.pnl_Prod.Controls.Add(this.lbl_Descr);
            this.pnl_Prod.Controls.Add(this.lbl_CatPlat);
            this.pnl_Prod.Controls.Add(this.lbl_Nome);
            this.pnl_Prod.Controls.Add(this.txb_Preco);
            this.pnl_Prod.Controls.Add(this.txb_Quant);
            this.pnl_Prod.Controls.Add(this.lbl_Preco);
            this.pnl_Prod.Controls.Add(this.lbl_Cod);
            this.pnl_Prod.Controls.Add(this.txb_Cod);
            this.pnl_Prod.Controls.Add(this.txb_Nome);
            this.pnl_Prod.Controls.Add(this.txb_Descr);
            this.pnl_Prod.Controls.Add(this.pic_Venda);
            this.pnl_Prod.Controls.Add(this.txb_CatPlat);
            this.pnl_Prod.Location = new System.Drawing.Point(12, 30);
            this.pnl_Prod.Name = "pnl_Prod";
            this.pnl_Prod.Size = new System.Drawing.Size(631, 560);
            this.pnl_Prod.TabIndex = 3;
            this.pnl_Prod.TabStop = false;
            // 
            // lbl_Quant
            // 
            this.lbl_Quant.AutoSize = true;
            this.lbl_Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quant.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quant.Location = new System.Drawing.Point(427, 430);
            this.lbl_Quant.Name = "lbl_Quant";
            this.lbl_Quant.Size = new System.Drawing.Size(81, 13);
            this.lbl_Quant.TabIndex = 11;
            this.lbl_Quant.Text = "QUANTIDADE:";
            // 
            // lbl_Descr
            // 
            this.lbl_Descr.AutoSize = true;
            this.lbl_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descr.ForeColor = System.Drawing.Color.Black;
            this.lbl_Descr.Location = new System.Drawing.Point(288, 220);
            this.lbl_Descr.Name = "lbl_Descr";
            this.lbl_Descr.Size = new System.Drawing.Size(58, 13);
            this.lbl_Descr.TabIndex = 10;
            this.lbl_Descr.Text = "Descrição:";
            // 
            // lbl_CatPlat
            // 
            this.lbl_CatPlat.AutoSize = true;
            this.lbl_CatPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CatPlat.ForeColor = System.Drawing.Color.Black;
            this.lbl_CatPlat.Location = new System.Drawing.Point(288, 165);
            this.lbl_CatPlat.Name = "lbl_CatPlat";
            this.lbl_CatPlat.Size = new System.Drawing.Size(113, 13);
            this.lbl_CatPlat.TabIndex = 9;
            this.lbl_CatPlat.Text = "Categoria | Plataforma:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nome.Location = new System.Drawing.Point(288, 113);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 8;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txb_Preco
            // 
            this.txb_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Preco.Location = new System.Drawing.Point(288, 471);
            this.txb_Preco.Name = "txb_Preco";
            this.txb_Preco.ReadOnly = true;
            this.txb_Preco.Size = new System.Drawing.Size(337, 80);
            this.txb_Preco.TabIndex = 7;
            // 
            // txb_Quant
            // 
            this.txb_Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Quant.Location = new System.Drawing.Point(525, 422);
            this.txb_Quant.Name = "txb_Quant";
            this.txb_Quant.ReadOnly = true;
            this.txb_Quant.Size = new System.Drawing.Size(100, 26);
            this.txb_Quant.TabIndex = 6;
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco.ForeColor = System.Drawing.Color.Black;
            this.lbl_Preco.Location = new System.Drawing.Point(58, 471);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(218, 73);
            this.lbl_Preco.TabIndex = 5;
            this.lbl_Preco.Text = "Preço:";
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.lbl_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod.Location = new System.Drawing.Point(176, 22);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(277, 20);
            this.lbl_Cod.TabIndex = 4;
            this.lbl_Cod.Text = "Insira ou escaneie o código de barras:";
            // 
            // txb_Cod
            // 
            this.txb_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Cod.Location = new System.Drawing.Point(48, 47);
            this.txb_Cod.Name = "txb_Cod";
            this.txb_Cod.Size = new System.Drawing.Size(544, 35);
            this.txb_Cod.TabIndex = 3;
            this.txb_Cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Nome
            // 
            this.txb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Nome.Location = new System.Drawing.Point(288, 129);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.ReadOnly = true;
            this.txb_Nome.Size = new System.Drawing.Size(337, 26);
            this.txb_Nome.TabIndex = 2;
            // 
            // txb_Descr
            // 
            this.txb_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Descr.Location = new System.Drawing.Point(288, 236);
            this.txb_Descr.Multiline = true;
            this.txb_Descr.Name = "txb_Descr";
            this.txb_Descr.ReadOnly = true;
            this.txb_Descr.Size = new System.Drawing.Size(337, 175);
            this.txb_Descr.TabIndex = 0;
            // 
            // pic_Venda
            // 
            this.pic_Venda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Venda.Location = new System.Drawing.Point(6, 113);
            this.pic_Venda.Name = "pic_Venda";
            this.pic_Venda.Size = new System.Drawing.Size(276, 335);
            this.pic_Venda.TabIndex = 1;
            this.pic_Venda.TabStop = false;
            // 
            // txb_CatPlat
            // 
            this.txb_CatPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CatPlat.Location = new System.Drawing.Point(288, 181);
            this.txb_CatPlat.Name = "txb_CatPlat";
            this.txb_CatPlat.ReadOnly = true;
            this.txb_CatPlat.Size = new System.Drawing.Size(337, 26);
            this.txb_CatPlat.TabIndex = 0;
            // 
            // btn_NovaVenda
            // 
            this.btn_NovaVenda.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_NovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaVenda.Location = new System.Drawing.Point(649, 605);
            this.btn_NovaVenda.Name = "btn_NovaVenda";
            this.btn_NovaVenda.Size = new System.Drawing.Size(424, 113);
            this.btn_NovaVenda.TabIndex = 4;
            this.btn_NovaVenda.Text = "Iniciar Venda";
            this.btn_NovaVenda.UseVisualStyleBackColor = false;
            // 
            // btn_CancelarVenda
            // 
            this.btn_CancelarVenda.BackColor = System.Drawing.Color.Silver;
            this.btn_CancelarVenda.Enabled = false;
            this.btn_CancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarVenda.Location = new System.Drawing.Point(1087, 605);
            this.btn_CancelarVenda.Name = "btn_CancelarVenda";
            this.btn_CancelarVenda.Size = new System.Drawing.Size(251, 113);
            this.btn_CancelarVenda.TabIndex = 5;
            this.btn_CancelarVenda.Text = "Cancelar";
            this.btn_CancelarVenda.UseVisualStyleBackColor = false;
            // 
            // lbl_Vend
            // 
            this.lbl_Vend.AutoSize = true;
            this.lbl_Vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vend.ForeColor = System.Drawing.Color.Black;
            this.lbl_Vend.Location = new System.Drawing.Point(14, 647);
            this.lbl_Vend.Name = "lbl_Vend";
            this.lbl_Vend.Size = new System.Drawing.Size(100, 24);
            this.lbl_Vend.TabIndex = 6;
            this.lbl_Vend.Text = "Vendedor:";
            // 
            // lbl_NomeVend
            // 
            this.lbl_NomeVend.AutoSize = true;
            this.lbl_NomeVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeVend.ForeColor = System.Drawing.Color.Black;
            this.lbl_NomeVend.Location = new System.Drawing.Point(129, 647);
            this.lbl_NomeVend.Name = "lbl_NomeVend";
            this.lbl_NomeVend.Size = new System.Drawing.Size(16, 24);
            this.lbl_NomeVend.TabIndex = 7;
            this.lbl_NomeVend.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(199)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.lbl_NomeVend);
            this.Controls.Add(this.lbl_Vend);
            this.Controls.Add(this.btn_CancelarVenda);
            this.Controls.Add(this.btn_NovaVenda);
            this.Controls.Add(this.pnl_Prod);
            this.Controls.Add(this.pnl_Venda);
            this.Controls.Add(this.mns_Main);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.mns_Main;
            this.Name = "frm_mainScreen";
            this.Text = "Citric - Gaming Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mns_Main.ResumeLayout(false);
            this.mns_Main.PerformLayout();
            this.pnl_Venda.ResumeLayout(false);
            this.pnl_Venda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Venda)).EndInit();
            this.pnl_Prod.ResumeLayout(false);
            this.pnl_Prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.GroupBox pnl_Venda;
        private System.Windows.Forms.GroupBox pnl_Prod;
        private System.Windows.Forms.DataGridView dgv_Venda;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.TextBox txb_Cod;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Descr;
        private System.Windows.Forms.PictureBox pic_Venda;
        private System.Windows.Forms.TextBox txb_CatPlat;
        private System.Windows.Forms.Button btn_NovaVenda;
        private System.Windows.Forms.Button btn_CancelarVenda;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.MaskedTextBox msk_Total;
        private System.Windows.Forms.Label lbl_Quant;
        private System.Windows.Forms.Label lbl_Descr;
        private System.Windows.Forms.Label lbl_CatPlat;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txb_Preco;
        private System.Windows.Forms.TextBox txb_Quant;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.Label lbl_Vend;
        private System.Windows.Forms.Label lbl_NomeVend;
        private System.Windows.Forms.Button btn_Credito;
        private System.Windows.Forms.Button btn_Debito;
        private System.Windows.Forms.Button btn_Dinheiro;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoDeFornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusDeRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairTelaDeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}
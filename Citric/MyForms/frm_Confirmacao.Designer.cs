namespace Citric.MyForms
{
    partial class frm_Confirmacao
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
            this.btn_Sim = new System.Windows.Forms.Button();
            this.btn_Nao = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sim
            // 
            this.btn_Sim.Location = new System.Drawing.Point(16, 62);
            this.btn_Sim.Name = "btn_Sim";
            this.btn_Sim.Size = new System.Drawing.Size(136, 67);
            this.btn_Sim.TabIndex = 0;
            this.btn_Sim.Text = "Sim";
            this.btn_Sim.UseVisualStyleBackColor = true;
            // 
            // btn_Nao
            // 
            this.btn_Nao.Location = new System.Drawing.Point(158, 62);
            this.btn_Nao.Name = "btn_Nao";
            this.btn_Nao.Size = new System.Drawing.Size(136, 67);
            this.btn_Nao.TabIndex = 0;
            this.btn_Nao.Text = "Não";
            this.btn_Nao.UseVisualStyleBackColor = true;
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(67, 33);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(167, 13);
            this.lbl_Texto.TabIndex = 1;
            this.lbl_Texto.Text = "Deseja mesmo completar a ação?";
            // 
            // frm_Confirmacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(310, 146);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.btn_Nao);
            this.Controls.Add(this.btn_Sim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Confirmacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sim;
        private System.Windows.Forms.Button btn_Nao;
        private System.Windows.Forms.Label lbl_Texto;
    }
}
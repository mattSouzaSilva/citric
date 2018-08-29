namespace Citric.MyForms
{
    partial class frm_Sucesso
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
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(70, 45);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(167, 13);
            this.lbl_Texto.TabIndex = 1;
            this.lbl_Texto.Text = "Operação realizada com sucesso!";
            // 
            // btn_Okay
            // 
            this.btn_Okay.Location = new System.Drawing.Point(102, 74);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(107, 50);
            this.btn_Okay.TabIndex = 2;
            this.btn_Okay.Text = "Okay";
            this.btn_Okay.UseVisualStyleBackColor = true;
            // 
            // frm_Sucesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(310, 146);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.lbl_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Sucesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Button btn_Okay;
    }
}
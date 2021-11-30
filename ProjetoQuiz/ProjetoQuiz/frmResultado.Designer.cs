
namespace ProjetoQuiz
{
    partial class frmResultado
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
            this.PainelBaixo = new System.Windows.Forms.Panel();
            this.PainelDetalhe = new System.Windows.Forms.Panel();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblAcerto = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.PainelCima = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.PainelDetalhe.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.PainelCima.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelBaixo
            // 
            this.PainelBaixo.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PainelBaixo.Location = new System.Drawing.Point(0, 442);
            this.PainelBaixo.Name = "PainelBaixo";
            this.PainelBaixo.Size = new System.Drawing.Size(751, 37);
            this.PainelBaixo.TabIndex = 33;
            // 
            // PainelDetalhe
            // 
            this.PainelDetalhe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PainelDetalhe.Controls.Add(this.pnlCentro);
            this.PainelDetalhe.Controls.Add(this.PainelCima);
            this.PainelDetalhe.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelDetalhe.Location = new System.Drawing.Point(0, 0);
            this.PainelDetalhe.Name = "PainelDetalhe";
            this.PainelDetalhe.Size = new System.Drawing.Size(751, 347);
            this.PainelDetalhe.TabIndex = 32;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlCentro.Controls.Add(this.lblErro);
            this.pnlCentro.Controls.Add(this.lblAcertos);
            this.pnlCentro.Controls.Add(this.lblAcerto);
            this.pnlCentro.Controls.Add(this.lblErros);
            this.pnlCentro.Location = new System.Drawing.Point(235, 108);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(297, 172);
            this.pnlCentro.TabIndex = 6;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.White;
            this.lblErro.Location = new System.Drawing.Point(216, 93);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(46, 59);
            this.lblErro.TabIndex = 6;
            this.lblErro.Text = "0";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.ForeColor = System.Drawing.Color.Lime;
            this.lblAcertos.Location = new System.Drawing.Point(36, 16);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(169, 59);
            this.lblAcertos.TabIndex = 3;
            this.lblAcertos.Text = "Acertos: ";
            // 
            // lblAcerto
            // 
            this.lblAcerto.AutoSize = true;
            this.lblAcerto.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcerto.ForeColor = System.Drawing.Color.White;
            this.lblAcerto.Location = new System.Drawing.Point(216, 16);
            this.lblAcerto.Name = "lblAcerto";
            this.lblAcerto.Size = new System.Drawing.Size(46, 59);
            this.lblAcerto.TabIndex = 5;
            this.lblAcerto.Text = "0";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.ForeColor = System.Drawing.Color.Brown;
            this.lblErros.Location = new System.Drawing.Point(36, 93);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(137, 59);
            this.lblErros.TabIndex = 4;
            this.lblErros.Text = "Erros: ";
            // 
            // PainelCima
            // 
            this.PainelCima.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelCima.Controls.Add(this.btnX);
            this.PainelCima.Controls.Add(this.lblResultado);
            this.PainelCima.Location = new System.Drawing.Point(0, 0);
            this.PainelCima.Name = "PainelCima";
            this.PainelCima.Size = new System.Drawing.Size(751, 62);
            this.PainelCima.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(718, 1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(32, 27);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(313, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(149, 44);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultados";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(407, 373);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 47);
            this.btnFechar.TabIndex = 34;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(261, 373);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(101, 47);
            this.btnReiniciar.TabIndex = 35;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.PainelBaixo);
            this.Controls.Add(this.PainelDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultado";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            this.PainelDetalhe.ResumeLayout(false);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.PainelCima.ResumeLayout(false);
            this.PainelCima.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelBaixo;
        private System.Windows.Forms.Panel PainelDetalhe;
        private System.Windows.Forms.Panel PainelCima;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblAcerto;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

namespace ProjetoQuiz
{
    partial class frmQuiz
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.PainelDetalhe = new System.Windows.Forms.Panel();
            this.PainelCima = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblMundo = new System.Windows.Forms.Label();
            this.PainelBaixo = new System.Windows.Forms.Panel();
            this.btnTemas = new System.Windows.Forms.Button();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.PainelDetalhe.SuspendLayout();
            this.PainelCima.SuspendLayout();
            this.PainelBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelDetalhe
            // 
            this.PainelDetalhe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PainelDetalhe.Controls.Add(this.PainelCima);
            this.PainelDetalhe.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelDetalhe.Location = new System.Drawing.Point(0, 0);
            this.PainelDetalhe.Name = "PainelDetalhe";
            this.PainelDetalhe.Size = new System.Drawing.Size(751, 88);
            this.PainelDetalhe.TabIndex = 0;
            // 
            // PainelCima
            // 
            this.PainelCima.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelCima.Controls.Add(this.btnX);
            this.PainelCima.Controls.Add(this.lblMundo);
            this.PainelCima.Location = new System.Drawing.Point(0, 0);
            this.PainelCima.Name = "PainelCima";
            this.PainelCima.Size = new System.Drawing.Size(751, 73);
            this.PainelCima.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
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
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblMundo
            // 
            this.lblMundo.AutoSize = true;
            this.lblMundo.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMundo.ForeColor = System.Drawing.Color.White;
            this.lblMundo.Location = new System.Drawing.Point(245, 17);
            this.lblMundo.Name = "lblMundo";
            this.lblMundo.Size = new System.Drawing.Size(275, 44);
            this.lblMundo.TabIndex = 0;
            this.lblMundo.Text = "Mundo Pós-Pandemia";
            // 
            // PainelBaixo
            // 
            this.PainelBaixo.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelBaixo.Controls.Add(this.btnTemas);
            this.PainelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PainelBaixo.Location = new System.Drawing.Point(0, 416);
            this.PainelBaixo.Name = "PainelBaixo";
            this.PainelBaixo.Size = new System.Drawing.Size(751, 63);
            this.PainelBaixo.TabIndex = 1;
            // 
            // btnTemas
            // 
            this.btnTemas.BackColor = System.Drawing.Color.Transparent;
            this.btnTemas.FlatAppearance.BorderSize = 0;
            this.btnTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemas.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemas.ForeColor = System.Drawing.Color.White;
            this.btnTemas.Location = new System.Drawing.Point(670, 0);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Size = new System.Drawing.Size(81, 63);
            this.btnTemas.TabIndex = 6;
            this.btnTemas.Text = "Temas";
            this.btnTemas.UseVisualStyleBackColor = false;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.Font = new System.Drawing.Font("Bruzh", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz.Location = new System.Drawing.Point(311, 162);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(134, 71);
            this.lblQuiz.TabIndex = 2;
            this.lblQuiz.Text = "Quiz";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(210, 290);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(142, 70);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(396, 290);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(142, 70);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.PainelBaixo);
            this.Controls.Add(this.PainelDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PainelDetalhe.ResumeLayout(false);
            this.PainelCima.ResumeLayout(false);
            this.PainelCima.PerformLayout();
            this.PainelBaixo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelDetalhe;
        private System.Windows.Forms.Panel PainelBaixo;
        private System.Windows.Forms.Panel PainelCima;
        private System.Windows.Forms.Label lblMundo;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnTemas;
    }
}


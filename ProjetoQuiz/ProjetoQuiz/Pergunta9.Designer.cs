
namespace ProjetoQuiz
{
    partial class frmPergunta9
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
            this.PainelCima = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.PainelDireita = new System.Windows.Forms.Panel();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnUni = new System.Windows.Forms.Button();
            this.radRes4 = new System.Windows.Forms.RadioButton();
            this.radRes3 = new System.Windows.Forms.RadioButton();
            this.radRes2 = new System.Windows.Forms.RadioButton();
            this.radRes1 = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnProx = new System.Windows.Forms.Button();
            this.PainelDetalhe.SuspendLayout();
            this.PainelCima.SuspendLayout();
            this.PainelDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelBaixo
            // 
            this.PainelBaixo.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PainelBaixo.Location = new System.Drawing.Point(0, 442);
            this.PainelBaixo.Name = "PainelBaixo";
            this.PainelBaixo.Size = new System.Drawing.Size(751, 37);
            this.PainelBaixo.TabIndex = 24;
            // 
            // PainelDetalhe
            // 
            this.PainelDetalhe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PainelDetalhe.Controls.Add(this.PainelCima);
            this.PainelDetalhe.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelDetalhe.Location = new System.Drawing.Point(0, 0);
            this.PainelDetalhe.Name = "PainelDetalhe";
            this.PainelDetalhe.Size = new System.Drawing.Size(751, 77);
            this.PainelDetalhe.TabIndex = 23;
            // 
            // PainelCima
            // 
            this.PainelCima.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelCima.Controls.Add(this.btnX);
            this.PainelCima.Controls.Add(this.lblQuestao);
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
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.ForeColor = System.Drawing.Color.White;
            this.lblQuestao.Location = new System.Drawing.Point(12, 9);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(139, 44);
            this.lblQuestao.TabIndex = 0;
            this.lblQuestao.Text = "Questão 9";
            // 
            // PainelDireita
            // 
            this.PainelDireita.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PainelDireita.Controls.Add(this.btnPular);
            this.PainelDireita.Controls.Add(this.btnApagar);
            this.PainelDireita.Controls.Add(this.btnUni);
            this.PainelDireita.Location = new System.Drawing.Point(590, 77);
            this.PainelDireita.Name = "PainelDireita";
            this.PainelDireita.Size = new System.Drawing.Size(161, 365);
            this.PainelDireita.TabIndex = 25;
            // 
            // btnPular
            // 
            this.btnPular.FlatAppearance.BorderSize = 0;
            this.btnPular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPular.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPular.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPular.Location = new System.Drawing.Point(0, 229);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(161, 48);
            this.btnPular.TabIndex = 2;
            this.btnPular.Text = "Pular";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApagar.Location = new System.Drawing.Point(0, 140);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(161, 48);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnUni
            // 
            this.btnUni.FlatAppearance.BorderSize = 0;
            this.btnUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUni.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUni.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUni.Location = new System.Drawing.Point(0, 59);
            this.btnUni.Name = "btnUni";
            this.btnUni.Size = new System.Drawing.Size(161, 48);
            this.btnUni.TabIndex = 0;
            this.btnUni.Text = "Universitários";
            this.btnUni.UseVisualStyleBackColor = true;
            this.btnUni.Click += new System.EventHandler(this.btnUni_Click);
            // 
            // radRes4
            // 
            this.radRes4.AutoSize = true;
            this.radRes4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes4.Location = new System.Drawing.Point(41, 318);
            this.radRes4.Name = "radRes4";
            this.radRes4.Size = new System.Drawing.Size(155, 23);
            this.radRes4.TabIndex = 31;
            this.radRes4.TabStop = true;
            this.radRes4.Text = "Por meio da vacina.";
            this.radRes4.UseVisualStyleBackColor = true;
            this.radRes4.CheckedChanged += new System.EventHandler(this.radRes4_CheckedChanged);
            // 
            // radRes3
            // 
            this.radRes3.AutoSize = true;
            this.radRes3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes3.Location = new System.Drawing.Point(41, 270);
            this.radRes3.Name = "radRes3";
            this.radRes3.Size = new System.Drawing.Size(424, 23);
            this.radRes3.TabIndex = 30;
            this.radRes3.TabStop = true;
            this.radRes3.Text = "Por meio das redes sociais, já que é  um vírus computacional.";
            this.radRes3.UseVisualStyleBackColor = true;
            this.radRes3.CheckedChanged += new System.EventHandler(this.radRes3_CheckedChanged);
            // 
            // radRes2
            // 
            this.radRes2.AutoSize = true;
            this.radRes2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes2.Location = new System.Drawing.Point(41, 214);
            this.radRes2.Name = "radRes2";
            this.radRes2.Size = new System.Drawing.Size(446, 23);
            this.radRes2.TabIndex = 29;
            this.radRes2.TabStop = true;
            this.radRes2.Text = "Através das partículas virais expelidas por uma pessoa infectada.";
            this.radRes2.UseVisualStyleBackColor = true;
            this.radRes2.CheckedChanged += new System.EventHandler(this.radRes2_CheckedChanged);
            // 
            // radRes1
            // 
            this.radRes1.AutoSize = true;
            this.radRes1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes1.Location = new System.Drawing.Point(41, 160);
            this.radRes1.Name = "radRes1";
            this.radRes1.Size = new System.Drawing.Size(120, 23);
            this.radRes1.TabIndex = 28;
            this.radRes1.TabStop = true;
            this.radRes1.Text = "Mentalmente.";
            this.radRes1.UseVisualStyleBackColor = true;
            this.radRes1.CheckedChanged += new System.EventHandler(this.radRes1_CheckedChanged);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Amazon Ember", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(17, 99);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(315, 26);
            this.lblPergunta.TabIndex = 27;
            this.lblPergunta.Text = "Como o covid-19 é transmitido?";
            // 
            // btnProx
            // 
            this.btnProx.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProx.Enabled = false;
            this.btnProx.FlatAppearance.BorderSize = 0;
            this.btnProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProx.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProx.ForeColor = System.Drawing.Color.White;
            this.btnProx.Location = new System.Drawing.Point(483, 389);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(101, 47);
            this.btnProx.TabIndex = 26;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = false;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // frmPergunta9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.PainelBaixo);
            this.Controls.Add(this.PainelDetalhe);
            this.Controls.Add(this.PainelDireita);
            this.Controls.Add(this.radRes4);
            this.Controls.Add(this.radRes3);
            this.Controls.Add(this.radRes2);
            this.Controls.Add(this.radRes1);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.btnProx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPergunta9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta9";
            this.Load += new System.EventHandler(this.frmPergunta9_Load);
            this.PainelDetalhe.ResumeLayout(false);
            this.PainelCima.ResumeLayout(false);
            this.PainelCima.PerformLayout();
            this.PainelDireita.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelBaixo;
        private System.Windows.Forms.Panel PainelDetalhe;
        private System.Windows.Forms.Panel PainelCima;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.Panel PainelDireita;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnUni;
        private System.Windows.Forms.RadioButton radRes4;
        private System.Windows.Forms.RadioButton radRes3;
        private System.Windows.Forms.RadioButton radRes2;
        private System.Windows.Forms.RadioButton radRes1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnProx;
    }
}

namespace ProjetoQuiz
{
    partial class frmLoad
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
            this.components = new System.ComponentModel.Container();
            this.PainelBaixo = new System.Windows.Forms.Panel();
            this.pbar = new CircularProgressBar.CircularProgressBar();
            this.progress = new System.Windows.Forms.Timer(this.components);
            this.PainelCima = new System.Windows.Forms.Panel();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.PainelBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelBaixo
            // 
            this.PainelBaixo.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelBaixo.Controls.Add(this.pbar);
            this.PainelBaixo.Location = new System.Drawing.Point(0, 104);
            this.PainelBaixo.Name = "PainelBaixo";
            this.PainelBaixo.Size = new System.Drawing.Size(300, 282);
            this.PainelBaixo.TabIndex = 16;
            // 
            // pbar
            // 
            this.pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbar.AnimationSpeed = 500;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.ForeColor = System.Drawing.Color.White;
            this.pbar.InnerColor = System.Drawing.Color.Transparent;
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(44, 32);
            this.pbar.MarqueeAnimationSpeed = 2000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.White;
            this.pbar.OuterMargin = -25;
            this.pbar.OuterWidth = 26;
            this.pbar.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.pbar.ProgressWidth = 10;
            this.pbar.SecondaryFont = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.Size = new System.Drawing.Size(213, 206);
            this.pbar.StartAngle = 270;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = "";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "";
            this.pbar.TabIndex = 0;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 68;
            // 
            // progress
            // 
            this.progress.Enabled = true;
            this.progress.Tick += new System.EventHandler(this.progress_Tick);
            // 
            // PainelCima
            // 
            this.PainelCima.BackColor = System.Drawing.SystemColors.Highlight;
            this.PainelCima.Location = new System.Drawing.Point(0, 0);
            this.PainelCima.Name = "PainelCima";
            this.PainelCima.Size = new System.Drawing.Size(300, 25);
            this.PainelCima.TabIndex = 2;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.White;
            this.lblCarregando.Location = new System.Drawing.Point(100, 34);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(104, 31);
            this.lblCarregando.TabIndex = 0;
            this.lblCarregando.Text = "Carregando";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(107, 64);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(88, 31);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(300, 411);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.PainelBaixo);
            this.Controls.Add(this.PainelCima);
            this.Controls.Add(this.lblCarregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.PainelBaixo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelBaixo;
        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Timer progress;
        private System.Windows.Forms.Panel PainelCima;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Label lblResultado;
    }
}
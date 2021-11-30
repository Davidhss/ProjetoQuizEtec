
namespace ProjetoQuiz
{
    partial class frmUniversitarios
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
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblUni = new System.Windows.Forms.Label();
            this.lblUniversitarios = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbarA = new CircularProgressBar.CircularProgressBar();
            this.pbarB = new CircularProgressBar.CircularProgressBar();
            this.pbarC = new CircularProgressBar.CircularProgressBar();
            this.pbarD = new CircularProgressBar.CircularProgressBar();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Timer(this.components);
            this.B = new System.Windows.Forms.Timer(this.components);
            this.C = new System.Windows.Forms.Timer(this.components);
            this.D = new System.Windows.Forms.Timer(this.components);
            this.pnlUp.SuspendLayout();
            this.pnlDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlUp.Controls.Add(this.lblUni);
            this.pnlUp.Controls.Add(this.lblUniversitarios);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(510, 48);
            this.pnlUp.TabIndex = 0;
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUni.ForeColor = System.Drawing.Color.White;
            this.lblUni.Location = new System.Drawing.Point(194, 9);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(122, 31);
            this.lblUni.TabIndex = 3;
            this.lblUni.Text = "Universitários";
            // 
            // lblUniversitarios
            // 
            this.lblUniversitarios.AutoSize = true;
            this.lblUniversitarios.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversitarios.ForeColor = System.Drawing.Color.White;
            this.lblUniversitarios.Location = new System.Drawing.Point(192, 9);
            this.lblUniversitarios.Name = "lblUniversitarios";
            this.lblUniversitarios.Size = new System.Drawing.Size(122, 31);
            this.lblUniversitarios.TabIndex = 2;
            this.lblUniversitarios.Text = "Universitários";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlDown.Controls.Add(this.btnFechar);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 209);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(510, 52);
            this.pnlDown.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(217, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 35);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbarA
            // 
            this.pbarA.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarA.AnimationSpeed = 500;
            this.pbarA.BackColor = System.Drawing.Color.Transparent;
            this.pbarA.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarA.ForeColor = System.Drawing.Color.White;
            this.pbarA.InnerColor = System.Drawing.Color.Transparent;
            this.pbarA.InnerMargin = 2;
            this.pbarA.InnerWidth = -1;
            this.pbarA.Location = new System.Drawing.Point(52, 96);
            this.pbarA.MarqueeAnimationSpeed = 2000;
            this.pbarA.Name = "pbarA";
            this.pbarA.OuterColor = System.Drawing.Color.White;
            this.pbarA.OuterMargin = -25;
            this.pbarA.OuterWidth = 26;
            this.pbarA.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.pbarA.ProgressWidth = 6;
            this.pbarA.SecondaryFont = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarA.Size = new System.Drawing.Size(76, 73);
            this.pbarA.StartAngle = 270;
            this.pbarA.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarA.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarA.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarA.SubscriptText = "";
            this.pbarA.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarA.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarA.SuperscriptText = "";
            this.pbarA.TabIndex = 2;
            this.pbarA.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pbarA.Value = 68;
            // 
            // pbarB
            // 
            this.pbarB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarB.AnimationSpeed = 500;
            this.pbarB.BackColor = System.Drawing.Color.Transparent;
            this.pbarB.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarB.ForeColor = System.Drawing.Color.White;
            this.pbarB.InnerColor = System.Drawing.Color.Transparent;
            this.pbarB.InnerMargin = 2;
            this.pbarB.InnerWidth = -1;
            this.pbarB.Location = new System.Drawing.Point(166, 96);
            this.pbarB.MarqueeAnimationSpeed = 2000;
            this.pbarB.Name = "pbarB";
            this.pbarB.OuterColor = System.Drawing.Color.White;
            this.pbarB.OuterMargin = -25;
            this.pbarB.OuterWidth = 26;
            this.pbarB.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.pbarB.ProgressWidth = 6;
            this.pbarB.SecondaryFont = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarB.Size = new System.Drawing.Size(76, 73);
            this.pbarB.StartAngle = 270;
            this.pbarB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarB.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarB.SubscriptText = "";
            this.pbarB.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarB.SuperscriptText = "";
            this.pbarB.TabIndex = 3;
            this.pbarB.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pbarB.Value = 68;
            // 
            // pbarC
            // 
            this.pbarC.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarC.AnimationSpeed = 500;
            this.pbarC.BackColor = System.Drawing.Color.Transparent;
            this.pbarC.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarC.ForeColor = System.Drawing.Color.White;
            this.pbarC.InnerColor = System.Drawing.Color.Transparent;
            this.pbarC.InnerMargin = 2;
            this.pbarC.InnerWidth = -1;
            this.pbarC.Location = new System.Drawing.Point(279, 96);
            this.pbarC.MarqueeAnimationSpeed = 2000;
            this.pbarC.Name = "pbarC";
            this.pbarC.OuterColor = System.Drawing.Color.White;
            this.pbarC.OuterMargin = -25;
            this.pbarC.OuterWidth = 26;
            this.pbarC.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.pbarC.ProgressWidth = 6;
            this.pbarC.SecondaryFont = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarC.Size = new System.Drawing.Size(76, 73);
            this.pbarC.StartAngle = 270;
            this.pbarC.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarC.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarC.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarC.SubscriptText = "";
            this.pbarC.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarC.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarC.SuperscriptText = "";
            this.pbarC.TabIndex = 4;
            this.pbarC.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pbarC.Value = 68;
            // 
            // pbarD
            // 
            this.pbarD.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarD.AnimationSpeed = 500;
            this.pbarD.BackColor = System.Drawing.Color.Transparent;
            this.pbarD.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarD.ForeColor = System.Drawing.Color.White;
            this.pbarD.InnerColor = System.Drawing.Color.Transparent;
            this.pbarD.InnerMargin = 2;
            this.pbarD.InnerWidth = -1;
            this.pbarD.Location = new System.Drawing.Point(392, 96);
            this.pbarD.MarqueeAnimationSpeed = 2000;
            this.pbarD.Name = "pbarD";
            this.pbarD.OuterColor = System.Drawing.Color.White;
            this.pbarD.OuterMargin = -25;
            this.pbarD.OuterWidth = 26;
            this.pbarD.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.pbarD.ProgressWidth = 6;
            this.pbarD.SecondaryFont = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarD.Size = new System.Drawing.Size(76, 73);
            this.pbarD.StartAngle = 270;
            this.pbarD.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarD.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarD.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarD.SubscriptText = "";
            this.pbarD.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarD.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarD.SuperscriptText = "";
            this.pbarD.TabIndex = 5;
            this.pbarD.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pbarD.Value = 68;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(79, 62);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(25, 31);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.White;
            this.lblB.Location = new System.Drawing.Point(192, 62);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(25, 31);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(305, 62);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(25, 31);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "C";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.White;
            this.lblD.Location = new System.Drawing.Point(418, 62);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(25, 31);
            this.lblD.TabIndex = 9;
            this.lblD.Text = "D";
            // 
            // A
            // 
            this.A.Enabled = true;
            this.A.Tick += new System.EventHandler(this.A_Tick);
            // 
            // B
            // 
            this.B.Enabled = true;
            this.B.Tick += new System.EventHandler(this.B_Tick);
            // 
            // C
            // 
            this.C.Enabled = true;
            this.C.Tick += new System.EventHandler(this.C_Tick);
            // 
            // D
            // 
            this.D.Enabled = true;
            this.D.Tick += new System.EventHandler(this.D_Tick);
            // 
            // frmUniversitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pbarD);
            this.Controls.Add(this.pbarC);
            this.Controls.Add(this.pbarB);
            this.Controls.Add(this.pbarA);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUniversitarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUniversitarios";
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Label lblUniversitarios;
        private CircularProgressBar.CircularProgressBar pbarA;
        private CircularProgressBar.CircularProgressBar pbarB;
        private CircularProgressBar.CircularProgressBar pbarC;
        private CircularProgressBar.CircularProgressBar pbarD;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Timer A;
        private System.Windows.Forms.Timer B;
        private System.Windows.Forms.Timer C;
        private System.Windows.Forms.Timer D;
    }
}
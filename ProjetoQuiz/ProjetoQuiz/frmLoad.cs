using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();

            //Configurações de Temas do Programa
            if (Dados.Temas == "Padrão")
            {
                BackColor = Color.FromArgb(0, 102, 204);
                pbar.ProgressColor = Color.FromArgb(0, 190, 254);
                PainelBaixo.BackColor = Color.FromArgb(0, 120, 215);
                PainelCima.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (Dados.Temas == "Marlene")
            {
                BackColor = Color.FromArgb(192, 34, 173);
                pbar.ProgressColor = Color.FromArgb(255, 34, 228);
                PainelBaixo.BackColor = Color.FromArgb(244, 45, 220);
                PainelCima.BackColor = Color.FromArgb(244, 45, 220);
            }
            else if (Dados.Temas == "Rodrigo")
            {
                BackColor = Color.FromArgb(64, 176, 33);
                pbar.ProgressColor = Color.FromArgb(68, 255, 34);
                PainelBaixo.BackColor = Color.FromArgb(81, 195, 49);
                PainelCima.BackColor = Color.FromArgb(81, 195, 49);
            }
            else if (Dados.Temas == "Ediney")
            {
                BackColor = Color.FromArgb(70, 70, 70);
                pbar.ProgressColor = Color.FromArgb(168, 168, 168);
                PainelBaixo.BackColor = Color.FromArgb(85, 85, 85);
                PainelCima.BackColor = Color.FromArgb(85, 85, 85);
            }
            else if (Dados.Temas == "Marcel")
            {
                BackColor = Color.FromArgb(35, 36, 35);
                pbar.ProgressColor = Color.FromArgb(168, 168, 168);
                PainelBaixo.BackColor = Color.FromArgb(47, 48, 47);
                PainelCima.BackColor = Color.FromArgb(47, 48, 47);
            }

            pbar.Value = 0;
        }

        private void progress_Tick(object sender, EventArgs e)
        {
            //Programação do Circular Progress Bar

            //Velocidade do progress bar (2 em 2)
            pbar.Value += 2;

            //Adicionando o valor do pbar no texto junto da porcentagem (0% ...)
            pbar.Text = pbar.Value.ToString() + "%";

            //Definição do limite da pbar (100%)
            if (pbar.Value == 100)
            {
                //Ao chegar em 100% ele desativará a contagem e abrirá o form Resultado
                progress.Enabled = false;
                frmResultado resultado = new frmResultado();
                resultado.Show();
                this.Hide();
            }
        }
    }
}

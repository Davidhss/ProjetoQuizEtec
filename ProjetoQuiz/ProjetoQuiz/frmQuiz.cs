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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();

            //Configurações de Temas do Programa
            if (Dados.Temas == "Padrão")
            {
                BackColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(0, 120, 215);
                PainelCima.BackColor = Color.FromArgb(0, 120, 215);
                PainelDetalhe.BackColor = Color.FromArgb(0, 102, 204);
                btnIniciar.BackColor = Color.FromArgb(0, 120, 215);
                btnFechar.BackColor = Color.FromArgb(0, 120, 215);
                btnTemas.BackColor = Color.FromArgb(0, 120, 215);
                btnX.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (Dados.Temas == "Marlene")
            {
                BackColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(244, 45, 220);
                PainelCima.BackColor = Color.FromArgb(244, 45, 220);
                PainelDetalhe.BackColor = Color.FromArgb(192, 34, 173);
                btnIniciar.BackColor = Color.FromArgb(244, 45, 220);
                btnFechar.BackColor = Color.FromArgb(244, 45, 220);
                btnTemas.BackColor = Color.FromArgb(244, 45, 220);
                btnX.BackColor = Color.FromArgb(244, 45, 220);
            }
            else if (Dados.Temas == "Rodrigo")
            {
                BackColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(81, 195, 49);
                PainelCima.BackColor = Color.FromArgb(81, 195, 49);
                PainelDetalhe.BackColor = Color.FromArgb(64, 176, 33);
                btnIniciar.BackColor = Color.FromArgb(81, 195, 49);
                btnFechar.BackColor = Color.FromArgb(81, 195, 49);
                btnTemas.BackColor = Color.FromArgb(81, 195, 49);
                btnX.BackColor = Color.FromArgb(81, 195, 49);
            }
            else if (Dados.Temas == "Ediney")
            {
                BackColor = Color.FromArgb(120, 121, 120);
                lblQuiz.ForeColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(85, 85, 85);
                PainelCima.BackColor = Color.FromArgb(85, 85, 85);
                PainelDetalhe.BackColor = Color.FromArgb(70, 70, 70);
                btnIniciar.BackColor = Color.FromArgb(85, 85, 85);
                btnFechar.BackColor = Color.FromArgb(85, 85, 85);
                btnTemas.BackColor = Color.FromArgb(85, 85, 85);
                btnX.BackColor = Color.FromArgb(85, 85, 85);
            }
            else if (Dados.Temas == "Marcel")
            {
                BackColor = Color.FromArgb(63, 64, 63);
                lblQuiz.ForeColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(47, 48, 47);
                PainelCima.BackColor = Color.FromArgb(47, 48, 47);
                PainelDetalhe.BackColor = Color.FromArgb(35, 36, 35);
                btnIniciar.BackColor = Color.FromArgb(23, 24, 23);
                btnFechar.BackColor = Color.FromArgb(23, 24, 23);
                btnTemas.BackColor = Color.FromArgb(47, 48, 47);
                btnX.BackColor = Color.FromArgb(47, 48, 47);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Sair do programa
            Application.Exit();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Ao clicar em Iniciar, começará o quiz indo para o formulário da primeira questão
            frmPergunta1 pergunta1 = new frmPergunta1();
            pergunta1.Show();
            this.Hide();
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            //Abrir o formulário Temas
            frmTemas temas = new frmTemas();
            temas.Show();
            this.Hide();
        }
    }
}

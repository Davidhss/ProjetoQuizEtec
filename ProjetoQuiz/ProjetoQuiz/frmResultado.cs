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
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();

            //Configuração de Temas do Programa
            if (Dados.Temas == "Padrão")
            {
                BackColor = Color.White;
                pnlCentro.BackColor = Color.FromArgb(0, 120, 215);
                PainelBaixo.BackColor = Color.FromArgb(0, 120, 215);
                PainelCima.BackColor = Color.FromArgb(0, 120, 215);
                PainelDetalhe.BackColor = Color.FromArgb(0, 102, 204);
                btnFechar.BackColor = Color.FromArgb(0, 120, 215);
                btnX.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (Dados.Temas == "Marlene")
            {
                BackColor = Color.White;
                pnlCentro.BackColor = Color.FromArgb(244, 45, 220);
                PainelBaixo.BackColor = Color.FromArgb(244, 45, 220);
                PainelCima.BackColor = Color.FromArgb(244, 45, 220);
                PainelDetalhe.BackColor = Color.FromArgb(192, 34, 173);
                btnFechar.BackColor = Color.FromArgb(244, 45, 220);
                btnX.BackColor = Color.FromArgb(244, 45, 220);
            }
            else if (Dados.Temas == "Rodrigo")
            {
                BackColor = Color.White;
                pnlCentro.BackColor = Color.FromArgb(81, 195, 49);
                PainelBaixo.BackColor = Color.FromArgb(81, 195, 49);
                PainelCima.BackColor = Color.FromArgb(81, 195, 49);
                PainelDetalhe.BackColor = Color.FromArgb(64, 176, 33);
                btnFechar.BackColor = Color.FromArgb(81, 195, 49);
                btnX.BackColor = Color.FromArgb(81, 195, 49);
            }
            else if (Dados.Temas == "Ediney")
            {
                BackColor = Color.FromArgb(120, 121, 120);
                pnlCentro.BackColor = Color.FromArgb(85, 85, 85);
                PainelBaixo.BackColor = Color.FromArgb(85, 85, 85);
                PainelCima.BackColor = Color.FromArgb(85, 85, 85);
                PainelDetalhe.BackColor = Color.FromArgb(70, 70, 70);
                btnFechar.BackColor = Color.FromArgb(85, 85, 85);
                btnX.BackColor = Color.FromArgb(85, 85, 85);
            }
            else if (Dados.Temas == "Marcel")
            {
                BackColor = Color.FromArgb(63, 64, 63);
                pnlCentro.BackColor = Color.FromArgb(47, 48, 47);
                PainelBaixo.BackColor = Color.FromArgb(47, 48, 47);
                PainelCima.BackColor = Color.FromArgb(47, 48, 47);
                PainelDetalhe.BackColor = Color.FromArgb(35, 36, 35);
                btnFechar.BackColor = Color.FromArgb(47, 48, 47);
                btnX.BackColor = Color.FromArgb(47, 48, 47);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Sair da Aplicação
            Application.Exit();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            //O texto que aparecerá é igual à quantidade de Acertos e Erros armazenadas nos Dados
            lblAcerto.Text = Dados.Acertos().ToString();
            lblErro.Text = Dados.Erros().ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão Reiniciar, o usuário voltará para o form inicial
            frmQuiz quiz = new frmQuiz();
            quiz.Show();
            this.Hide();

            //Zera a quantidade de Acertos e Erros para não acumular com o resultado anterior
            Dados.Acerto = 0;
            Dados.Erro = 0;
        }
    }
}

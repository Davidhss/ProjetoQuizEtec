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
    public partial class frmTemas : Form
    {
        public frmTemas()
        {
            InitializeComponent();

            //Configuração de Temas do Programa

            // Se o valor armazenado na variável Temas for igual à ... então troque as cores do formulário para ...
            if (Dados.Temas == "Padrão")
            {
                BackColor = Color.White;
                lblEscolha.ForeColor = Color.Black;
                PainelBaixo.BackColor = Color.FromArgb(0, 120, 215);
                PainelCima.BackColor = Color.FromArgb(0, 120, 215);
                PainelDetalhe.BackColor = Color.FromArgb(0, 102, 204);
                btnVoltar.BackColor = Color.FromArgb(0, 120, 215);
                btnMarlene.BackColor = Color.FromArgb(0, 120, 215);
                btnRodrigo.BackColor = Color.FromArgb(0, 120, 215);
                btnMarcel.BackColor = Color.FromArgb(0, 120, 215);
                btnEdiney.BackColor = Color.FromArgb(0, 120, 215);
                btnPadrao.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (Dados.Temas == "Marlene")
            {
                BackColor = Color.White;
                lblEscolha.ForeColor = Color.Black;
                PainelBaixo.BackColor = Color.FromArgb(244, 45, 220);
                PainelCima.BackColor = Color.FromArgb(244, 45, 220);
                PainelDetalhe.BackColor = Color.FromArgb(192, 34, 173);
                btnVoltar.BackColor = Color.FromArgb(244, 45, 220);
                btnMarlene.BackColor = Color.FromArgb(244, 45, 220);
                btnRodrigo.BackColor = Color.FromArgb(244, 45, 220);
                btnMarcel.BackColor = Color.FromArgb(244, 45, 220);
                btnEdiney.BackColor = Color.FromArgb(244, 45, 220);
                btnPadrao.BackColor = Color.FromArgb(244, 45, 220);
            }
            else if (Dados.Temas == "Rodrigo")
            {
                BackColor = Color.White;
                lblEscolha.ForeColor = Color.Black;
                PainelBaixo.BackColor = Color.FromArgb(81, 195, 49);
                PainelCima.BackColor = Color.FromArgb(81, 195, 49);
                PainelDetalhe.BackColor = Color.FromArgb(64, 176, 33);
                btnVoltar.BackColor = Color.FromArgb(81, 195, 49);
                btnMarlene.BackColor = Color.FromArgb(81, 195, 49);
                btnRodrigo.BackColor = Color.FromArgb(81, 195, 49);
                btnMarcel.BackColor = Color.FromArgb(81, 195, 49);
                btnEdiney.BackColor = Color.FromArgb(81, 195, 49);
                btnPadrao.BackColor = Color.FromArgb(81, 195, 49);
            }
            else if (Dados.Temas == "Ediney")
            {
                BackColor = Color.FromArgb(120, 121, 120);
                lblEscolha.ForeColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(85, 85, 85);
                PainelCima.BackColor = Color.FromArgb(85, 85, 85);
                PainelDetalhe.BackColor = Color.FromArgb(70, 70, 70);
                btnVoltar.BackColor = Color.FromArgb(85, 85, 85);
                btnMarlene.BackColor = Color.FromArgb(85, 85, 85);
                btnRodrigo.BackColor = Color.FromArgb(85, 85, 85);
                btnMarcel.BackColor = Color.FromArgb(85, 85, 85);
                btnEdiney.BackColor = Color.FromArgb(85, 85, 85);
                btnPadrao.BackColor = Color.FromArgb(85, 85, 85);
            }
            else if (Dados.Temas == "Marcel")
            {
                BackColor = Color.FromArgb(63, 64, 63);
                lblEscolha.ForeColor = Color.White;
                PainelBaixo.BackColor = Color.FromArgb(47, 48, 47);
                PainelCima.BackColor = Color.FromArgb(47, 48, 47);
                PainelDetalhe.BackColor = Color.FromArgb(35, 36, 35);
                btnVoltar.BackColor = Color.FromArgb(23, 24, 23);
                btnMarlene.BackColor = Color.FromArgb(23, 24, 23);
                btnRodrigo.BackColor = Color.FromArgb(23, 24, 23);
                btnMarcel.BackColor = Color.FromArgb(23, 24, 23);
                btnEdiney.BackColor = Color.FromArgb(23, 24, 23);
                btnPadrao.BackColor = Color.FromArgb(23, 24, 23);
            }
        }

        private void btnMarlene_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão, o usuário altera o valor da variável Temas, que terá um esquema de cores pré-definido

            Dados.Temas = "Marlene";

            BackColor = Color.White;
            lblEscolha.ForeColor = Color.Black;
            PainelBaixo.BackColor = Color.FromArgb(244, 45, 220);
            PainelCima.BackColor = Color.FromArgb(244, 45, 220);
            PainelDetalhe.BackColor = Color.FromArgb(192, 34, 173);
            btnVoltar.BackColor = Color.FromArgb(244, 45, 220);
            btnMarlene.BackColor = Color.FromArgb(244, 45, 220);
            btnRodrigo.BackColor = Color.FromArgb(244, 45, 220);
            btnMarcel.BackColor = Color.FromArgb(244, 45, 220);
            btnEdiney.BackColor = Color.FromArgb(244, 45, 220);
            btnPadrao.BackColor = Color.FromArgb(244, 45, 220);
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão, o usuário altera o valor da variável Temas, que terá um esquema de cores pré-definido

            Dados.Temas = "Padrão";

            BackColor = Color.White;
            lblEscolha.ForeColor = Color.Black;
            PainelBaixo.BackColor = Color.FromArgb(0, 120, 215);
            PainelCima.BackColor = Color.FromArgb(0, 120, 215);
            PainelDetalhe.BackColor = Color.FromArgb(0, 102, 204);
            btnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            btnMarlene.BackColor = Color.FromArgb(0, 120, 215);
            btnRodrigo.BackColor = Color.FromArgb(0, 120, 215);
            btnMarcel.BackColor = Color.FromArgb(0, 120, 215);
            btnEdiney.BackColor = Color.FromArgb(0, 120, 215);
            btnPadrao.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //Sair da Aplicação
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Volta para o formulário inicial
            frmQuiz quiz = new frmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void btnRodrigo_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão, o usuário altera o valor da variável Temas, que terá um esquema de cores pré-definido

            Dados.Temas = "Rodrigo";

            BackColor = Color.White;
            lblEscolha.ForeColor = Color.Black;
            PainelBaixo.BackColor = Color.FromArgb(81, 195, 49);
            PainelCima.BackColor = Color.FromArgb(81, 195, 49);
            PainelDetalhe.BackColor = Color.FromArgb(64, 176, 33);
            btnVoltar.BackColor = Color.FromArgb(81, 195, 49);
            btnMarlene.BackColor = Color.FromArgb(81, 195, 49);
            btnRodrigo.BackColor = Color.FromArgb(81, 195, 49);
            btnMarcel.BackColor = Color.FromArgb(81, 195, 49);
            btnEdiney.BackColor = Color.FromArgb(81, 195, 49);
            btnPadrao.BackColor = Color.FromArgb(81, 195, 49);
        }

        private void btnEdiney_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão, o usuário altera o valor da variável Temas, que terá um esquema de cores pré-definido

            Dados.Temas = "Ediney";

            BackColor = Color.FromArgb(120, 121, 120);
            lblEscolha.ForeColor = Color.White;
            PainelBaixo.BackColor = Color.FromArgb(85, 85, 85);
            PainelCima.BackColor = Color.FromArgb(85, 85, 85);
            PainelDetalhe.BackColor = Color.FromArgb(70, 70, 70);
            btnVoltar.BackColor = Color.FromArgb(85, 85, 85);
            btnMarlene.BackColor = Color.FromArgb(85, 85, 85);
            btnRodrigo.BackColor = Color.FromArgb(85, 85, 85);
            btnMarcel.BackColor = Color.FromArgb(85, 85, 85);
            btnEdiney.BackColor = Color.FromArgb(85, 85, 85);
            btnPadrao.BackColor = Color.FromArgb(85, 85, 85);
        }

        private void btnMarcel_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão, o usuário altera o valor da variável Temas, que terá um esquema de cores pré-definido

            Dados.Temas = "Marcel";

            BackColor = Color.FromArgb(63, 64, 63);
            lblEscolha.ForeColor = Color.White;
            PainelBaixo.BackColor = Color.FromArgb(47, 48, 47);
            PainelCima.BackColor = Color.FromArgb(47, 48, 47);
            PainelDetalhe.BackColor = Color.FromArgb(35, 36, 35);
            btnVoltar.BackColor = Color.FromArgb(23, 24, 23);
            btnMarlene.BackColor = Color.FromArgb(23, 24, 23);
            btnRodrigo.BackColor = Color.FromArgb(23, 24, 23);
            btnMarcel.BackColor = Color.FromArgb(23, 24, 23);
            btnEdiney.BackColor = Color.FromArgb(23, 24, 23);
            btnPadrao.BackColor = Color.FromArgb(23, 24, 23);
        }
    }
}

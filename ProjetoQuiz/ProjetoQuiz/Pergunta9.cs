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
    public partial class frmPergunta9 : Form
    {
        public frmPergunta9()
        {
            InitializeComponent();

            //Configuração de Temas do Programa
            if (Dados.Temas == "Padrão")
            {
                BackColor = Color.White;
                PainelDireita.BackColor = Color.FromArgb(0, 102, 204);
                PainelBaixo.BackColor = Color.FromArgb(0, 120, 215);
                PainelCima.BackColor = Color.FromArgb(0, 120, 215);
                PainelDetalhe.BackColor = Color.FromArgb(0, 102, 204);
                btnProx.BackColor = Color.FromArgb(0, 120, 215);
                btnX.BackColor = Color.FromArgb(0, 120, 215);
                btnUni.ForeColor = Color.FromArgb(0, 190, 254);
                btnPular.ForeColor = Color.FromArgb(0, 190, 254);
                btnApagar.ForeColor = Color.FromArgb(0, 190, 254);
            }
            else if (Dados.Temas == "Marlene")
            {
                BackColor = Color.White;
                PainelDireita.BackColor = Color.FromArgb(192, 34, 173);
                PainelBaixo.BackColor = Color.FromArgb(244, 45, 220);
                PainelCima.BackColor = Color.FromArgb(244, 45, 220);
                PainelDetalhe.BackColor = Color.FromArgb(192, 34, 173);
                btnProx.BackColor = Color.FromArgb(244, 45, 220);
                btnX.BackColor = Color.FromArgb(244, 45, 220);
                btnUni.ForeColor = Color.FromArgb(255, 34, 228);
                btnPular.ForeColor = Color.FromArgb(255, 34, 228);
                btnApagar.ForeColor = Color.FromArgb(255, 34, 228);
            }
            else if (Dados.Temas == "Rodrigo")
            {
                BackColor = Color.White;
                PainelDireita.BackColor = Color.FromArgb(64, 176, 33);
                PainelBaixo.BackColor = Color.FromArgb(81, 195, 49);
                PainelCima.BackColor = Color.FromArgb(81, 195, 49);
                PainelDetalhe.BackColor = Color.FromArgb(64, 176, 33);
                btnProx.BackColor = Color.FromArgb(81, 195, 49);
                btnX.BackColor = Color.FromArgb(81, 195, 49);
                btnUni.ForeColor = Color.FromArgb(68, 255, 34);
                btnPular.ForeColor = Color.FromArgb(68, 255, 34);
                btnApagar.ForeColor = Color.FromArgb(68, 255, 34);
            }
            else if (Dados.Temas == "Ediney")
            {
                BackColor = Color.FromArgb(120, 121, 120);
                lblPergunta.ForeColor = Color.White;
                radRes1.ForeColor = Color.White;
                radRes2.ForeColor = Color.White;
                radRes3.ForeColor = Color.White;
                radRes4.ForeColor = Color.White;
                PainelDireita.BackColor = Color.FromArgb(70, 70, 70);
                PainelBaixo.BackColor = Color.FromArgb(85, 85, 85);
                PainelCima.BackColor = Color.FromArgb(85, 85, 85);
                PainelDetalhe.BackColor = Color.FromArgb(70, 70, 70);
                btnProx.BackColor = Color.FromArgb(85, 85, 85);
                btnX.BackColor = Color.FromArgb(85, 85, 85);
                btnUni.ForeColor = Color.FromArgb(168, 168, 168);
                btnPular.ForeColor = Color.FromArgb(168, 168, 168);
                btnApagar.ForeColor = Color.FromArgb(168, 168, 168);
            }
            else if (Dados.Temas == "Marcel")
            {
                BackColor = Color.FromArgb(63, 64, 63);
                lblPergunta.ForeColor = Color.White;
                radRes1.ForeColor = Color.White;
                radRes2.ForeColor = Color.White;
                radRes3.ForeColor = Color.White;
                radRes4.ForeColor = Color.White;
                PainelDireita.BackColor = Color.FromArgb(35, 36, 35);
                PainelBaixo.BackColor = Color.FromArgb(47, 48, 47);
                PainelCima.BackColor = Color.FromArgb(47, 48, 47);
                PainelDetalhe.BackColor = Color.FromArgb(35, 36, 35);
                btnProx.BackColor = Color.FromArgb(47, 48, 47);
                btnX.BackColor = Color.FromArgb(47, 48, 47);
                btnUni.ForeColor = Color.FromArgb(168, 168, 168);
                btnPular.ForeColor = Color.FromArgb(168, 168, 168);
                btnApagar.ForeColor = Color.FromArgb(168, 168, 168);
            }
        }

        private void radRes1_CheckedChanged(object sender, EventArgs e)
        {
            //O botão Próximo só fica disponivel se algum radiobutton for selecionado
            btnProx.Enabled = true;
        }

        private void radRes2_CheckedChanged(object sender, EventArgs e)
        {
            //O botão Próximo só fica disponivel se algum radiobutton for selecionado
            btnProx.Enabled = true;
        }

        private void radRes3_CheckedChanged(object sender, EventArgs e)
        {
            //O botão Próximo só fica disponivel se algum radiobutton for selecionado
            btnProx.Enabled = true;
        }

        private void radRes4_CheckedChanged(object sender, EventArgs e)
        {
            //O botão Próximo só fica disponivel se algum radiobutton for selecionado
            btnProx.Enabled = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            //Se o segundo radiobutton(alternativa correta) estiver selecionado, é chamado o método Dados.Acertou() para adicionar +1 no valor do acerto, se não, acrescenta +1 no valor do erro
            if (radRes2.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            frmPergunta10 pergunta10 = new frmPergunta10();
            pergunta10.Show();
            this.Hide();
        }

        private void frmPergunta9_Load(object sender, EventArgs e)
        {
            //Ao carregar o formulário, o programa verifica se algum botão de ajuda já foi utilizado, se sim, o botão é desativado

            if (Dados.Usar == true)
            {
                btnUni.Enabled = false;
            }
            else
            {
                btnUni.Enabled = true;
            }

            if (Dados.Usar2 == true)
            {
                btnPular.Enabled = false;
            }
            else
            {
                btnPular.Enabled = true;
            }

            if (Dados.Usar3 == true)
            {
                btnApagar.Enabled = false;
            }
            else
            {
                btnApagar.Enabled = true;
            }
        }

        private void btnUni_Click(object sender, EventArgs e)
        {
            //Se a variável booleana Dados.Usar estiver como false, então abrirá o formulário de Universitários e desativará o botão para o usuário não usá-lo novamente pelo resto do quiz
            if (Dados.Usar == false)
            {
                Dados.Uni = "Q9";
                frmUniversitarios universitarios = new frmUniversitarios();
                universitarios.Show();
                Dados.Usou();
                btnUni.Enabled = false;
            }
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            //O botão Pular simplesmente manda o usuário para o próximo formulário, anulando aquela questão
            if (Dados.Usar2 == false)
            {
                Dados.Usou2();
                frmPergunta10 pergunta10 = new frmPergunta10();
                pergunta10.Show();
                this.Hide();
                btnPular.Enabled = false;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //O botão Apagar escolhe um número aleatório que alternativas que eles irá apagar, ou seja, será por sorte do usuário apagar uma alternativa errada ou três
            Random randNum = new Random();
            if (randNum.Next(3) == 1)
            {
                radRes4.Visible = false;
            }
            else if (randNum.Next(3) == 2)
            {
                radRes4.Visible = false;
                radRes3.Visible = false;
            }
            else
            {
                radRes4.Visible = false;
                radRes1.Visible = false;
                radRes3.Visible = false;
            }

            if (Dados.Usar3 == false)
            {
                Dados.Usou3();
                btnApagar.Enabled = false;
            }
        }
    }
}

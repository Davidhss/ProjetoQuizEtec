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
    public partial class frmUniversitarios : Form
    {
        public frmUniversitarios()
        {
            InitializeComponent();

            //Configuração de Temas do Programa
            if (Dados.Temas == "Padrão")
            {
                BackColor = Color.FromArgb(0, 120, 215);
                pbarA.ProgressColor = Color.FromArgb(0, 190, 254);
                pbarB.ProgressColor = Color.FromArgb(0, 190, 254);
                pbarC.ProgressColor = Color.FromArgb(0, 190, 254);
                pbarD.ProgressColor = Color.FromArgb(0, 190, 254);
                pnlDown.BackColor = Color.FromArgb(0, 102, 204);
                pnlUp.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (Dados.Temas == "Marlene")
            {
                BackColor = Color.FromArgb(244, 45, 220);
                pbarA.ProgressColor = Color.FromArgb(255, 34, 228);
                pbarB.ProgressColor = Color.FromArgb(255, 34, 228);
                pbarC.ProgressColor = Color.FromArgb(255, 34, 228);
                pbarD.ProgressColor = Color.FromArgb(255, 34, 228);
                pnlDown.BackColor = Color.FromArgb(192, 34, 173);
                pnlUp.BackColor = Color.FromArgb(192, 34, 173);
            }
            else if (Dados.Temas == "Rodrigo")
            {
                BackColor = Color.FromArgb(81, 195, 49);
                pbarA.ProgressColor = Color.FromArgb(68, 255, 34);
                pbarB.ProgressColor = Color.FromArgb(68, 255, 34);
                pbarC.ProgressColor = Color.FromArgb(68, 255, 34);
                pbarD.ProgressColor = Color.FromArgb(68, 255, 34);
                pnlDown.BackColor = Color.FromArgb(64, 176, 33);
                pnlUp.BackColor = Color.FromArgb(64, 176, 33);
            }
            else if (Dados.Temas == "Ediney")
            {
                BackColor = Color.FromArgb(85, 85, 85);
                pbarA.ProgressColor = Color.FromArgb(168, 168, 168);
                pbarB.ProgressColor = Color.FromArgb(168, 168, 168);
                pbarC.ProgressColor = Color.FromArgb(168, 168, 168);
                pbarD.ProgressColor = Color.FromArgb(168, 168, 168);
                pnlDown.BackColor = Color.FromArgb(70, 70, 70);
                pnlUp.BackColor = Color.FromArgb(70, 70, 70);
            }
            else if (Dados.Temas == "Marcel")
            {
                BackColor = Color.FromArgb(47, 48, 47);
                pbarA.ProgressColor = Color.FromArgb(168, 168, 168);
                pbarB.ProgressColor = Color.FromArgb(168, 168, 168);
                pbarC.ProgressColor = Color.FromArgb(168, 168, 168);
                pbarD.ProgressColor = Color.FromArgb(168, 168, 168);
                pnlDown.BackColor = Color.FromArgb(35, 36, 35);
                pnlUp.BackColor = Color.FromArgb(35, 36, 35);
            }

            pbarA.Value = 0;
            pbarB.Value = 0;
            pbarC.Value = 0;
            pbarD.Value = 0;
        }

        private void A_Tick(object sender, EventArgs e)
        {
            //Ao entrar em um formulário de pergunta, é trocado o valor da variável Dados.Uni para diferenciar os formulários, assim os universitários terão valores pré-programados diferentes para cada questão.

            switch (Dados.Uni)
            {
                //Se o usuário estiver na questão 1, o valor exibido para a alternativa 'A' será 7% 
                case "Q1":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 7)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 2, o valor exibido para a alternativa 'A' será 68% (alternativa correta)
                case "Q2":
                    pbarA.Value += 2;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 68)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 3, o valor exibido para a alternativa 'A' será 5% 
                case "Q3":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 5)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 4, o valor exibido para a alternativa 'A' será 4% 
                case "Q4":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 4)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 5, o valor exibido para a alternativa 'A' será 11% 
                case "Q5":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 11)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 6, o valor exibido para a alternativa 'A' será 7% 
                case "Q6":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 7)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 7, o valor exibido para a alternativa 'A' será 92% (alternativa correta)
                case "Q7":
                    pbarA.Value += 4;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 92)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 8, o valor exibido para a alternativa 'A' será 9% 
                case "Q8":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 9)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 9, o valor exibido para a alternativa 'A' será 2% 
                case "Q9":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 2)
                    {
                        A.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 10, o valor exibido para a alternativa 'A' será 80% (alternativa correta)
                case "Q10":
                    pbarA.Value += 1;
                    pbarA.Text = pbarA.Value.ToString() + "%";
                    if (pbarA.Value == 80)
                    {
                        A.Enabled = false;
                    }
                    break;
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Tick(object sender, EventArgs e)
        {
            //Ao entrar em um formulário de pergunta, é trocado o valor da variável Dados.Uni para diferenciar os formulários, assim os universitários terão valores pré-programados diferentes para cada questão.

            switch (Dados.Uni)
            {
                //Se o usuário estiver na questão 1, o valor exibido para a alternativa 'B' será 72% (alternativa correta)
                case "Q1":
                    pbarB.Value += 3;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 72)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 2, o valor exibido para a alternativa 'B' será 12%
                case "Q2":
                    pbarB.Value += 1;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 12)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 3, o valor exibido para a alternativa 'B' será 15%
                case "Q3":
                    pbarB.Value += 3;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 15)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 4, o valor exibido para a alternativa 'B' será 88% (alternativa correta)
                case "Q4":
                    pbarB.Value += 4;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 88)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 5, o valor exibido para a alternativa 'B' será 7%
                case "Q5":
                    pbarB.Value += 1;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 7)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 6, o valor exibido para a alternativa 'B' será 13%
                case "Q6":
                    pbarB.Value += 1;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 13)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 7, o valor exibido para a alternativa 'B' será 3%
                case "Q7":
                    pbarB.Value += 1;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 3)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 8, o valor exibido para a alternativa 'B' será 12%
                case "Q8":
                    pbarB.Value += 1;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 12)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 9, o valor exibido para a alternativa 'B' será 73% (alternativa correta)
                case "Q9":
                    pbarB.Value += 3;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 73)
                    {
                        B.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 10, o valor exibido para a alternativa 'B' será 3%
                case "Q10":
                    pbarB.Value += 1;
                    pbarB.Text = pbarB.Value.ToString() + "%";
                    if (pbarB.Value == 3)
                    {
                        B.Enabled = false;
                    }
                    break;
            } 
        }

        private void C_Tick(object sender, EventArgs e)
        {
            //Ao entrar em um formulário de pergunta, é trocado o valor da variável Dados.Uni para diferenciar os formulários, assim os universitários terão valores pré-programados diferentes para cada questão.

            switch (Dados.Uni)
            {
                //Se o usuário estiver na questão 1, o valor exibido para a alternativa 'C' será 8%
                case "Q1":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 8)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 2, o valor exibido para a alternativa 'C' será 11%
                case "Q2":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 11)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 3, o valor exibido para a alternativa 'C' será 13%
                case "Q3":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 13)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 4, o valor exibido para a alternativa 'C' será 3%
                case "Q4":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 3)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 5, o valor exibido para a alternativa 'C' será 70% (alternativa correta)
                case "Q5":
                    pbarC.Value += 7;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 70)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 6, o valor exibido para a alternativa 'C' será 4%
                case "Q6":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 4)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 7, o valor exibido para a alternativa 'C' será 2%
                case "Q7":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 2)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 8, o valor exibido para a alternativa 'C' será 21%
                case "Q8":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 21)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 9, o valor exibido para a alternativa 'C' será 21%
                case "Q9":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 21)
                    {
                        C.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 10, o valor exibido para a alternativa 'C' será 11%
                case "Q10":
                    pbarC.Value += 1;
                    pbarC.Text = pbarC.Value.ToString() + "%";
                    if (pbarC.Value == 11)
                    {
                        C.Enabled = false;
                    }
                    break;
            }
        }

        private void D_Tick(object sender, EventArgs e)
        {
            //Ao entrar em um formulário de pergunta, é trocado o valor da variável Dados.Uni para diferenciar os formulários, assim os universitários terão valores pré-programados diferentes para cada questão.

            switch (Dados.Uni)
            {
                //Se o usuário estiver na questão 1, o valor exibido para a alternativa 'D' será 13%
                case "Q1":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 13)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 2, o valor exibido para a alternativa 'D' será 9%
                case "Q2":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 9)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 3, o valor exibido para a alternativa 'D' será 77% (alternativa correta)
                case "Q3":
                    pbarD.Value += 7;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 77)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 4, o valor exibido para a alternativa 'D' será 5%
                case "Q4":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 5)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 5, o valor exibido para a alternativa 'D' será 12%
                case "Q5":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 12)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 6, o valor exibido para a alternativa 'D' será 76% (alternativa correta)
                case "Q6":
                    pbarD.Value += 2;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 76)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 7, o valor exibido para a alternativa 'D' será 3%
                case "Q7":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 3)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 8, o valor exibido para a alternativa 'D' será 58% (alternativa correta)
                case "Q8":
                    pbarD.Value += 2;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 58)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 9, o valor exibido para a alternativa 'D' será 2%
                case "Q9":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 2)
                    {
                        D.Enabled = false;
                    }
                    break;

                //Se o usuário estiver na questão 10, o valor exibido para a alternativa 'D' será 6%
                case "Q10":
                    pbarD.Value += 1;
                    pbarD.Text = pbarD.Value.ToString() + "%";
                    if (pbarD.Value == 6)
                    {
                        D.Enabled = false;
                    }
                    break;
            }
        }
    }
}

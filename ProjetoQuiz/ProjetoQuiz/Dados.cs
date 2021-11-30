using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuiz
{
    class Dados
    {
        //Variáveis para definir os acertos e os erros do formulário
        public static int Acerto = 0;
        public static int Erro = 0;

        //Variáveis para desativar os botões de poderes assim que o usuário usar uma vez
        public static bool Usar = false;
        public static bool Usar2 = false;
        public static bool Usar3 = false;

        //Variável para trocar a cor do formulário
        public static string Temas = "Padrão"; 

        //Variável para diferenciar os resultados dos Universitários
        public static string Uni = "Q1";


        public static void Usou()
        {
            Usar = true;
        }

        public static void Usou2()
        {
            Usar2 = true;
        }

        public static void Usou3()
        {
            Usar3 = true;
        }

        public static void Acertou()
        {
            Acerto++;
        }

        public static void Errou()
        {
            Erro++;
        }

        //Variáveis que retornam o valor total de Acertos e Erros no formulário de respostas
        public static int Acertos()
        {
            return Acerto;
        }

        public static int Erros()
        {
            return Erro;
        }


    }
}

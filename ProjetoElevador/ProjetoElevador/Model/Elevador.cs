/*Desenvolvido por: Felipe Francisco Bentes de Araújo*/

using System;

namespace ProjetoElevador
{
    internal class Elevador
    {
        //Variável que armazena a posição atual do elevador: Exp: 10º andar (andar_atual == 10).
        public int andar_atual;

        //Variável que armazena a quantidade de pessoas dentro do elevador: Exp: 5 pessoas (qtd_pessoas == 5).
        public int qtd_pessoas;

        //Variável que armazena a quantidade de andares no prédio: Exp: 500 andares (qtd_andar == 500).
        public readonly int qtd_andar;

        //Variável que armazena a capacidade de pessoas permitidas no elevador: Exp: 8 pessoas (capacidade_elevador == 8).
        public readonly int capacidade_elevador;


        //Classe responsável pela inicialização das variáveis 
        public Elevador(int capacidade, int andar)
        {
            qtd_andar = andar;
            capacidade_elevador = capacidade;
        }

        //Método responsável por adicionar uma pessoa ao elevador
        public void Entrar()
        {
            /*Caso o número de pessoas dentro do elevador for menor que a capacidade, estará permitida
            a entrada de mais uma pessoa no elevador: Exp: se qtd_pessoas(4) < capacidade_elevador(5)
            entao adiciona + 1, e qtd_pessoas recebe + 1 (total 5)*/
            if (qtd_pessoas < capacidade_elevador)
            {
                qtd_pessoas++;
                string acumQtdP = qtd_pessoas == 1 ? $"{qtd_pessoas} Pessoa entrou no elevador." : $"{qtd_pessoas} Pessoas entraram no elevador.\n";
                Console.WriteLine(acumQtdP);
                /*A variável acumQtdP guarda o total de pessoas que entraram no elevador
                 ela incrementa sempre mais uma (+1) pessoa para a qtd_pessoas*/
            }
            else
            {
                //Menssagem para o usuário informando que o elevador atingiu sua capacidade máxima
                Console.WriteLine($"O elevador chegou a sua capacidade máxima de {capacidade_elevador} pessoas.\n");
            }
        }

        //Método responsável por remover uma pessoa do elevador
        public void Sair()
        {
            if (qtd_pessoas > 0)
            {
                qtd_pessoas--;
                Console.WriteLine("Uma pessoa saiu do elevador.\n");
            }
            else
            {
                Console.WriteLine("O elevador está vazio.\n");
            }
        }

        //Método responsável pra subir o elevador por andar 
        public void Subir()
        {
            if (andar_atual < qtd_andar)
            {
                andar_atual++;
                string mostrarAndarAtual = andar_atual != 0 ? $"O elevador chegou ao {andar_atual}º andar." : $"Descendo para o {andar_atual}º andar.\n";
                Console.WriteLine(mostrarAndarAtual);
            }
            else
            {
                Console.WriteLine($"O elevador já está no {andar_atual}º e último andar!\n");
            }
        }

        //Método responsável por descer o elevador por andar
        public void Descer()
        {
            if (andar_atual > 0)
            {
                andar_atual--;
                string exibirAndar = andar_atual == 0 ? $"O elevador chegou no térreo." : $"Descendo para o {andar_atual}º andar.\n";
                Console.WriteLine(exibirAndar);
            }
            else
            {
                Console.WriteLine("O elevador está no térreo!\n");
            }
        }
    }
}

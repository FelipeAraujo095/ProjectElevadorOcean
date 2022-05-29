/*Desenvolvido por: Felipe Francisco Bentes de Araújo*/

using System;

namespace ProjetoElevador.View
{
    internal class Elevador_Visualizacao
    {

        //Método de exibição do menu de opções para o usuário
        public void Projeto(Elevador elevador)
        {
            var continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nQuantidade de andares: "+elevador.qtd_andar);
                Console.WriteLine("\nCapacidade máxima do elevador: "+(elevador.capacidade_elevador <= 1 ? elevador.capacidade_elevador + " pessoa"
                    : elevador.capacidade_elevador + " pessoas"));
                Console.WriteLine("\nQuantidade atual de pessoa (as) no elevador: "+(elevador.qtd_pessoas <= 1 ? elevador.qtd_pessoas + " pessoa "
                    : elevador.qtd_pessoas + " pessoas")+"| Posição atual: "+(elevador.andar_atual == 0 ? "Térreo" : elevador.andar_atual + "º"));
                Console.WriteLine($@"Escolha e informe uma das opções do elevador: { Environment.NewLine }
                                        1 - Entrar no elevador
                                        2 - Sair do elevador
                                        3 - Subir um andar 
                                        4 - Descer um andar 
                                        5 - Finalizar o simulador
                ");

                var opcao = Console.ReadLine();
                            Console.Clear();

                switch (opcao)
                {
                    case "1":
                        //Caso a opção selecionada for 1, chamaremos o método Entrar(), onde quem está fora pode entrar.
                        elevador.Entrar();
                        break;

                    case "2":
                        //Caso a opção selecionada for 2, chamaremos o método Sair(), onde quem está detro pode sair.
                        elevador.Sair();
                        break;

                    case "3":
                        //Caso a opção selecionada for 3, chamaremos o método Subir(), onde quem está no térreo pode subir para outro andar
                        elevador.Subir();
                        break;

                    case "4":
                        //Caso a opção selecionada for 4, chamaremos o método Descer(), onde quem está no 2 andar pode descer para o 1
                        elevador.Descer();
                        break;

                    case "5":
                        //caso a opção selecionada for 5, encerraremos a aplicação
                        Console.WriteLine("Aplicação encerrada");
                        continuar = false;
                        break;

                    default:
                        //Caso nenhuma opção for válida, aparecerá uma menssagem para o usuário informando opção inválida
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}

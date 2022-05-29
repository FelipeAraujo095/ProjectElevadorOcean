/*Desenvolvido por: Felipe Francisco Bentes de Araújo*/

using ProjetoElevador.View;
using System;

namespace ProjetoElevador.Controller
{
    internal class Elevador_Controle
    {
        /*Método de inicialização do processo de funcionamento do elevador
         onde o usuário vai informar a quantidade de andares do prédio e a
        capacidade de pessoas que o elevador comporta*/
        public void Initialize()
        {
            Console.WriteLine("=====================| Projeto Elevador 2022 |=====================");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Projeto final do curso: Formação Microsoft - DEV (terceira turma 2022)");
            Console.WriteLine("         xxxxxxxxxx| Por favor informar quantidade   |xxxxxxxxxx");
            Console.WriteLine("         xxxxxxxxxx| de andares.                     |xxxxxxxxxx");
            var qtd_andar = int.Parse(Console.ReadLine());

            Console.WriteLine("\nxxxxxxxxxx| Informar capacidade do elevador (pessoas) |xxxxxxxxxx");
            var capacidade = int.Parse(Console.ReadLine());

            Console.Clear();

            var elevador = new Elevador(capacidade, qtd_andar);

            var elevadorView = new Elevador_Visualizacao();

            elevadorView.Projeto(elevador);
        }
    }
}

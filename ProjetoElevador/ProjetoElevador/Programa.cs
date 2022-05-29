/*Desenvolvido por: Felipe Francisco Bentes de Araújo*/

using ProjetoElevador.Controller;

namespace ProjetoElevador
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            //Aqui ele faz o chamado para o método de inicializar o processo do elevador.
                var controllerElevador = new Elevador_Controle();
                controllerElevador.Initialize();
            
        }
    }
}
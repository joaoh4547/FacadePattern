using FacadePattern.Interfaces;
using System;

namespace FacadePattern
{
    public class FornecedorPizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando Pizza Normal");
            Console.WriteLine();
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Busacando Pizza vegana");
            Console.WriteLine();

        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizza não veganas.");
           
        }
    }
}

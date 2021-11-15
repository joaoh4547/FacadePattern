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
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Busacando Pizza vegana");
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizza não veganas.");
        }
    }
}

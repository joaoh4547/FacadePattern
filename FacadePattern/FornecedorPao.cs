using FacadePattern.Interfaces;
using System;

namespace FacadePattern
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Obtendo Pão de alho");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo Pão de alho com queijo");
        }
        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo Queijo");
        }
    }
}

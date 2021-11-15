using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class RestaurenteFacade
    {
        private IPizza _fornecedorPizza;
        private IPao _fornecedorPao;

        public RestaurenteFacade()
        {
            _fornecedorPizza = new FornecedorPizza();
            _fornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzaNormal()
        {
            _fornecedorPizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _fornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoDeAlho()
        {
            _fornecedorPao.BuscarPaoDeAlho();
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            _fornecedorPao.BuscarPaoDeAlhoComQueijo();
        }
    }
}

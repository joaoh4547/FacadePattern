using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var restauranteFacade = new RestaurenteFacade();
            restauranteFacade.BuscarPizzaNormal();
            restauranteFacade.BuscarPizzaVegana();
            restauranteFacade.BuscarPaoDeAlho();
            restauranteFacade.BuscarPaoDeAlhoComQueijo();
        }
    }
}

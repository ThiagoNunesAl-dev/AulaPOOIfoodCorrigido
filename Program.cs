using System;

namespace AulaPOOIfoodAjuste
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente thiago = new Cliente("Thiago");
            thiago.Endereco = "Rua Aleatória";
            Restaurante bk = new Restaurante("Burger King", "Rua 12");

            Pedido pedido = new Pedido();
            pedido.Cliente = thiago;
            pedido.Restaurante = bk;

            Console.WriteLine( pedido.EntregarPedido() );
        }
    }
}

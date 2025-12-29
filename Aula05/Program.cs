namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculando lucro e formatando a saída
            double valorCompra = 5.50;
            double lucro = 0.4;
            double valorVenda = valorCompra+(valorCompra*lucro);
            string produto = "Pastel";

            Console.WriteLine($"Produto..........:{produto,15}");
            Console.WriteLine($"Valor da Compra..:{valorCompra,15:c}");
            Console.WriteLine($"Valor de Venda...:{valorVenda,15:c}");
            Console.WriteLine($"Lucro............:{valorVenda-valorCompra,15:c}");
        }
    }
}
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Imposto iss = new ISS(new ImpostoAlto());
            Orcamento orcamento = new Orcamento(1000);
            double valor = iss.Calcula(orcamento);
            Console.WriteLine(valor);

            Console.ReadKey();

        }
    }
}

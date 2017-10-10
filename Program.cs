using System;

namespace Projeto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            string mensagem = ("O rodízio do seu veículo será na ");

            switch(placa)
            {
                case "1":
                case "2":
                    Console.WriteLine(mensagem + "Segunda-feira.");
                break;
                case "3":
                case "4":
                    Console.WriteLine(mensagem + "Terça-feira.");
                break;
                case "5":
                case "6":
                    Console.WriteLine(mensagem + "Quarta-feira.");
                break;
                case "7":
                case "8":
                    Console.WriteLine(mensagem + "Quinta-feira.");
                break;
                case "9":
                case "0":
                    Console.WriteLine(mensagem + "Sexta-feira.");
                break;

            }

            Console.WriteLine("Obrigado. Volte sempre.");

        }
    }
}

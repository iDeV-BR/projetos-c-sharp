using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apresentação do programa
            Console.WriteLine("[--------------------------SISTEMA DE TEMPERATURA----------------------]");
            Console.WriteLine("[---------------------------V1.0 by.IagoDev----------------------------]");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Converter de Celsius para Fahrenheit:");
            Console.WriteLine("2. Converter de Fahrenheit para Celsius:");

            // Leitura da opção escolhida pelo usuário
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                // Chama a função para converter Celsius para Fahrenheit
                double fahrenheit = CelsiusParaFahrenheit(celsius);
                Console.WriteLine($"A Temperatura em Fahrenheit é: {fahrenheit}°F");
            }
            else if (escolha == 2)
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                // Chama a função para converter Fahrenheit para Celsius
                double celsius = FahrenheitParaCelsius(fahrenheit);
                Console.WriteLine($"A Temperatura em Celsius é: {celsius}°C");
            }
            else
            {
                // Mensagem de erro para opção inválida
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("");
            }
        }

        // Função para converter Celsius para Fahrenheit
        static double CelsiusParaFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        // Função para converter Fahrenheit para Celsius
        static double FahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

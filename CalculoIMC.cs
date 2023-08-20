using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita o peso do usuário e armazena na variável 'peso'
            Console.WriteLine("Digite o peso do usuário (em kg):");
            double peso = Convert.ToDouble(Console.ReadLine());

            // Solicita a altura do usuário e armazena na variável 'altura'
            Console.WriteLine("Digite a altura do usuário (em metros):");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcula o IMC utilizando a fórmula IMC = peso / (altura * altura)
            double imc = peso / (altura * altura);

            // Exibe o valor do IMC na tela, com formatação para 2 casas decimais
            Console.WriteLine($"IMC do usuário: {imc:F2}");

            // Verifica se o IMC é maior ou igual a 25
            if (imc >= 25)
            {
                Console.WriteLine("Usuário acima do peso.");
            }
            // Caso o IMC seja menor que 25, exibe mensagem indicando que o usuário está dentro do peso desejado
            else
            {
                Console.WriteLine("Usuário dentro do peso desejado.");
            }
        }
    }
}

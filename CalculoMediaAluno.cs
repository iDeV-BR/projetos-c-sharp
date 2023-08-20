using System;

namespace CalculoMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita a primeira nota ao usuário e armazena na variável 'nota1'
            Console.WriteLine("Digite a primeira nota do aluno:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            // Solicita a segunda nota ao usuário e armazena na variável 'nota2'
            Console.WriteLine("Digite a segunda nota do aluno:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            // Calcula a média das duas notas
            double media = (nota1 + nota2) / 2;

            // Exibe a média na tela
            Console.WriteLine($"Média do aluno: {media}");

            // Verifica se a média é maior ou igual a 7
            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            // Caso a média não seja maior ou igual a 7, verifica se é maior ou igual a 5
            else if (media >= 5)
            {
                Console.WriteLine("Aluno em recuperação.");
            }
            // Se a média for menor que 5, o aluno é reprovado
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}

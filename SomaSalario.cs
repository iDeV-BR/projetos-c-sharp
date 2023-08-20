using System;

namespace SomaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apresentação do programa
            Console.WriteLine("---------SOMA DE SALARIO---------");
            Console.WriteLine("Digite o valor do salário do funcionário: ");
            
            // Lê o valor do salário inserido pelo usuário
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            // Define a porcentagem de aumento como 5% (0.05)
            decimal porcentagem = 0.05m; 

            // Calcula o valor do aumento baseado na porcentagem
            decimal aumento = salario * porcentagem;

            // Calcula o novo salário somando o aumento ao salário original
            decimal salariofinal = salario + aumento;

            // Exibe informações sobre o salário original, aumento e novo salário
            Console.WriteLine("Salário Antigo: " + salario);
            Console.WriteLine("Aumento: " + aumento);
            Console.WriteLine("Novo Salário: " + salariofinal);
        }
    }   
}

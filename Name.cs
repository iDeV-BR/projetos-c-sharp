using System;

namespace SystemName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que digite um número (1 ou 2)
            Console.WriteLine("Digite número 1 ou 2:");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            // Verifica se o número digitado é igual a 1
            if (numero == 1)
               Console.WriteLine("Nome encontrado: Iago Dev");
            
            // Se o número digitado não for 1, verifica se é igual a 2
            else if (numero == 2)
                Console.WriteLine("Nome não encontrado");
            
            // Se o número não for nem 1 nem 2, exibe mensagem de opção inválida
            else
                Console.WriteLine("Opção Invalida!");
        }
    }
}

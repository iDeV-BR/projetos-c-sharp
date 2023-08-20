using System;
using System.Collections.Generic;

class Cliente
{
    // Definição da classe Cliente com propriedades
    public string Nome { get; set; }
    public string CPF { get; set; }
    public int Idade { get; set; }
    public string Telefone { get; set; }
    public string Sexo { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
}  

class Program
{
    static void Main(string[] args)
    {
        // Apresentação do programa
        Console.WriteLine("[----------------------------SISTEMA DE CADASTRO--------------------------------]");
        Console.WriteLine("[------------------------------V.1.0 by IagoDeV---------------------------------]");
        
        // Lista para armazenar os clientes cadastrados
        List<Cliente> listaClientes = new List<Cliente>();

        // Loop para cadastro de clientes
        while (true)
        {
            Cliente novoCliente = new Cliente();

            // Solicita a idade do cliente e verifica se é maior de idade
            while (true)
            {
                Console.WriteLine("Idade (Cadastro Permitido Somente para maior de idade!)");
                novoCliente.Idade = Convert.ToInt32(Console.ReadLine());
                
                if (novoCliente.Idade >= 18)
                    break;
                else 
                    Console.WriteLine("Idade Não Permitida!");
            }

            // Solicita os dados do cliente
            Console.Write("Nome: ");
            novoCliente.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            novoCliente.CPF = Console.ReadLine();

            Console.Write("Sexo: ");
            novoCliente.Sexo = Console.ReadLine();

            Console.Write("Telefone: ");
            novoCliente.Telefone = Console.ReadLine();

            Console.Write("Endereço: ");
            novoCliente.Endereco = Console.ReadLine();

            Console.Write("Cidade: ");
            novoCliente.Cidade = Console.ReadLine();
            
            Console.Write("Estado: ");
            novoCliente.Estado = Console.ReadLine();

            // Adiciona o novo cliente à lista de clientes
            listaClientes.Add(novoCliente);

            // Pergunta se deseja cadastrar outro cliente
            Console.Write("Deseja cadastrar outro cliente? (s/n): ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() != "s")
                break;
        }

        // Exibe a lista de clientes cadastrados
        Console.WriteLine("\nLista de Clientes Cadastrados:");
        foreach (var cliente in listaClientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Endereço: {cliente.Endereco}");
            Console.WriteLine($"Idade: {cliente.Idade}");
            Console.WriteLine($"Sexo: {cliente.Sexo}");
            Console.WriteLine($"Cidade: {cliente.Cidade}");
            Console.WriteLine($"Estado: {cliente.Estado}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            Console.WriteLine();
        }
    }
}

using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clientes = new Cliente();

            foreach (Cliente cliente in clientes.GetListaClientes())
            {
                Console.WriteLine("ID: " + cliente.id);
                Console.WriteLine("ID_EMPRESA: " + cliente.empresa);
                Console.WriteLine("NOME: " + cliente.nome);
                Console.WriteLine("EMAIL: " + cliente.email);
                Console.WriteLine("TELEFONE: " + cliente.telefone);
                Console.WriteLine("DOCUMENTO: " + cliente.documento);
                Console.WriteLine("DATA DO CADASTRO: " + cliente.data_cadastro);

                Console.ReadLine();
            }

            Console.WriteLine("--------------------------------------------------- \n");

            Funcionarios funcionarios = new Funcionarios();

            foreach (Funcionarios funcionario in funcionarios.GetListaFuncionarios())
            {
                Console.WriteLine("ID: " + funcionario.id);
                Console.WriteLine("ID_EMPRESA: " + funcionario.empresa);
                Console.WriteLine("NOME: " + funcionario.nome);
                Console.WriteLine("EMAIL: " + funcionario.email);
                Console.WriteLine("SENHA: " + funcionario.senha);
                Console.WriteLine("NIVEL: " + funcionario.nivel);
                Console.WriteLine("DATA DO CADASTRO: " + funcionario.data_cadastro);

                Console.ReadLine();
            }
        }
    }
}
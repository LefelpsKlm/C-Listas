using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Funcionarios : Conexao
    {
        public int id;

        public int empresa;

        public string nome;

        public string email;

        public string senha;

        public string nivel;


        public DateTime data_cadastro;

        public void setFuncionario(string senha)
        {
            this.senha = senha;
        }

        public string getFuncionario()
        {
            return "Meu documento é" + this.senha;
        }

        public List<Funcionarios> GetListaFuncionarios()
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionario;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionarios novoFuncionario = new Funcionarios();

                            novoFuncionario.id = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionario.empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionario.nome = reader.GetString("nome");
                            novoFuncionario.email = reader.GetString("email");
                            novoFuncionario.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoFuncionario.setFuncionario(reader.GetString("senha"));

                            funcionarios.Add(novoFuncionario);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return funcionarios;
        }
    }
}

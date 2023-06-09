﻿using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace PizzariaDoZe_DAO
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string Nome { get; set; }
        public Ingrediente(int id = 0, string nome = "")
        {
            IdIngrediente = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
    public class IngredienteDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public IngredienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDbProvider(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";

            nome.Value = ingrediente.Nome; comando.Parameters.Add(nome);

            conexao.Open();

            comando.CommandText = @"INSERT INTO cad_ingredientes(descricao_ingrediente) VALUES (@nome)";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using
        }

        public DataTable Buscar(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (ingrediente.IdIngrediente > 0)
            {
                auxSqlFiltro = "WHERE i.id_ingrediente = " + ingrediente.IdIngrediente + " ";
            }
            else if (ingrediente.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.nome like '%" + ingrediente.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_ingrediente AS ID, i.descricao_ingrediente AS Nome " +
            "FROM cad_ingredientes AS i " +
            auxSqlFiltro +
            "ORDER BY i.descricao_ingrediente;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

    }
}

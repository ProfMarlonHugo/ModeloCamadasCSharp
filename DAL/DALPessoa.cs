using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;

namespace DAL
{
    /* Data Access Layer para a tabela pessoa*/
    public class DALPessoa
    {
        private DALConexao conexao;

        public DALPessoa (DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir (MODELOPassoa modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO Pessoa (id, nome, dataNascimento, sexo, email, cpf)" +
                "VALUES (NULL, @nome, @dt, @sexo, @email, @cpf); ";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@dt", modelo.DataNascimento);
            cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);

            conexao.Conectar();
            int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
            modelo.Id = idInserido;

            conexao.Desconectar();


        }
    }
}

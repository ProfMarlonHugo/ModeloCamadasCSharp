using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;
using System.Data;

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
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Pessoa (id, nome, dataNascimento, sexo, email, cpf)" +
                    "VALUES (NULL, @nome, @dt, @sexo, @email, @cpf);" +
                    "SELECT MAX(ID) FROM Pessoa;";
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@dt", modelo.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
                cmd.Parameters.AddWithValue("@email", modelo.Email);
                cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.Id = idInserido;
            }
            catch(MySqlException e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }

        public void Alterar(MODELOPassoa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE Pessoa SET nome = @nome," +
                                  " dataNascimento = @dataNascimento," +
                                  " sexo = @sexo," +
                                  " email = @email," +
                                  " cpf = @cpf"+
                                  " WHERE "+
                                  " id = @id";
                string data = modelo.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@dataNascimento", data); 
                cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
                cmd.Parameters.AddWithValue("@email", modelo.Email);
                cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
                cmd.Parameters.AddWithValue("@id", modelo.Id);

                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;

                cmd.CommandText = "DELETE FROM Pessoa WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public DataTable Localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT * FROM Pessoa WHERE nome LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

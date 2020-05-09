using MySql.Data.MySqlClient;

/* Data Access Layer*/
namespace DAL
{
    public class DALConexao
    {
        private string strConexao;
        private MySqlConnection conexao;

        public DALConexao(string dadosConexao)
        {
            conexao = new MySqlConnection();
            strConexao = dadosConexao;
            conexao.ConnectionString = dadosConexao;
        }

        public MySqlConnection ObjetoConexao
        {
            get { return conexao; }
            set { conexao = value; }
        }

        public void Conectar()
        {
            conexao.Open();
        }

        public void Desconectar()
        {
            conexao.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Data Access Layer*/
namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "remotemysql.com";
        private string port = "3306";
        private string user = "eJR0qqPKWe";
        private string pass = "CUVmumuZmC";
        private string database = "eJR0qqPKWe";

        public string StringDeConexao
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id= " + this.user + ";" +
                       "Password=" + this.pass + ";" +
                       "database= " + this.database + ";";
            }
        }

    }
}

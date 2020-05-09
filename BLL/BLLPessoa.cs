using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using BLL;

/* Business Logic Layer*/
namespace BLL
{
    public class BLLPessoa
    {
        private DALPessoa DALobj;

        public BLLPessoa( DALConexao cx)
        {
            DALobj = new DALPessoa(cx);
        }

        public void Incluir (MODELOPassoa modelo)
        {
            DALobj.Incluir(modelo);
        }
    }
}

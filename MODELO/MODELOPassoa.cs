using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOPassoa
    {
        /*Atributos da tabela Pessoa*/
        private Int32 id;
        private string nome;
        private DateTime dataNascimento;
        private string sexo;
        private string email;
        private string cpf;
        private byte[] foto;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;

                FileInfo arqImagem = new FileInfo(imgCaminho);
                FileStream fs = new FileStream(imgCaminho, FileMode.Open,
                    FileAccess.Read, FileShare.Read);
                Foto = new byte[Convert.ToInt32(arqImagem.Length)];
                int IBytes = fs.Read(Foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /*Transformar arquivo em Bytes em uma imagem*/
        public Bitmap getImagem()
        {
            MemoryStream mStream = new MemoryStream();
            mStream.Write(Foto, 0, Convert.ToInt32(Foto.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}

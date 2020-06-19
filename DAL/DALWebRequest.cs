using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALWebRequest
    {
        private string urlRegiao = "https://servicodados.ibge.gov.br/api/v1/localidades/regioes?orderBy=nome";
        private string urlEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/regioes/";
        private string urlMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/";

        public string buscarRegiao()
        {
            WebRequest request = WebRequest.Create(urlRegiao);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ContentType = "application/json; charset=utf-8";

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
        }

        public string buscarEstados(int idregiao)
        {
            //3/estados
            WebRequest request = WebRequest.Create(
                urlEstado + idregiao + "/estados?orderBy=nome");
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ContentType = "application/json; charset=utf-8";

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
        }

        public string buscarMunicipios(int idEstado)
        {
            // 33/municipios
            WebRequest request = WebRequest.Create(
                urlMunicipio + idEstado + "/municipios?orderBy=nome");
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ContentType = "application/json; charset=utf-8";

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
        }
    }
}

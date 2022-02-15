#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using SIESC.WEB.consultaCep;

namespace SIESC.WEB
{
    /// <summary>
    /// Classe para consulta de CEP
    /// </summary>
    public class BuscaCep
    {
        /// <summary>
        /// Faz a pesquisa em um webservice do cep. 
        /// Retorna cidade, bairro, logradouro e tipo de logradouro modificadas.
        /// Utiliza os sites republicavirtual.com.br e viacep.com.br
        /// </summary>
        /// <param name="cep">O CEP a ser pesquisado</param>
       public string[] BuscadorAlternativo(string cep)
        {
            try
            {
                var endereco = new string[3];

                //alternativo http://cep.republicavirtual.com.br/web_cep.php?cep=32604170cep&formato=xml
                //outro alternativo https://api.postmon.com.br/v1/cep/32605100?format=xml
                //https://viacep.com.br/ws/32605100/json/

                WebRequest request = WebRequest.Create("https://viacep.com.br/ws/@cep/xml/".Replace("@cep", cep));

                request.Timeout = 20000;

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {

                        XDocument document = XDocument.Load(new StreamReader(stream ?? throw new InvalidOperationException("Stream não é válido!")));

                        try
                        {
                            XElement xElementlogradouro = document.Descendants("logradouro").First();
                            XElement xElementbairro = document.Descendants("bairro").First();

                            XElement xElementLocalidade = document.Descendants("localidade").First();
                            
                            if(xElementLocalidade.Value != "Betim")
                                throw new Exception($"CEP {cep} não foi encontrado ou não pertence a Betim!\nPor favor digite o endereço.");
                            
                            endereco[0] = ObterStringSemAcentosECaracteresEspeciais(xElementbairro.Value.ToUpper());

                            var logradouro = xElementlogradouro.Value.ToUpper();

                            var tipo = logradouro.Split(' ');

                            endereco[1] = tipo[0];

                            var pos = logradouro.IndexOf(' ') + 1;

                            endereco[2] = logradouro.Substring(pos, logradouro.Length - pos);
                        }
                        catch (Exception e)
                        {
                            throw new Exception($"Cep {cep} não foi encontrado!\nPor favor digite o endereço.\n{e.Message}");
                        }
                    }
                }
                return endereco;
            }
            catch (WebException erro)
            {
                throw new WebException("Não foi possível acessar o WebService!\n" + erro.Message + "\nVerifique sua conexão de rede.");
            }
            catch (XmlException erro)
            {
                throw new XmlException(erro.Message);
            }
        }

        /// <summary>
        /// Retira os acentos e caracteres especiais
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ObterStringSemAcentosECaracteresEspeciais(string str)
        {
            /** Troca os caracteres acentuados por não acentuados
             * fonte: https://pt.stackoverflow.com/questions/25924/regex-remo%C3%A7%C3%A3o-de-caracteres-especiais-c *
             */
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }
            return str.Trim();
        }

        /// <summary>
        /// Faz a pesquisa em um webservice do cep.
        /// retorna a cidade, bairro, logradoruo e o tipo de logradouro na forma de um array
        /// de strings. [0] bairro | [2] logradouro
        /// </summary>
        /// <param name="cep">O cep que se deseja localizar a endereço</param>
        /// <returns>Array de string contendo o endereço. [0] bairro | [2] logradouro </returns>
        public string[] BuscadorAlternativo2(string cep)
        {
            string[] saida = new string[6];

            WebRequest request = WebRequest.Create("https://viacep.com.br/ws/@cep/xml/".Replace("@cep", cep));

            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    XDocument document = XDocument.Load(new StreamReader(stream ?? throw new InvalidOperationException()));

                    try
                    {
                        XElement xElementlogradouro = document.Descendants("logradouro").First();
                        XElement xElementbairro = document.Descendants("bairro").First();

                        saida[0] = xElementbairro.Value;
                        saida[1] = string.Empty;
                        saida[2] = xElementlogradouro.Value;
                        saida[3] = string.Empty;
                        saida[4] = string.Empty;
                        saida[5] = string.Empty;
                    }
                    catch (Exception)
                    {
                        throw new Exception("Cep não encontrado!Por favor digite o endereço.");
                    }
                }
            }
            return saida;
        }

        ///// <summary>
        ///// Consulta de logradouro através do CEP no WebService da PMB
        ///// </summary>
        ///// <param name="cep">O cep para consulta</param>
        ///// <param name="cboBairro"></param>
        ///// <param name="txtLogradouro"></param>
        ///// <param name="cboTipologradouro"></param>
        //public Endereco[]  buscadorCEP(string cep)
        //{
        //    try
        //    {
        //        ServicoCEP srv = new ServicoCEP {Timeout = 20000};


        //        Endereco[] enderecos = srv.ObterEnderecoPorCEP(cep);

        //        // txtLogradouro.ResetText();
        //        // cboTipologradouro.ResetText();


        //        if (enderecos == null || !enderecos[0].Cidade.Equals("BETIM"))
        //        {
        //            //cboBairro.SelectedIndex = -1;
        //            throw new Exception("CEP não encontrado ou não pertence a Betim!\nPor favor digite o endereço.");
        //        }
                
        //        //localiza o item bairro na combo
        //        //foreach (DataRowView item in cboBairro.Items)
        //        //{
        //        //    if (item["nomeBairro"].ToString() == enderecos[0].Bairro)
        //        //        cboBairro.SelectedIndex = cboBairro.Items.IndexOf(item);
        //        //}

        //        return enderecos;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

            
        //}

        /// <summary>
        /// Consulta de logradouro através do CEP no WebService da PMB
        /// </summary>
        /// <param name="cep">O cep para consulta</param>
        public Endereco[] buscadorCEP(string cep)
        {
            ServicoCEP srv = new ServicoCEP();
            srv.Timeout = 15000;

            Endereco[] enderecos = srv.ObterEnderecoPorCEP(cep);

            if (enderecos == null || !enderecos[0].Cidade.Equals("BETIM"))
                throw new Exception("CEP não encontrado ou não pertence a Betim!\nPor favor digite o endereço.");
            
            return enderecos;
        }

        /// <summary>
        /// Retorna os Ceps de um logradouro
        /// </summary>
        /// <param name="logradouro">Nome do logradouro</param>
        /// <param name="codigoCidade">Código da Cidade</param>
        /// <param name="estado">Estado</param>
        /// <returns>Array de endereços</returns>
        public Endereco[] RetornaCEPS(string logradouro, int codigoCidade, string estado)
        {
            ServicoCEP srv = new ServicoCEP();

            Endereco[] enderecos = srv.ObterEnderecoPorLogradouro(logradouro, codigoCidade,estado, null);

            if (enderecos == null)
                throw new NullReferenceException(
                    "Endereço não localizado!\nVerifique o nome do logradouro ou a cidade.");

            return enderecos;
        }

        /// <summary>
        /// Retorna as cidades de acordo com 
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public Endereco[] RetornaCidades(string estado)
        {
            ServicoCEP servicoCep = new ServicoCEP();

            if (estado != null)
            {
                Endereco[] enderecos = servicoCep.ObterCidadesPorEstado(estado);

                return enderecos;
            }
            return null;
        }
    }
}

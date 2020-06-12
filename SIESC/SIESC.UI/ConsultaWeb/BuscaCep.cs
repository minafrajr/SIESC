#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using SIESC.UI.tecnologia1;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using static System.StringSplitOptions;


namespace SIESC.UI
{
    /// <summary>
    /// Classe para consulta de CEP
    /// </summary>
    class BuscaCep
    {
        /// <summary>
        /// Faz a pesquisa em um webservice do cep. 
        /// Retorna cidade, bairro, logradouro e tipo de logradouro modificadas.
        /// Utiliza os sites republicavirtual.com.br e viacep.com.br
        /// </summary>
        /// <param name="cep">O CEP a ser pesquisado</param>
        /// <param name="cidade"></param>
        /// <param name="bairro"></param>
        /// <param name="logradouro"></param>
        /// <param name="tipologradouro"></param>
        public void buscadorAlternativo(string cep, MyComboBox bairro, MyTextBox logradouro, MyComboBox tipologradouro)
        {
            try
            {
                //alternativo http://cep.republicavirtual.com.br/web_cep.php?cep=32604170cep&formato=xml
                //ourtro alternativo https://api.postmon.com.br/v1/cep/32605100?format=xml
                //https://viacep.com.br/ws/32605100/json/

                WebRequest request = WebRequest.Create("https://viacep.com.br/ws/@cep/xml/".Replace("@cep", cep));

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        XDocument document = XDocument.Load(new StreamReader(stream));

                        try
                        {
                            XElement xElementlogradouro = document.Descendants("logradouro").First();
                            XElement xElementbairro = document.Descendants("bairro").First();

                            bairro.Text = xElementbairro.Value.ToUpper();

                            logradouro.Text = xElementlogradouro.Value.ToUpper();
                            var tipo = logradouro.Text.Split(' ');
                            tipologradouro.Text = tipo[0];

                            var pos = logradouro.Text.IndexOf(' ') + 1;

                            logradouro.Text = logradouro.Text.Substring(pos, logradouro.Text.Length -pos);
                        }
                        catch (Exception e)
                        {
                            throw new Exception($"Cep não encontrado!\nPor favor digite o endereço.\n{e.Message}");
                        }
                    }
                }
            }
            catch (WebException erro)
            {
                throw new WebException("Não foi possível acessar o WebService!\n" + erro.Message +"\nVerifique sua conexão de rede.");
            }
            catch (XmlException erro)
            {
                throw new XmlException(erro.Message);
            }
        }

        /// <summary>
        /// Faz a pesquisa em um webservice do cep.
        /// retorna a cidade, bairro, logradoruo e o tipo de logradouro na forma de um array
        /// de strings. [0] bairro | [2] logradouro
        /// </summary>
        /// <param name="cep">O cep que se deseja localizar a endereço</param>
        /// <returns>Array de string contendo o endereço. [0] bairro | [2] logradouro </returns>
        public string[] buscadorAlternativo(string cep)
        {
            string[] saida = new string[6];

            WebRequest request = WebRequest.Create("https://viacep.com.br/ws/@cep/xml/".Replace("@cep", cep));

            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    XDocument document = XDocument.Load(new StreamReader(stream));

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

        /// <summary>
        /// Consulta de logradouro através do CEP no WebService da PMB
        /// </summary>
        /// <param name="cep">O cep para consulta</param>
        /// <param name="cboBairro"></param>
        /// <param name="txtLogradouro"></param>
        /// <param name="cboTipologradouro"></param>
        public void buscadorCEP(string cep, MyComboBox cboBairro, MyTextBox txtLogradouro, MyComboBox cboTipologradouro)
        {
            ServicoCEP srv = new ServicoCEP();

            srv.Timeout = 5000;
            
            
            Endereco[] enderecos = srv.ObterEnderecoPorCEP(cep);

            txtLogradouro.ResetText();
            cboTipologradouro.ResetText();
            
            
            if (enderecos == null || !enderecos[0].Cidade.Equals("BETIM"))
            {
                cboBairro.SelectedIndex = -1;
                throw new Exception("CEP não encontrado ou não pertence a Betim!\nPor favor digite o endereço.");
            }

            //localiza o item bairro na combo
            foreach (DataRowView item in cboBairro.Items)
            {
                if (item["nomeBairro"].ToString() == enderecos[0].Bairro)
                    cboBairro.SelectedIndex = cboBairro.Items.IndexOf(item);
            }
            
            txtLogradouro.Text = enderecos[0].Logradouro;
            cboTipologradouro.Text = enderecos[0].TipoLogradouro;
        }

        /// <summary>
        /// Consulta de logradouro através do CEP no WebService da PMB
        /// </summary>
        /// <param name="cep">O cep para consulta</param>
        public Endereco[] buscadorCEP(string cep)
        {
            try
            {
                ServicoCEP srv = new ServicoCEP();

                Endereco[] enderecos = srv.ObterEnderecoPorCEP(cep);

                if (enderecos == null)
                    throw new Exception("CEP não encontrado!Por favor digite o endereço.");

                return enderecos;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna os Ceps de um logradouro
        /// </summary>
        /// <param name="logradouro">Nome do logradouro</param>
        /// <param name="codigoCidade">Código da Cidade</param>
        /// <param name="estado">Estado</param>
        /// <param name="numerologradouro">Número do logradouro</param>
        /// <returns></returns>
        public Endereco[] RetornaCEPS(string logradouro, int codigoCidade, string estado)
        {
            try
            {
                ServicoCEP srv = new ServicoCEP();

                Endereco[] enderecos = srv.ObterEnderecoPorLogradouro(logradouro, codigoCidade, estado, null);

                if (enderecos == null)
                    throw new NullReferenceException(
                        "Endereço não localizado!\nVerifique o nome do logradouro ou a cidade.");

                return enderecos;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna as cidades de acordo com 
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public Endereco[] RetornaCidades(string estado)
        {
            try
            {
                ServicoCEP servicoCep = new ServicoCEP();

                if (estado != null)
                {
                    Endereco[] enderecos = servicoCep.ObterCidadesPorEstado(estado);

                    return enderecos;
                }
                return null;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
    }
}

#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using SIESC_UI.tecnologia1;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;


namespace SIESC_UI
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
                //alternativo http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml

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
                            tipologradouro.Text = String.Empty;
                        }
                        catch (Exception)
                        {
                            throw new Exception("Cep não encontrado!\nPor favor digite o endereço.");
                        }
                    }
                }
            }
            catch (WebException erro)
            {
                throw new WebException("Não foi possível acessar o WebService!\n" + erro.Message +
                                       "\nVerifique sua conexão de rede.");
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
                        saida[1] = String.Empty;
                        saida[2] = xElementlogradouro.Value;
                        saida[3] = String.Empty;
                        saida[4] = String.Empty;
                        saida[5] = String.Empty;
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
        /// <param name="bairro">ComboBox do bairro</param>
        /// <param name="logradouro">TextBox do logradouro</param>
        /// <param name="tipologradouro">ComboBox do tipo de logradouro</param>
        public void buscadorCEP(string cep, MyComboBox cbo_bairro, MyTextBox txt_logradouro, MyComboBox cbo_tipologradouro)
        {
            ServicoCEP srv = new ServicoCEP();

            Endereco[] enderecos = srv.ObterEnderecoPorCEP(cep);

            txt_logradouro.ResetText();
            cbo_tipologradouro.ResetText();
            
            
            if (enderecos == null || !enderecos[0].Cidade.Equals("BETIM"))
            {
                cbo_bairro.SelectedIndex = -1;
                throw new Exception("CEP não encontrado ou não pertence a Betim!\nPor favor digite o endereço.");
            }

            //localiza o item bairro na combo
            foreach (DataRowView item in cbo_bairro.Items)
            {
                if (item["nomeBairro"].ToString() == enderecos[0].Bairro)
                    cbo_bairro.SelectedIndex = cbo_bairro.Items.IndexOf(item);
            }
            
            txt_logradouro.Text = enderecos[0].Logradouro;
            cbo_tipologradouro.Text = enderecos[0].TipoLogradouro;
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

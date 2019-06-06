using System.Security.Cryptography;
using System.Text;

namespace SIESC_BD.Control
{
	internal class Criptografia
	{
		public string criptografaMD5(string input)
		{

			MD5 md5Hash = MD5.Create(); //instãncia da classe

			byte[] inputBytes = Encoding.ASCII.GetBytes(input); //transformando em bytes a mensagem

			byte[] hash = md5Hash.ComputeHash(inputBytes); //retornando os bytes criptografados

			// Segundo passo, converter o array de bytes em uma string haxadecimal
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("X2"));
			}

			return sb.ToString();
		}
	}
}

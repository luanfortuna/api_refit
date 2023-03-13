using Refit;

namespace ProjetoRefit
{

	class Program
	{


		static async Task Main(string[] args)
		{
			try
			{
				var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");

				Console.WriteLine("Informe seu CEP:");

				string cepInformado = Console.ReadLine().ToString();
				Console.WriteLine("Consultando informações do CEP: " + cepInformado);

				//chamada ao refit abaixo:

				var address = await cepClient.GetAddressAsync(cepInformado);

				Console.WriteLine($"\nLogradouro:{address.Logradouro} \nBairro: {address.Bairro} \nCidade:{address.Localidade} \nIbge:{address.Ibge}");

				Console.ReadKey();


			}
			catch(Exception e)
			{

				Console.WriteLine("Erro ao consultar o CEP" + e.Message);
			
			}
		}




	}







}

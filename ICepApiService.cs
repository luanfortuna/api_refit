using Refit;

namespace ProjetoRefit
{
	public interface ICepApiService
	{
		[Get("/ws/{cep}/json")]
		Task<CepResponse> GetAddressAsync(string cep);

	}
}

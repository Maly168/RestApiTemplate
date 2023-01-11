namespace RestApiTemplate.Services
{
    public interface IHttpClientService
    {
        Task<string> Get(string requestUrl);
    }
}

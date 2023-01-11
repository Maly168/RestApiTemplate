using Newtonsoft.Json;
using RestApiTemplate.Model.Request;
using RestApiTemplate.Model.Response;

namespace RestApiTemplate.Services
{
    public class HolidayService : IHolidayService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly string _apiUrl;
        public HolidayService(IHttpClientService httpClientService, IConfiguration configuration)
        {
            _httpClientService = httpClientService;
            _apiUrl = configuration.GetValue<string>("ApiUrl");
        }
        public async Task<List<HolidayResponse>> GetHolidayForMonth(HolidayForMonthRequest request)
        {
            var url = GetHolidayForMonthApiUrl(request);
            var response = await GetDataFromApi(url);
            return response;
        }

        public async Task<List<HolidayResponse>> GetHolidayForYear(HolidayForYearRequest request)
        {
            var url = GetHolidayForYearApiUrl(request);
            var response = await GetDataFromApi(url);
            return response;
        }
        private async Task<List<HolidayResponse>> GetDataFromApi(string apiUrl)
        {
            var apiResponse = await _httpClientService.Get(apiUrl);
            var response = JsonConvert.DeserializeObject<List<HolidayResponse>>(apiResponse);
            return response;
        }
        private string GetHolidayForMonthApiUrl(HolidayForMonthRequest request)
        { 

          return $"{_apiUrl}action=getHolidaysForMonth&" +
                    $"month={request.Month}&year={request.Year}&" +
                    $"country={request.Country}" +
                    $"&region={request.Region}&" +
                    $"holidayType=public_holiday";
        }
        private string GetHolidayForYearApiUrl(HolidayForYearRequest request)
        {
            return $"{_apiUrl}action=getHolidaysForYear&" +
                $"year={request.Year}&" +
                $"country={request.Country}&" +
                $"holidayType=public_holiday";
        }
    }
}

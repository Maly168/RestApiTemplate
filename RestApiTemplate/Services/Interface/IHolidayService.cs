using RestApiTemplate.Model.Request;
using RestApiTemplate.Model.Response;

namespace RestApiTemplate.Services
{
    public interface IHolidayService
    {
        Task<List<HolidayResponse>> GetHolidayForMonth(HolidayForMonthRequest request);
        Task<List<HolidayResponse>> GetHolidayForYear(HolidayForYearRequest request);
    }
}

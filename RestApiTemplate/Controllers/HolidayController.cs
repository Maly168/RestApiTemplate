using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiTemplate.Model.Request;
using RestApiTemplate.Model.Response;
using RestApiTemplate.Services;

namespace RestApiTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayController : ControllerBase
    {
        private readonly IHolidayService _holidayService;

        public HolidayController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }

        [HttpPost("holidaysForMonth")]
        public async Task<List<HolidayResponse>> GetHolidayForMonth(HolidayForMonthRequest request)
        {
            return await _holidayService.GetHolidayForMonth(request);
        }

        [HttpPost("holidaysForYear")]
        public async Task<List<HolidayResponse>> GetHolidayForYear(HolidayForYearRequest request)
        {
            return await _holidayService.GetHolidayForYear(request);
        }
    }   
}

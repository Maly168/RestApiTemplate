namespace RestApiTemplate.Model.Request
{
    public class HolidayForMonthRequest : HolidayBaseRequest
    {
        public int Month { get; set; }
        public string Region { get; set; }
    }
}

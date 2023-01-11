using Newtonsoft.Json;

namespace RestApiTemplate.Model.Response
{
    public class HolidayResponse
    {
        [JsonProperty("date")]
        public HolidayDateData HolidayDate { get; set; }

        [JsonProperty("name")]
        public List<CountryNameData> CountryName { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class HolidayDateData
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("dayOfWeek")]
        public int DayOfWeek { get; set; }
    }

    public class CountryNameData
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

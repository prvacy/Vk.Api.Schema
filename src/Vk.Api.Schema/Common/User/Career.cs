using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="ICareer"/>
    /// </summary>
    public sealed class Career
    {

#pragma warning disable 1591

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        [JsonProperty("city_id")]
        public int? CityId { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("from_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FromDate { get; set; }

        [JsonProperty("until_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UntilDate { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }
}

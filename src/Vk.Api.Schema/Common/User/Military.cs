using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="IMilitary"/>
    /// </summary>
    class Military
    {

#pragma warning disable 1591

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        [JsonProperty("from_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FromDate { get; set; }

        [JsonProperty("until_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UntilDate { get; set; }
    }
}

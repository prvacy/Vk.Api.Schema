using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="ILastSeen"/>
    /// </summary>
    class LastSeen
    {

#pragma warning disable 1591

        [JsonProperty("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Time { get; set; }

        [JsonProperty("platform")]
        [JsonConverter(typeof(Platform))]
        public Platform? Platform { get; set; }
    }
}

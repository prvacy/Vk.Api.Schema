using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="IOccupation"/>
    /// </summary>
    class Occupation
    {

#pragma warning disable 1591

        [JsonProperty("occupation_type")]
        //TODO Converter for OccupationType?
        public OccupationType? Type { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

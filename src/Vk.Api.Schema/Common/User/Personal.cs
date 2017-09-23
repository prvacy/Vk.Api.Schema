using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="ICareer"/>
    /// </summary>
    class Personal
    {

#pragma warning disable 1591

        [JsonProperty("political")]
        //TODO Converter for PoliticalType?
        public PoliticalType? Political { get; set; }

        [JsonProperty("landuages")]
        public IEnumerable<string> Languages { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("political")]
        public string InspiredBy { get; set; }

        [JsonProperty("people_main")]
        //TODO Converter for PeopleMainType?
        public PeopleMainType? PeopleMain { get; set; }

        [JsonProperty("life_main")]
        //TODO Converter for LifeMainType?
        public LifeMainType? LifeMain { get; set; }

        [JsonProperty("smoking")]
        //TODO Converter for AttitudeType?
        public AttitudeType? Smoking { get; set; }

        [JsonProperty("alchohol")]
        public AttitudeType? Alcohol { get; set; }
    }
}

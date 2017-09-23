using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="IEducation"/>
    /// </summary>
    public sealed class Education : IEducation
    {

#pragma warning disable 1591

        [JsonProperty("university_id")]
        public int? UniversityId { get; set; }

        [JsonProperty("university_name")]
        public string UniversityName { get; set; }

        [JsonProperty("faculty_id")]
        public int? FacultyId { get; set; }

        [JsonProperty("faculty_name")]
        public string FacultyName { get; set; }

        [JsonProperty("graduation")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Graduation { get; set; }
    }
}

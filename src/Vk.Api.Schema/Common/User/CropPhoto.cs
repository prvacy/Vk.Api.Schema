using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="ICropPhoto"/>
    /// </summary>
    class CropPhoto
    {

#pragma warning disable 1591

        [JsonProperty("photo")]
        [JsonConverter(typeof(TypeConverter<Photo>))]
        public IPhoto Photo { get; set; }

        [JsonProperty("crop")]
        [JsonConverter(typeof(TypeConverter<Crop>))]
        public Rect Crop { get; set; }

        [JsonProperty("rect")]
        [JsonConverter(typeof(TypeConverter<Rect>))]
        public Rect Rect { get; set; }
    }
}

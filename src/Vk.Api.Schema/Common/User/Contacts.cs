using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="IContacts"/>
    /// </summary>
    class Contacts
    {
#pragma warning disable 1591

        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

        [JsonProperty("home_phone")]
        public string HomePhone { get; set; }
    }
}

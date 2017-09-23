using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Класс для десериализации <see cref="ICounters"/>
    /// </summary>
    class Counters
    {

#pragma warning disable 1591

        [JsonProperty("albums_count")]
        public int? AlbumsCount { get; set; }

        [JsonProperty("videos_count")]
        public int? VideosCount { get; set; }

        [JsonProperty("audios_count")]
        public int? AudiosCount { get; set; }

        [JsonProperty("photos_count")]
        public int? PhotosCount { get; set; }

        [JsonProperty("notes_count")]
        public int? NotesCount { get; set; }

        [JsonProperty("friends_count")]
        public int? FriendsCount { get; set; }

        [JsonProperty("droups_count")]
        public int? GroupsCount { get; set; }

        [JsonProperty("mutual_friends_count")]
        public int? MutualFriendscount { get; set; }

        [JsonProperty("videos_id")]
        public int? VideosCount { get; set; }

        [JsonProperty("followers_count")]
        public int? FollowersCount { get; set; }

        [JsonProperty("pages_count")]
        public int? PagesCount { get; set; }
    }
}

﻿using Newtonsoft.Json;

namespace IpData.Models
{
    public sealed class ApiError
    {
        public ApiError()
        {
        }

        public ApiError(string message)
        {
            Message = message;
        }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

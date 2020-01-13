﻿using Newtonsoft.Json;

namespace CS495_Capstone_Puma.DataStructure
{
    public class TokenResponse
    {
        [JsonProperty("Jwt")] public string Jwt { get; set; }

        [JsonProperty("ExpiresIn")] public int ExpiresIn { get; set; }

        [JsonProperty("IssuedDateTime")] public string IssuedDateTime { get; set; }

        [JsonProperty("ExpirationDateTime")] public string ExpirationDateTime { get; set; }

        public TokenResponse()
        {
            Jwt = "";
            ExpiresIn = -1;
            IssuedDateTime = "";
            ExpirationDateTime = "";
        }

        [JsonConstructor]
        public TokenResponse(string jwt, int expiresIn, string issuedDateTime, string expirationDateTime)
        {
            Jwt = jwt;
            ExpiresIn = expiresIn;
            IssuedDateTime = issuedDateTime;
            ExpirationDateTime = expirationDateTime;
        }
    }
}
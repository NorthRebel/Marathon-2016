﻿using System.Security;
using Newtonsoft.Json;

namespace Marathon.API.Models.User
{
    public class UserSignInCredentials
    {
        [JsonProperty]
        public string Email { get; set; }

        [JsonProperty]
        public SecureString Password { get; set; }
    }
}

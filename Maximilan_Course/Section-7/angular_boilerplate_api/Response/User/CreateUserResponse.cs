﻿using System.Text.Json.Serialization;

namespace BoilerPlate.Response.User
{
    /// <summary>
    /// This Class is used for Creating User Response
    /// </summary>
    public class CreateUserResponse
    {
        public int Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }

        public string Email { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        public string Status { get; set; }

        [JsonPropertyName("role_title")]
        public string RoleTitle { get; set; }

        [JsonPropertyName("role_id")]
        public int RoleId { get; set; }
    }
}

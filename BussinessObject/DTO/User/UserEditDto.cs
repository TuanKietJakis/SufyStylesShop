using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.User
{
    public class UserEditDto 
    {
        public Guid UserId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        [RegularExpression(@"^[\p{L}0-9._\s]+$", ErrorMessage = "Username contains invalid characters. Only letters, numbers, dots, underscores, and spaces are allowed.")]
        public string? Username { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(50, ErrorMessage = "Profile Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[\p{L}0-9._\s]+$", ErrorMessage = "ProfileName contains invalid characters. Only letters, numbers, dots, underscores, and spaces are allowed.")]
        public string? ProfileName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(150, ErrorMessage = "Url Image cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(500, ErrorMessage = "Bio cannot exceed 500 characters.")]
        public string? Bio { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[\p{L}0-9._\s]+$", ErrorMessage = "Lastname contains invalid characters. Only letters, numbers, dots, underscores, and spaces are allowed.")]
        public string? Lastname { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[\p{L}0-9._\s]+$", ErrorMessage = "Firstname contains invalid characters. Only letters, numbers, dots, underscores, and spaces are allowed.")]
        public string? Firstname { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateOnly? Birthday { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Gender { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsAcceptMarketing { get; set; }

    }
}

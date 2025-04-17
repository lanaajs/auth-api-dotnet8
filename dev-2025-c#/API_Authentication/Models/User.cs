using System.ComponentModel.DataAnnotations.Schema;

namespace API_Authentication
{
    public class User
    {
        public User() { }

        public User(string id, string email, string password, string firstName, string middleName, string lastName, string telephone, string jobTitle, bool firstAccess)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Telephone = telephone;
            JobTitle = jobTitle;
            FirstAccess = firstAccess;
        }

        [Column("id")]
        public required string Id { get; set; }

        [Column("email")]
        public required string Email { get; set; }

        [Column("password")]
        public required string Password { get; set; }

        [Column("first_name")]
        public required string FirstName { get; set; }

        [Column("middle_name")]
        public required string MiddleName { get; set; }

        [Column("last_name")]
        public required string LastName { get; set; }

        [Column("telephone")]
        public required string Telephone { get; set; }

        [Column("job_title")]
        public required string JobTitle { get; set; }

        [Column("first_access")]
        public required bool FirstAccess { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        [Column("profile_image_id")]
        public string? ProfileImageId { get; set; }

        [Column("legacy_id")]
        public string? LegacyId { get; set; }

        [Column("calendar_view")]
        public string? CalendarView { get; set; }

        [Column("username")]
        public string? Username { get; set; }

        [Column("role")]
        public string? Role { get; set; }

        [Column("tenant_id")]
        public string? TenantId { get; set; }

        [Column("language_id")]
        public string? LanguageId { get; set; }
    }
}

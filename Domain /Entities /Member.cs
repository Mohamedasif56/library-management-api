namespace LibraryManagement.Domain.Entities
{
    public class Member
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string? PhoneNumber { get; private set; }
        public DateTime RegisteredAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public Member(string fullName, string email, string? phoneNumber = null)
        {
            if(string.IsNullOrWhiteSpace(fullName)) throw new ArgumentException("FullName is required", nameof(fullName));
            if(string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email is required", nameof(email));

            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            RegisteredAt = DateTime.UtcNow;
        }

        public void Update(string fullName, string email, string? phoneNumber = null)
        {
            if(string.IsNullOrWhiteSpace(fullName)) throw new ArgumentException("FullName is required", nameof(fullName));
            if(string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email is required", nameof(email));

            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
